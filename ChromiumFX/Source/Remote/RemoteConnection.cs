// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.



using System;
using System.IO;
using System.IO.Pipes;
using System.Collections.Generic;
using System.Threading;

namespace Chromium.Remote {
    internal class RemoteConnection {


        private readonly PipeStream pipeIn;
        private readonly PipeStream pipeOut;
        internal readonly StreamHandler streamHandler;

        private readonly bool isClient;

        private readonly Queue<RemoteCall> requestQueue;
        private readonly Queue<RemoteCall> responseQueue;

        private readonly Thread writer;
        private readonly Thread reader;

        private readonly object syncRoot = new object();

        internal CfrRuntime remoteRuntime;

        internal bool ShuttingDown { get; private set; }
        internal Exception connectionLostException { get; private set; }

        internal readonly RemoteCallStack callStack;
        

        internal RemoteConnection(PipeStream pipeIn, PipeStream pipeOut, bool isClient) {
            
            this.pipeIn = pipeIn;
            this.pipeOut = pipeOut;
            this.isClient = isClient;

            callStack = new RemoteCallStack();

            requestQueue = new Queue<RemoteCall>();
            responseQueue = new Queue<RemoteCall>();
            streamHandler = new StreamHandler(pipeIn, pipeOut);

            if(!isClient)
                CfxRuntime.OnCfxShutdown += new Action(CfxRuntime_OnCfxShutdown);


            writer = new Thread(WriteLoopEntry);
            reader = new Thread(ReadLoopEntry);

            writer.IsBackground = true;
            reader.IsBackground = true;
            
            writer.Start();
            reader.Start();
        }

        void CfxRuntime_OnCfxShutdown() {
            ShuttingDown = true;
            callStack.ReleaseAll();
            RemoteService.connections.Remove(this);
        }

        internal void EnqueueRequest(RemoteCall call) {
            lock(syncRoot) {
                if(requestQueue.Count + responseQueue.Count == 0)
                    Monitor.PulseAll(syncRoot);
                requestQueue.Enqueue(call);
            }
        }

        internal void EnqueueResponse(RemoteCall call) {
            lock(syncRoot) {
                if(requestQueue.Count + responseQueue.Count == 0)
                    Monitor.PulseAll(syncRoot);
                responseQueue.Enqueue(call);
            }
        }

        internal void WriteLoopEntry() {
            try {
                Connect(pipeOut);
                WriteLoop();
            } catch(EndOfStreamException ex) {
                OnConnectionLost(ex);
            } catch(IOException ex) {
                OnConnectionLost(ex);
            }
        }

        internal void ReadLoopEntry() {
            try {
                Connect(pipeIn);
                ReadLoop();
            } catch(EndOfStreamException ex) {
                OnConnectionLost(ex);
            } catch(IOException ex) {
                OnConnectionLost(ex);
            }
        }

        private void Connect(PipeStream stream) {
            if(isClient) {
                ((NamedPipeClientStream)stream).Connect();
            } else {
                ((NamedPipeServerStream)stream).WaitForConnection();
            }
        }

        private void WriteLoop() {
            for(;;) {
                RemoteCall request = null;
                RemoteCall response = null;
                lock(syncRoot) {
                    if(requestQueue.Count + responseQueue.Count == 0) {
                        Monitor.Wait(syncRoot);
                        if(requestQueue.Count + responseQueue.Count == 0)
                            return;
                    }
                    if(requestQueue.Count > 0) 
                        request = requestQueue.Dequeue();
                    if(responseQueue.Count > 0) 
                        response = responseQueue.Dequeue();
                }
                if(request != null)
                    request.WriteRequest(streamHandler);
                if(response != null)
                    response.WriteResponse(streamHandler);
            }
        }

        private void ReadLoop() {
            for(;;) {
                var callId = streamHandler.ReadUInt16();
                if(callId == ushort.MaxValue) {
                    var threadId = streamHandler.ReadInt32();
                    var call = callStack.Pop(threadId);
                    call.ReadResponse(streamHandler);
                } else {
                    var call = RemoteCallSwitch.ForCallId((RemoteCallId)callId);
                    call.ReadRequest(this);
                }
            }
        }


        private void OnConnectionLost(Exception ex) {
            connectionLostException = ex;
            callStack.ReleaseAll();
            if(!isClient)
                RemoteService.connections.Remove(this);
        }
    }
}