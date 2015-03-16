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
    /// Structure used to represent drag data. The functions of this structure may be
    /// called on any thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
    /// </remarks>
    public class CfxDragData : CfxBase {

        static CfxDragData () {
            CfxApi.cfx_drag_data_create = (CfxApi.cfx_drag_data_create_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_create", typeof(CfxApi.cfx_drag_data_create_delegate));
            CfxApi.cfx_drag_data_clone = (CfxApi.cfx_drag_data_clone_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_clone", typeof(CfxApi.cfx_drag_data_clone_delegate));
            CfxApi.cfx_drag_data_is_read_only = (CfxApi.cfx_drag_data_is_read_only_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_is_read_only", typeof(CfxApi.cfx_drag_data_is_read_only_delegate));
            CfxApi.cfx_drag_data_is_link = (CfxApi.cfx_drag_data_is_link_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_is_link", typeof(CfxApi.cfx_drag_data_is_link_delegate));
            CfxApi.cfx_drag_data_is_fragment = (CfxApi.cfx_drag_data_is_fragment_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_is_fragment", typeof(CfxApi.cfx_drag_data_is_fragment_delegate));
            CfxApi.cfx_drag_data_is_file = (CfxApi.cfx_drag_data_is_file_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_is_file", typeof(CfxApi.cfx_drag_data_is_file_delegate));
            CfxApi.cfx_drag_data_get_link_url = (CfxApi.cfx_drag_data_get_link_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_link_url", typeof(CfxApi.cfx_drag_data_get_link_url_delegate));
            CfxApi.cfx_drag_data_get_link_title = (CfxApi.cfx_drag_data_get_link_title_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_link_title", typeof(CfxApi.cfx_drag_data_get_link_title_delegate));
            CfxApi.cfx_drag_data_get_link_metadata = (CfxApi.cfx_drag_data_get_link_metadata_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_link_metadata", typeof(CfxApi.cfx_drag_data_get_link_metadata_delegate));
            CfxApi.cfx_drag_data_get_fragment_text = (CfxApi.cfx_drag_data_get_fragment_text_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_fragment_text", typeof(CfxApi.cfx_drag_data_get_fragment_text_delegate));
            CfxApi.cfx_drag_data_get_fragment_html = (CfxApi.cfx_drag_data_get_fragment_html_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_fragment_html", typeof(CfxApi.cfx_drag_data_get_fragment_html_delegate));
            CfxApi.cfx_drag_data_get_fragment_base_url = (CfxApi.cfx_drag_data_get_fragment_base_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_fragment_base_url", typeof(CfxApi.cfx_drag_data_get_fragment_base_url_delegate));
            CfxApi.cfx_drag_data_get_file_name = (CfxApi.cfx_drag_data_get_file_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_file_name", typeof(CfxApi.cfx_drag_data_get_file_name_delegate));
            CfxApi.cfx_drag_data_get_file_contents = (CfxApi.cfx_drag_data_get_file_contents_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_file_contents", typeof(CfxApi.cfx_drag_data_get_file_contents_delegate));
            CfxApi.cfx_drag_data_get_file_names = (CfxApi.cfx_drag_data_get_file_names_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_get_file_names", typeof(CfxApi.cfx_drag_data_get_file_names_delegate));
            CfxApi.cfx_drag_data_set_link_url = (CfxApi.cfx_drag_data_set_link_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_set_link_url", typeof(CfxApi.cfx_drag_data_set_link_url_delegate));
            CfxApi.cfx_drag_data_set_link_title = (CfxApi.cfx_drag_data_set_link_title_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_set_link_title", typeof(CfxApi.cfx_drag_data_set_link_title_delegate));
            CfxApi.cfx_drag_data_set_link_metadata = (CfxApi.cfx_drag_data_set_link_metadata_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_set_link_metadata", typeof(CfxApi.cfx_drag_data_set_link_metadata_delegate));
            CfxApi.cfx_drag_data_set_fragment_text = (CfxApi.cfx_drag_data_set_fragment_text_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_set_fragment_text", typeof(CfxApi.cfx_drag_data_set_fragment_text_delegate));
            CfxApi.cfx_drag_data_set_fragment_html = (CfxApi.cfx_drag_data_set_fragment_html_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_set_fragment_html", typeof(CfxApi.cfx_drag_data_set_fragment_html_delegate));
            CfxApi.cfx_drag_data_set_fragment_base_url = (CfxApi.cfx_drag_data_set_fragment_base_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_set_fragment_base_url", typeof(CfxApi.cfx_drag_data_set_fragment_base_url_delegate));
            CfxApi.cfx_drag_data_reset_file_contents = (CfxApi.cfx_drag_data_reset_file_contents_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_reset_file_contents", typeof(CfxApi.cfx_drag_data_reset_file_contents_delegate));
            CfxApi.cfx_drag_data_add_file = (CfxApi.cfx_drag_data_add_file_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_drag_data_add_file", typeof(CfxApi.cfx_drag_data_add_file_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxDragData Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxDragData)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxDragData(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxDragData(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new CfxDragData object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public static CfxDragData Create() {
            return CfxDragData.Wrap(CfxApi.cfx_drag_data_create());
        }

        /// <summary>
        /// Returns true (1) if this object is read-only.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                return 0 != CfxApi.cfx_drag_data_is_read_only(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the drag data is a link.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public bool IsLink {
            get {
                return 0 != CfxApi.cfx_drag_data_is_link(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the drag data is a text or html fragment.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public bool IsFragment {
            get {
                return 0 != CfxApi.cfx_drag_data_is_fragment(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the drag data is a file.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public bool IsFile {
            get {
                return 0 != CfxApi.cfx_drag_data_is_file(NativePtr);
            }
        }

        /// <summary>
        /// Return the link URL that is being dragged.
        /// 
        /// Set the link URL that is being dragged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String LinkUrl {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_link_url(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_drag_data_set_link_url(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Return the title associated with the link being dragged.
        /// 
        /// Set the title associated with the link being dragged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String LinkTitle {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_link_title(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_drag_data_set_link_title(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged.
        /// 
        /// Set the metadata associated with the link being dragged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String LinkMetadata {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_link_metadata(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_drag_data_set_link_metadata(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// 
        /// Set the plain text fragment that is being dragged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String FragmentText {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_fragment_text(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_drag_data_set_fragment_text(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Return the text/html fragment that is being dragged.
        /// 
        /// Set the text/html fragment that is being dragged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String FragmentHtml {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_fragment_html(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_drag_data_set_fragment_html(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for
        /// resolving relative URLs and may be NULL.
        /// 
        /// Set the base URL that the fragment came from.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String FragmentBaseUrl {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_fragment_base_url(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_drag_data_set_fragment_base_url(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public String FileName {
            get {
                return StringUserfree.Convert(CfxApi.cfx_drag_data_get_file_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns a copy of the current object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public CfxDragData Clone() {
            return CfxDragData.Wrap(CfxApi.cfx_drag_data_clone(NativePtr));
        }

        /// <summary>
        /// Write the contents of the file being dragged out of the web view into
        /// |writer|. Returns the number of bytes sent to |writer|. If |writer| is NULL
        /// this function will return the size of the file contents in bytes. Call
        /// get_file_name() to get a suggested name for the file.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public int GetFileContents(CfxStreamWriter writer) {
            return CfxApi.cfx_drag_data_get_file_contents(NativePtr, CfxStreamWriter.Unwrap(writer));
        }

        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser
        /// window.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public int GetFileNames(System.Collections.Generic.List<string> names) {
            PinnedString[] names_handles;
            var names_unwrapped = StringFunctions.UnwrapCfxStringList(names, out names_handles);
            var __retval = CfxApi.cfx_drag_data_get_file_names(NativePtr, names_unwrapped);
            StringFunctions.FreePinnedStrings(names_handles);
            StringFunctions.CfxStringListCopyToManaged(names_unwrapped, names);
            CfxApi.cfx_string_list_free(names_unwrapped);
            return __retval;
        }

        /// <summary>
        /// Reset the file contents. You should do this before calling
        /// CfxBrowserHost.DragTargetDragEnter as the web view does not allow us
        /// to drag in this kind of data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public void ResetFileContents() {
            CfxApi.cfx_drag_data_reset_file_contents(NativePtr);
        }

        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_drag_data_capi.h">cef/include/capi/cef_drag_data_capi.h</see>.
        /// </remarks>
        public void AddFile(string path, string displayName) {
            var path_pinned = new PinnedString(path);
            var displayName_pinned = new PinnedString(displayName);
            CfxApi.cfx_drag_data_add_file(NativePtr, path_pinned.Obj.PinnedPtr, path_pinned.Length, displayName_pinned.Obj.PinnedPtr, displayName_pinned.Length);
            path_pinned.Obj.Free();
            displayName_pinned.Obj.Free();
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}