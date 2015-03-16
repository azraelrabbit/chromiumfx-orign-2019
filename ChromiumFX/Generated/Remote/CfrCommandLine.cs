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

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    /// <summary>
    /// Structure used to create and/or parse command line arguments. Arguments with
    /// '--', '-' and, on Windows, '/' prefixes are considered switches. Switches
    /// will always precede any arguments without switch prefixes. Switches can
    /// optionally have a value specified using the '=' delimiter (e.g.
    /// "-switch=value"). An argument of "--" will terminate switch parsing with all
    /// subsequent tokens, regardless of prefix, being interpreted as non-switch
    /// arguments. Switch names are considered case-insensitive. This structure can
    /// be used before cef_initialize() is called.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
    /// </remarks>
    public class CfrCommandLine : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrCommandLine Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrCommandLine)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrCommandLine(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Create a new CfrCommandLine instance.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public static CfrCommandLine Create(CfrRuntime remoteRuntime) {
            var call = new CfxCommandLineCreateRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrCommandLine.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the singleton global CfrCommandLine object. The returned object
        /// will be read-only.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public static CfrCommandLine GetGlobal(CfrRuntime remoteRuntime) {
            var call = new CfxCommandLineGetGlobalRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrCommandLine.Wrap(call.__retval, remoteRuntime);
        }


        private CfrCommandLine(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                var call = new CfxCommandLineIsValidRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                var call = new CfxCommandLineIsReadOnlyRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Constructs and returns the represented command line string. Use this
        /// function cautiously because quoting behavior is unclear.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public String CommandLineString {
            get {
                var call = new CfxCommandLineGetCommandLineStringRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// 
        /// Set the program part of the command line string (the first item).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public String Program {
            get {
                var call = new CfxCommandLineGetProgramRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
            set {
                var call = new CfxCommandLineSetProgramRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.value = value;
                call.Execute(remoteRuntime.connection);
            }
        }

        /// <summary>
        /// Returns true (1) if the command line has switches.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool HasSwitches {
            get {
                var call = new CfxCommandLineHasSwitchesRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if there are remaining command line arguments.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool HasArguments {
            get {
                var call = new CfxCommandLineHasArgumentsRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns a writable copy of this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public CfrCommandLine Copy() {
            var call = new CfxCommandLineCopyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
            return CfrCommandLine.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This function is only
        /// supported on non-Windows platforms.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void InitFromArgv(int argc, RemotePtr argv) {
            var call = new CfxCommandLineInitFromArgvRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.argc = argc;
            call.argv = argv.ptr;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This function is only supported on Windows.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void InitFromString(string commandLine) {
            var call = new CfxCommandLineInitFromStringRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.commandLine = commandLine;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void Reset() {
            var call = new CfxCommandLineResetRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Retrieve the original command line string as a vector of strings. The argv
        /// array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void GetArgv(System.Collections.Generic.List<string> argv) {
            var call = new CfxCommandLineGetArgvRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.argv = argv;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Returns true (1) if the command line contains the given switch.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool HasSwitch(string name) {
            var call = new CfxCommandLineHasSwitchRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.name = name;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this function returns the NULL string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public String GetSwitchValue(string name) {
            var call = new CfxCommandLineGetSwitchValueRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.name = name;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// NULL string is returned.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void GetSwitches(System.Collections.Generic.List<string[]> switches) {
            var call = new CfxCommandLineGetSwitchesRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.switches = switches;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an NULL value string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void AppendSwitch(string name) {
            var call = new CfxCommandLineAppendSwitchRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.name = name;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void AppendSwitchWithValue(string name, string value) {
            var call = new CfxCommandLineAppendSwitchWithValueRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.name = name;
            call.value = value;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Get the remaining command line arguments.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void GetArguments(System.Collections.Generic.List<string> arguments) {
            var call = new CfxCommandLineGetArgumentsRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.arguments = arguments;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Add an argument to the end of the command line.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void AppendArgument(string argument) {
            var call = new CfxCommandLineAppendArgumentRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.argument = argument;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Insert a command before the current command. Common for debuggers, like
        /// "valgrind" or "gdb --args".
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void PrependWrapper(string wrapper) {
            var call = new CfxCommandLinePrependWrapperRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.wrapper = wrapper;
            call.Execute(remoteRuntime.connection);
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}