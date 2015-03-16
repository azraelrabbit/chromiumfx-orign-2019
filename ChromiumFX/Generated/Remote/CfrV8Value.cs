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
    /// Structure representing a V8 value handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CfrV8Context.GetTaskRunner() function.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
    /// </remarks>
    public partial class CfrV8Value : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrV8Value Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrV8Value)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrV8Value(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Create a new CfrV8Value object of type undefined.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateUndefined(CfrRuntime remoteRuntime) {
            var call = new CfxV8ValueCreateUndefinedRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type null.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateNull(CfrRuntime remoteRuntime) {
            var call = new CfxV8ValueCreateNullRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type bool.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateBool(CfrRuntime remoteRuntime, bool value) {
            var call = new CfxV8ValueCreateBoolRenderProcessCall();
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateInt(CfrRuntime remoteRuntime, int value) {
            var call = new CfxV8ValueCreateIntRenderProcessCall();
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type unsigned int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateUint(CfrRuntime remoteRuntime, uint value) {
            var call = new CfxV8ValueCreateUintRenderProcessCall();
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type double.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateDouble(CfrRuntime remoteRuntime, double value) {
            var call = new CfxV8ValueCreateDoubleRenderProcessCall();
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type Date. This function should only be
        /// called from within the scope of a cef_v8context_tHandler, CfrV8Handler or
        /// CfrV8Accessor callback, or in combination with calling enter() and exit()
        /// on a stored CfrV8Context reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateDate(CfrRuntime remoteRuntime, CfrTime date) {
            var call = new CfxV8ValueCreateDateRenderProcessCall();
            call.date = CfrObject.Unwrap(date);
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateString(CfrRuntime remoteRuntime, string value) {
            var call = new CfxV8ValueCreateStringRenderProcessCall();
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type object with optional accessor. This
        /// function should only be called from within the scope of a
        /// cef_v8context_tHandler, CfrV8Handler or CfrV8Accessor callback, or in
        /// combination with calling enter() and exit() on a stored CfrV8Context
        /// reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateObject(CfrRuntime remoteRuntime, CfrV8Accessor accessor) {
            var call = new CfxV8ValueCreateObjectRenderProcessCall();
            call.accessor = CfrObject.Unwrap(accessor);
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type array with the specified |length|.
        /// If |length| is negative the returned array will have length 0. This function
        /// should only be called from within the scope of a cef_v8context_tHandler,
        /// CfrV8Handler or CfrV8Accessor callback, or in combination with calling
        /// enter() and exit() on a stored CfrV8Context reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateArray(CfrRuntime remoteRuntime, int length) {
            var call = new CfxV8ValueCreateArrayRenderProcessCall();
            call.length = length;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Create a new CfrV8Value object of type function. This function should only
        /// be called from within the scope of a cef_v8context_tHandler, CfrV8Handler
        /// or CfrV8Accessor callback, or in combination with calling enter() and
        /// exit() on a stored CfrV8Context reference.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public static CfrV8Value CreateFunction(CfrRuntime remoteRuntime, string name, CfrV8Handler handler) {
            var call = new CfxV8ValueCreateFunctionRenderProcessCall();
            call.name = name;
            call.handler = CfrObject.Unwrap(handler);
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }


        private CfrV8Value(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns true (1) if the underlying handle is valid and it can be accessed
        /// on the current thread. Do not call any other functions if this function
        /// returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                var call = new CfxV8ValueIsValidRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is undefined.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsUndefined {
            get {
                var call = new CfxV8ValueIsUndefinedRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is null.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsNull {
            get {
                var call = new CfxV8ValueIsNullRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is bool.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsBool {
            get {
                var call = new CfxV8ValueIsBoolRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsInt {
            get {
                var call = new CfxV8ValueIsIntRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is unsigned int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsUint {
            get {
                var call = new CfxV8ValueIsUintRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is double.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsDouble {
            get {
                var call = new CfxV8ValueIsDoubleRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is Date.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsDate {
            get {
                var call = new CfxV8ValueIsDateRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsString {
            get {
                var call = new CfxV8ValueIsStringRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsObject {
            get {
                var call = new CfxV8ValueIsObjectRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is array.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsArray {
            get {
                var call = new CfxV8ValueIsArrayRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if the value type is function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsFunction {
            get {
                var call = new CfxV8ValueIsFunctionRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return a bool value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool BoolValue {
            get {
                var call = new CfxV8ValueGetBoolValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return an int value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int IntValue {
            get {
                var call = new CfxV8ValueGetIntValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return an unisgned int value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public uint UintValue {
            get {
                var call = new CfxV8ValueGetUintValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return a double value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public double DoubleValue {
            get {
                var call = new CfxV8ValueGetDoubleValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return a Date value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrTime DateValue {
            get {
                var call = new CfxV8ValueGetDateValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrTime.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Return a string value.  The underlying data will be converted to if
        /// necessary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public String StringValue {
            get {
                var call = new CfxV8ValueGetStringValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// OBJECT METHODS - These functions are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true (1) if this is a user created object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsUserCreated {
            get {
                var call = new CfxV8ValueIsUserCreatedRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the last function call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool HasException {
            get {
                var call = new CfxV8ValueHasExceptionRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the exception resulting from the last function call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrV8Exception Exception {
            get {
                var call = new CfxV8ValueGetExceptionRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrV8Exception.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public RemotePtr UserData {
            get {
                var call = new CfxV8ValueGetUserDataRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return new RemotePtr(call.__retval);
            }
        }

        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int ExternallyAllocatedMemory {
            get {
                var call = new CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// ARRAY METHODS - These functions are only available on arrays.
        /// Returns the number of elements in the array.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int ArrayLength {
            get {
                var call = new CfxV8ValueGetArrayLengthRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// FUNCTION METHODS - These functions are only available on functions.
        /// Returns the function name.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public String FunctionName {
            get {
                var call = new CfxV8ValueGetFunctionNameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrV8Handler FunctionHandler {
            get {
                var call = new CfxV8ValueGetFunctionHandlerRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrV8Handler.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool IsSame(CfrV8Value that) {
            var call = new CfxV8ValueIsSameRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.that = CfrObject.Unwrap(that);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Clears the last exception and returns true (1) on success.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool ClearException() {
            var call = new CfxV8ValueClearExceptionRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if this object will re-throw future exceptions. This
        /// attribute exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool WillRethrowExceptions() {
            var call = new CfxV8ValueWillRethrowExceptionsRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Set whether this object will re-throw future exceptions. By default
        /// exceptions are not re-thrown. If a exception is re-thrown the current
        /// context should not be accessed again until after the exception has been
        /// caught and not re-thrown. Returns true (1) on success. This attribute
        /// exists only in the scope of the current CEF value object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetRethrowExceptions(int rethrow) {
            var call = new CfxV8ValueSetRethrowExceptionsRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.rethrow = rethrow;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the object has a value with the specified identifier.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool HasValueByKey(string key) {
            var call = new CfxV8ValueHasValueByKeyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the object has a value with the specified identifier.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool HasValueByIndex(bool index) {
            var call = new CfxV8ValueHasValueByIndexRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.index = index;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Deletes the value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only and don't-delete values this function
        /// will return true (1) even though deletion failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool DeleteValueByKey(string key) {
            var call = new CfxV8ValueDeleteValueByKeyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Deletes the value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly, deletion
        /// fails or an exception is thrown. For read-only and don't-delete values this
        /// function will return true (1) even though deletion failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool DeleteValueByIndex(bool index) {
            var call = new CfxV8ValueDeleteValueByIndexRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.index = index;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value with the specified identifier on success. Returns NULL if
        /// this function is called incorrectly or an exception is thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrV8Value GetValueByKey(string key) {
            var call = new CfxV8ValueGetValueByKeyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Returns the value with the specified identifier on success. Returns NULL if
        /// this function is called incorrectly or an exception is thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrV8Value GetValueByIndex(int index) {
            var call = new CfxV8ValueGetValueByIndexRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.index = index;
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Associates a value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only values this function will return true
        /// (1) even though assignment failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetValueByKey(string key, CfrV8Value value, CfxV8PropertyAttribute attribute) {
            var call = new CfxV8ValueSetValueByKeyRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.value = CfrObject.Unwrap(value);
            call.attribute = (int)attribute;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Associates a value with the specified identifier and returns true (1) on
        /// success. Returns false (0) if this function is called incorrectly or an
        /// exception is thrown. For read-only values this function will return true
        /// (1) even though assignment failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetValueByIndex(bool index, CfrV8Value value) {
            var call = new CfxV8ValueSetValueByIndexRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.index = index;
            call.value = CfrObject.Unwrap(value);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Registers an identifier and returns true (1) on success. Access to the
        /// identifier will be forwarded to the CfrV8Accessor instance passed to
        /// CfrV8Value.CfrV8ValueCreateObject(). Returns false (0) if this
        /// function is called incorrectly or an exception is thrown. For read-only
        /// values this function will return true (1) even though assignment failed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetValueByAccessor(string key, CfxV8AccessControl settings, CfxV8PropertyAttribute attribute) {
            var call = new CfxV8ValueSetValueByAccessorRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.key = key;
            call.settings = (int)settings;
            call.attribute = (int)attribute;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int GetKeys(System.Collections.Generic.List<string> keys) {
            var call = new CfxV8ValueGetKeysRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.keys = keys;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the user data for this object and returns true (1) on success. Returns
        /// false (0) if this function is called incorrectly. This function can only be
        /// called on user created objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public bool SetUserData(RemotePtr userData) {
            var call = new CfxV8ValueSetUserDataRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.userData = userData.ptr;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Adjusts the amount of registered external memory for the object. Used to
        /// give V8 an indication of the amount of externally allocated memory that is
        /// kept alive by JavaScript objects. V8 uses this information to decide when
        /// to perform global garbage collection. Each CfrV8Value tracks the amount
        /// of external memory associated with it and automatically decreases the
        /// global total by the appropriate amount on its destruction.
        /// |changeInBytes| specifies the number of bytes to adjust by. This function
        /// returns the number of bytes associated with the object after the
        /// adjustment. This function can only be called on user created objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public int AdjustExternallyAllocatedMemory(int changeInBytes) {
            var call = new CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.changeInBytes = changeInBytes;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Execute the function using the current V8 context. This function should
        /// only be called from within the scope of a CfrV8Handler or
        /// CfrV8Accessor callback, or in combination with calling enter() and
        /// exit() on a stored CfrV8Context reference. |object| is the receiver
        /// ('this' object) of the function. If |object| is NULL the current context's
        /// global object will be used. |arguments| is the list of arguments that will
        /// be passed to the function. Returns the function return value on success.
        /// Returns NULL if this function is called incorrectly or an exception is
        /// thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrV8Value ExecuteFunction(CfrV8Value @object, CfrV8Value[] arguments) {
            var call = new CfxV8ValueExecuteFunctionRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.@object = CfrObject.Unwrap(@object);
            if(arguments != null) {
                call.arguments = new ulong[arguments.Length];
                for(int i = 0; i < arguments.Length; ++i) {
                    call.arguments[i] = CfrObject.Unwrap(arguments[i]);
                }
            }
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        /// <summary>
        /// Execute the function using the specified V8 context. |object| is the
        /// receiver ('this' object) of the function. If |object| is NULL the specified
        /// context's global object will be used. |arguments| is the list of arguments
        /// that will be passed to the function. Returns the function return value on
        /// success. Returns NULL if this function is called incorrectly or an
        /// exception is thrown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_v8_capi.h">cef/include/capi/cef_v8_capi.h</see>.
        /// </remarks>
        public CfrV8Value ExecuteFunctionWithContext(CfrV8Context context, CfrV8Value @object, CfrV8Value[] arguments) {
            var call = new CfxV8ValueExecuteFunctionWithContextRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.context = CfrObject.Unwrap(context);
            call.@object = CfrObject.Unwrap(@object);
            if(arguments != null) {
                call.arguments = new ulong[arguments.Length];
                for(int i = 0; i < arguments.Length; ++i) {
                    call.arguments[i] = CfrObject.Unwrap(arguments[i]);
                }
            }
            call.Execute(remoteRuntime.connection);
            return CfrV8Value.Wrap(call.__retval, remoteRuntime);
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}