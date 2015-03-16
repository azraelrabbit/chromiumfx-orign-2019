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

namespace Chromium {
    /// <summary>
    /// Structure used to represent a web response. The functions of this structure
    /// may be called on any thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
    /// </remarks>
    public partial class CfxResponse : CfxBase {

        static CfxResponse () {
            CfxApi.cfx_response_create = (CfxApi.cfx_response_create_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_create", typeof(CfxApi.cfx_response_create_delegate));
            CfxApi.cfx_response_is_read_only = (CfxApi.cfx_response_is_read_only_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_is_read_only", typeof(CfxApi.cfx_response_is_read_only_delegate));
            CfxApi.cfx_response_get_status = (CfxApi.cfx_response_get_status_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_get_status", typeof(CfxApi.cfx_response_get_status_delegate));
            CfxApi.cfx_response_set_status = (CfxApi.cfx_response_set_status_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_set_status", typeof(CfxApi.cfx_response_set_status_delegate));
            CfxApi.cfx_response_get_status_text = (CfxApi.cfx_response_get_status_text_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_get_status_text", typeof(CfxApi.cfx_response_get_status_text_delegate));
            CfxApi.cfx_response_set_status_text = (CfxApi.cfx_response_set_status_text_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_set_status_text", typeof(CfxApi.cfx_response_set_status_text_delegate));
            CfxApi.cfx_response_get_mime_type = (CfxApi.cfx_response_get_mime_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_get_mime_type", typeof(CfxApi.cfx_response_get_mime_type_delegate));
            CfxApi.cfx_response_set_mime_type = (CfxApi.cfx_response_set_mime_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_set_mime_type", typeof(CfxApi.cfx_response_set_mime_type_delegate));
            CfxApi.cfx_response_get_header = (CfxApi.cfx_response_get_header_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_get_header", typeof(CfxApi.cfx_response_get_header_delegate));
            CfxApi.cfx_response_get_header_map = (CfxApi.cfx_response_get_header_map_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_get_header_map", typeof(CfxApi.cfx_response_get_header_map_delegate));
            CfxApi.cfx_response_set_header_map = (CfxApi.cfx_response_set_header_map_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_response_set_header_map", typeof(CfxApi.cfx_response_set_header_map_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxResponse Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxResponse)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxResponse(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxResponse(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new CfxResponse object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public static CfxResponse Create() {
            return CfxResponse.Wrap(CfxApi.cfx_response_create());
        }

        /// <summary>
        /// Returns true (1) if this object is read-only.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                return 0 != CfxApi.cfx_response_is_read_only(NativePtr);
            }
        }

        /// <summary>
        /// Get the response status code.
        /// 
        /// Set the response status code.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public int Status {
            get {
                return CfxApi.cfx_response_get_status(NativePtr);
            }
            set {
                CfxApi.cfx_response_set_status(NativePtr, value);
            }
        }

        /// <summary>
        /// Get the response status text.
        /// 
        /// Set the response status text.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public String StatusText {
            get {
                return StringUserfree.Convert(CfxApi.cfx_response_get_status_text(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_response_set_status_text(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Get the response mime type.
        /// 
        /// Set the response mime type.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public String MimeType {
            get {
                return StringUserfree.Convert(CfxApi.cfx_response_get_mime_type(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_response_set_mime_type(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Get the value for the specified response header field.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public String GetHeader(string name) {
            var name_pinned = new PinnedString(name);
            var __retval = CfxApi.cfx_response_get_header(NativePtr, name_pinned.Obj.PinnedPtr, name_pinned.Length);
            name_pinned.Obj.Free();
            return StringUserfree.Convert(__retval);
        }

        /// <summary>
        /// Get all response header fields.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public void GetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = StringFunctions.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.cfx_response_get_header_map(NativePtr, headerMap_unwrapped);
            StringFunctions.FreePinnedStrings(headerMap_handles);
            StringFunctions.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.cfx_string_multimap_free(headerMap_unwrapped);
        }

        /// <summary>
        /// Set all response header fields.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_response_capi.h">cef/include/capi/cef_response_capi.h</see>.
        /// </remarks>
        public void SetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = StringFunctions.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.cfx_response_set_header_map(NativePtr, headerMap_unwrapped);
            StringFunctions.FreePinnedStrings(headerMap_handles);
            StringFunctions.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.cfx_string_multimap_free(headerMap_unwrapped);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}