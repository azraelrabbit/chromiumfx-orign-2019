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
    /// Information about a specific web plugin.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
    /// </remarks>
    public class CfxWebPluginInfo : CfxBase {

        static CfxWebPluginInfo () {
            CfxApi.cfx_web_plugin_info_get_name = (CfxApi.cfx_web_plugin_info_get_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_web_plugin_info_get_name", typeof(CfxApi.cfx_web_plugin_info_get_name_delegate));
            CfxApi.cfx_web_plugin_info_get_path = (CfxApi.cfx_web_plugin_info_get_path_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_web_plugin_info_get_path", typeof(CfxApi.cfx_web_plugin_info_get_path_delegate));
            CfxApi.cfx_web_plugin_info_get_version = (CfxApi.cfx_web_plugin_info_get_version_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_web_plugin_info_get_version", typeof(CfxApi.cfx_web_plugin_info_get_version_delegate));
            CfxApi.cfx_web_plugin_info_get_description = (CfxApi.cfx_web_plugin_info_get_description_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_web_plugin_info_get_description", typeof(CfxApi.cfx_web_plugin_info_get_description_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxWebPluginInfo Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxWebPluginInfo)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxWebPluginInfo(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxWebPluginInfo(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns the plugin name (i.e. Flash).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public String Name {
            get {
                return StringUserfree.Convert(CfxApi.cfx_web_plugin_info_get_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns the plugin file path (DLL/bundle/library).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public String Path {
            get {
                return StringUserfree.Convert(CfxApi.cfx_web_plugin_info_get_path(NativePtr));
            }
        }

        /// <summary>
        /// Returns the version of the plugin (may be OS-specific).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public String Version {
            get {
                return StringUserfree.Convert(CfxApi.cfx_web_plugin_info_get_version(NativePtr));
            }
        }

        /// <summary>
        /// Returns a description of the plugin from the version information.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_web_plugin_capi.h">cef/include/capi/cef_web_plugin_capi.h</see>.
        /// </remarks>
        public String Description {
            get {
                return StringUserfree.Convert(CfxApi.cfx_web_plugin_info_get_description(NativePtr));
            }
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}