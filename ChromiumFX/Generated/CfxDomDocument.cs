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
    /// Structure used to represent a DOM document. The functions of this structure
    /// should only be called on the render process main thread thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
    /// </remarks>
    public class CfxDomDocument : CfxBase {

        static CfxDomDocument () {
            CfxApi.cfx_domdocument_get_type = (CfxApi.cfx_domdocument_get_type_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_type", typeof(CfxApi.cfx_domdocument_get_type_delegate));
            CfxApi.cfx_domdocument_get_document = (CfxApi.cfx_domdocument_get_document_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_document", typeof(CfxApi.cfx_domdocument_get_document_delegate));
            CfxApi.cfx_domdocument_get_body = (CfxApi.cfx_domdocument_get_body_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_body", typeof(CfxApi.cfx_domdocument_get_body_delegate));
            CfxApi.cfx_domdocument_get_head = (CfxApi.cfx_domdocument_get_head_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_head", typeof(CfxApi.cfx_domdocument_get_head_delegate));
            CfxApi.cfx_domdocument_get_title = (CfxApi.cfx_domdocument_get_title_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_title", typeof(CfxApi.cfx_domdocument_get_title_delegate));
            CfxApi.cfx_domdocument_get_element_by_id = (CfxApi.cfx_domdocument_get_element_by_id_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_element_by_id", typeof(CfxApi.cfx_domdocument_get_element_by_id_delegate));
            CfxApi.cfx_domdocument_get_focused_node = (CfxApi.cfx_domdocument_get_focused_node_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_focused_node", typeof(CfxApi.cfx_domdocument_get_focused_node_delegate));
            CfxApi.cfx_domdocument_has_selection = (CfxApi.cfx_domdocument_has_selection_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_has_selection", typeof(CfxApi.cfx_domdocument_has_selection_delegate));
            CfxApi.cfx_domdocument_get_selection_start_node = (CfxApi.cfx_domdocument_get_selection_start_node_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_selection_start_node", typeof(CfxApi.cfx_domdocument_get_selection_start_node_delegate));
            CfxApi.cfx_domdocument_get_selection_start_offset = (CfxApi.cfx_domdocument_get_selection_start_offset_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_selection_start_offset", typeof(CfxApi.cfx_domdocument_get_selection_start_offset_delegate));
            CfxApi.cfx_domdocument_get_selection_end_node = (CfxApi.cfx_domdocument_get_selection_end_node_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_selection_end_node", typeof(CfxApi.cfx_domdocument_get_selection_end_node_delegate));
            CfxApi.cfx_domdocument_get_selection_end_offset = (CfxApi.cfx_domdocument_get_selection_end_offset_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_selection_end_offset", typeof(CfxApi.cfx_domdocument_get_selection_end_offset_delegate));
            CfxApi.cfx_domdocument_get_selection_as_markup = (CfxApi.cfx_domdocument_get_selection_as_markup_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_selection_as_markup", typeof(CfxApi.cfx_domdocument_get_selection_as_markup_delegate));
            CfxApi.cfx_domdocument_get_selection_as_text = (CfxApi.cfx_domdocument_get_selection_as_text_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_selection_as_text", typeof(CfxApi.cfx_domdocument_get_selection_as_text_delegate));
            CfxApi.cfx_domdocument_get_base_url = (CfxApi.cfx_domdocument_get_base_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_base_url", typeof(CfxApi.cfx_domdocument_get_base_url_delegate));
            CfxApi.cfx_domdocument_get_complete_url = (CfxApi.cfx_domdocument_get_complete_url_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_domdocument_get_complete_url", typeof(CfxApi.cfx_domdocument_get_complete_url_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxDomDocument Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxDomDocument)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxDomDocument(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxDomDocument(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns the document type.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomDocumentType Type {
            get {
                return CfxApi.cfx_domdocument_get_type(NativePtr);
            }
        }

        /// <summary>
        /// Returns the root document node.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode Document {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domdocument_get_document(NativePtr));
            }
        }

        /// <summary>
        /// Returns the BODY node of an HTML document.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode Body {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domdocument_get_body(NativePtr));
            }
        }

        /// <summary>
        /// Returns the HEAD node of an HTML document.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode Head {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domdocument_get_head(NativePtr));
            }
        }

        /// <summary>
        /// Returns the title of an HTML document.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public String Title {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domdocument_get_title(NativePtr));
            }
        }

        /// <summary>
        /// Returns the node that currently has keyboard focus.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode FocusedNode {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domdocument_get_focused_node(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if a portion of the document is selected.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public bool HasSelection {
            get {
                return 0 != CfxApi.cfx_domdocument_has_selection(NativePtr);
            }
        }

        /// <summary>
        /// Returns the selection start node.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode SelectionStartNode {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domdocument_get_selection_start_node(NativePtr));
            }
        }

        /// <summary>
        /// Returns the selection offset within the start node.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public int SelectionStartOffset {
            get {
                return CfxApi.cfx_domdocument_get_selection_start_offset(NativePtr);
            }
        }

        /// <summary>
        /// Returns the selection end node.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode SelectionEndNode {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domdocument_get_selection_end_node(NativePtr));
            }
        }

        /// <summary>
        /// Returns the selection offset within the end node.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public int SelectionEndOffset {
            get {
                return CfxApi.cfx_domdocument_get_selection_end_offset(NativePtr);
            }
        }

        /// <summary>
        /// Returns the contents of this selection as markup.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public String SelectionAsMarkup {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domdocument_get_selection_as_markup(NativePtr));
            }
        }

        /// <summary>
        /// Returns the contents of this selection as text.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public String SelectionAsText {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domdocument_get_selection_as_text(NativePtr));
            }
        }

        /// <summary>
        /// Returns the base URL for the document.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public String BaseUrl {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domdocument_get_base_url(NativePtr));
            }
        }

        /// <summary>
        /// Returns the document element with the specified ID value.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public CfxDomNode GetElementById(string id) {
            var id_pinned = new PinnedString(id);
            var __retval = CfxApi.cfx_domdocument_get_element_by_id(NativePtr, id_pinned.Obj.PinnedPtr, id_pinned.Length);
            id_pinned.Obj.Free();
            return CfxDomNode.Wrap(__retval);
        }

        /// <summary>
        /// Returns a complete URL based on the document base URL and the specified
        /// partial URL.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_dom_capi.h">cef/include/capi/cef_dom_capi.h</see>.
        /// </remarks>
        public String GetCompleteUrl(string partialURL) {
            var partialURL_pinned = new PinnedString(partialURL);
            var __retval = CfxApi.cfx_domdocument_get_complete_url(NativePtr, partialURL_pinned.Obj.PinnedPtr, partialURL_pinned.Length);
            partialURL_pinned.Obj.Free();
            return StringUserfree.Convert(__retval);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}