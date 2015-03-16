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
    /// Structure used to represent the browser process aspects of a browser window.
    /// The functions of this structure can only be called in the browser process.
    /// They may be called on any thread in that process unless otherwise indicated
    /// in the comments.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
    /// </remarks>
    public class CfxBrowserHost : CfxBase {

        static CfxBrowserHost () {
            CfxApi.cfx_browser_host_create_browser = (CfxApi.cfx_browser_host_create_browser_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_create_browser", typeof(CfxApi.cfx_browser_host_create_browser_delegate));
            CfxApi.cfx_browser_host_create_browser_sync = (CfxApi.cfx_browser_host_create_browser_sync_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_create_browser_sync", typeof(CfxApi.cfx_browser_host_create_browser_sync_delegate));
            CfxApi.cfx_browser_host_get_browser = (CfxApi.cfx_browser_host_get_browser_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_browser", typeof(CfxApi.cfx_browser_host_get_browser_delegate));
            CfxApi.cfx_browser_host_close_browser = (CfxApi.cfx_browser_host_close_browser_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_close_browser", typeof(CfxApi.cfx_browser_host_close_browser_delegate));
            CfxApi.cfx_browser_host_set_focus = (CfxApi.cfx_browser_host_set_focus_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_set_focus", typeof(CfxApi.cfx_browser_host_set_focus_delegate));
            CfxApi.cfx_browser_host_set_window_visibility = (CfxApi.cfx_browser_host_set_window_visibility_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_set_window_visibility", typeof(CfxApi.cfx_browser_host_set_window_visibility_delegate));
            CfxApi.cfx_browser_host_get_window_handle = (CfxApi.cfx_browser_host_get_window_handle_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_window_handle", typeof(CfxApi.cfx_browser_host_get_window_handle_delegate));
            CfxApi.cfx_browser_host_get_opener_window_handle = (CfxApi.cfx_browser_host_get_opener_window_handle_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_opener_window_handle", typeof(CfxApi.cfx_browser_host_get_opener_window_handle_delegate));
            CfxApi.cfx_browser_host_get_client = (CfxApi.cfx_browser_host_get_client_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_client", typeof(CfxApi.cfx_browser_host_get_client_delegate));
            CfxApi.cfx_browser_host_get_request_context = (CfxApi.cfx_browser_host_get_request_context_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_request_context", typeof(CfxApi.cfx_browser_host_get_request_context_delegate));
            CfxApi.cfx_browser_host_get_zoom_level = (CfxApi.cfx_browser_host_get_zoom_level_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_zoom_level", typeof(CfxApi.cfx_browser_host_get_zoom_level_delegate));
            CfxApi.cfx_browser_host_set_zoom_level = (CfxApi.cfx_browser_host_set_zoom_level_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_set_zoom_level", typeof(CfxApi.cfx_browser_host_set_zoom_level_delegate));
            CfxApi.cfx_browser_host_run_file_dialog = (CfxApi.cfx_browser_host_run_file_dialog_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_run_file_dialog", typeof(CfxApi.cfx_browser_host_run_file_dialog_delegate));
            CfxApi.cfx_browser_host_start_download = (CfxApi.cfx_browser_host_start_download_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_start_download", typeof(CfxApi.cfx_browser_host_start_download_delegate));
            CfxApi.cfx_browser_host_print = (CfxApi.cfx_browser_host_print_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_print", typeof(CfxApi.cfx_browser_host_print_delegate));
            CfxApi.cfx_browser_host_find = (CfxApi.cfx_browser_host_find_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_find", typeof(CfxApi.cfx_browser_host_find_delegate));
            CfxApi.cfx_browser_host_stop_finding = (CfxApi.cfx_browser_host_stop_finding_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_stop_finding", typeof(CfxApi.cfx_browser_host_stop_finding_delegate));
            CfxApi.cfx_browser_host_show_dev_tools = (CfxApi.cfx_browser_host_show_dev_tools_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_show_dev_tools", typeof(CfxApi.cfx_browser_host_show_dev_tools_delegate));
            CfxApi.cfx_browser_host_close_dev_tools = (CfxApi.cfx_browser_host_close_dev_tools_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_close_dev_tools", typeof(CfxApi.cfx_browser_host_close_dev_tools_delegate));
            CfxApi.cfx_browser_host_get_navigation_entries = (CfxApi.cfx_browser_host_get_navigation_entries_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_navigation_entries", typeof(CfxApi.cfx_browser_host_get_navigation_entries_delegate));
            CfxApi.cfx_browser_host_set_mouse_cursor_change_disabled = (CfxApi.cfx_browser_host_set_mouse_cursor_change_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_set_mouse_cursor_change_disabled", typeof(CfxApi.cfx_browser_host_set_mouse_cursor_change_disabled_delegate));
            CfxApi.cfx_browser_host_is_mouse_cursor_change_disabled = (CfxApi.cfx_browser_host_is_mouse_cursor_change_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_is_mouse_cursor_change_disabled", typeof(CfxApi.cfx_browser_host_is_mouse_cursor_change_disabled_delegate));
            CfxApi.cfx_browser_host_replace_misspelling = (CfxApi.cfx_browser_host_replace_misspelling_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_replace_misspelling", typeof(CfxApi.cfx_browser_host_replace_misspelling_delegate));
            CfxApi.cfx_browser_host_add_word_to_dictionary = (CfxApi.cfx_browser_host_add_word_to_dictionary_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_add_word_to_dictionary", typeof(CfxApi.cfx_browser_host_add_word_to_dictionary_delegate));
            CfxApi.cfx_browser_host_is_window_rendering_disabled = (CfxApi.cfx_browser_host_is_window_rendering_disabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_is_window_rendering_disabled", typeof(CfxApi.cfx_browser_host_is_window_rendering_disabled_delegate));
            CfxApi.cfx_browser_host_was_resized = (CfxApi.cfx_browser_host_was_resized_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_was_resized", typeof(CfxApi.cfx_browser_host_was_resized_delegate));
            CfxApi.cfx_browser_host_was_hidden = (CfxApi.cfx_browser_host_was_hidden_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_was_hidden", typeof(CfxApi.cfx_browser_host_was_hidden_delegate));
            CfxApi.cfx_browser_host_notify_screen_info_changed = (CfxApi.cfx_browser_host_notify_screen_info_changed_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_notify_screen_info_changed", typeof(CfxApi.cfx_browser_host_notify_screen_info_changed_delegate));
            CfxApi.cfx_browser_host_invalidate = (CfxApi.cfx_browser_host_invalidate_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_invalidate", typeof(CfxApi.cfx_browser_host_invalidate_delegate));
            CfxApi.cfx_browser_host_send_key_event = (CfxApi.cfx_browser_host_send_key_event_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_send_key_event", typeof(CfxApi.cfx_browser_host_send_key_event_delegate));
            CfxApi.cfx_browser_host_send_mouse_click_event = (CfxApi.cfx_browser_host_send_mouse_click_event_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_send_mouse_click_event", typeof(CfxApi.cfx_browser_host_send_mouse_click_event_delegate));
            CfxApi.cfx_browser_host_send_mouse_move_event = (CfxApi.cfx_browser_host_send_mouse_move_event_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_send_mouse_move_event", typeof(CfxApi.cfx_browser_host_send_mouse_move_event_delegate));
            CfxApi.cfx_browser_host_send_mouse_wheel_event = (CfxApi.cfx_browser_host_send_mouse_wheel_event_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_send_mouse_wheel_event", typeof(CfxApi.cfx_browser_host_send_mouse_wheel_event_delegate));
            CfxApi.cfx_browser_host_send_focus_event = (CfxApi.cfx_browser_host_send_focus_event_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_send_focus_event", typeof(CfxApi.cfx_browser_host_send_focus_event_delegate));
            CfxApi.cfx_browser_host_send_capture_lost_event = (CfxApi.cfx_browser_host_send_capture_lost_event_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_send_capture_lost_event", typeof(CfxApi.cfx_browser_host_send_capture_lost_event_delegate));
            CfxApi.cfx_browser_host_notify_move_or_resize_started = (CfxApi.cfx_browser_host_notify_move_or_resize_started_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_notify_move_or_resize_started", typeof(CfxApi.cfx_browser_host_notify_move_or_resize_started_delegate));
            CfxApi.cfx_browser_host_get_nstext_input_context = (CfxApi.cfx_browser_host_get_nstext_input_context_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_get_nstext_input_context", typeof(CfxApi.cfx_browser_host_get_nstext_input_context_delegate));
            CfxApi.cfx_browser_host_handle_key_event_before_text_input_client = (CfxApi.cfx_browser_host_handle_key_event_before_text_input_client_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_handle_key_event_before_text_input_client", typeof(CfxApi.cfx_browser_host_handle_key_event_before_text_input_client_delegate));
            CfxApi.cfx_browser_host_handle_key_event_after_text_input_client = (CfxApi.cfx_browser_host_handle_key_event_after_text_input_client_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_handle_key_event_after_text_input_client", typeof(CfxApi.cfx_browser_host_handle_key_event_after_text_input_client_delegate));
            CfxApi.cfx_browser_host_drag_target_drag_enter = (CfxApi.cfx_browser_host_drag_target_drag_enter_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_drag_target_drag_enter", typeof(CfxApi.cfx_browser_host_drag_target_drag_enter_delegate));
            CfxApi.cfx_browser_host_drag_target_drag_over = (CfxApi.cfx_browser_host_drag_target_drag_over_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_drag_target_drag_over", typeof(CfxApi.cfx_browser_host_drag_target_drag_over_delegate));
            CfxApi.cfx_browser_host_drag_target_drag_leave = (CfxApi.cfx_browser_host_drag_target_drag_leave_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_drag_target_drag_leave", typeof(CfxApi.cfx_browser_host_drag_target_drag_leave_delegate));
            CfxApi.cfx_browser_host_drag_target_drop = (CfxApi.cfx_browser_host_drag_target_drop_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_drag_target_drop", typeof(CfxApi.cfx_browser_host_drag_target_drop_delegate));
            CfxApi.cfx_browser_host_drag_source_ended_at = (CfxApi.cfx_browser_host_drag_source_ended_at_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_drag_source_ended_at", typeof(CfxApi.cfx_browser_host_drag_source_ended_at_delegate));
            CfxApi.cfx_browser_host_drag_source_system_drag_ended = (CfxApi.cfx_browser_host_drag_source_system_drag_ended_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_browser_host_drag_source_system_drag_ended", typeof(CfxApi.cfx_browser_host_drag_source_system_drag_ended_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxBrowserHost Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxBrowserHost)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxBrowserHost(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxBrowserHost(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new browser window using the window parameters specified by
        /// |windowInfo|. All values will be copied internally and the actual window will
        /// be created on the UI thread. If |requestContext| is NULL the global request
        /// context will be used. This function can be called on any browser process
        /// thread and will not block.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public static bool CreateBrowser(CfxWindowInfo windowInfo, CfxClient client, string url, CfxBrowserSettings settings, CfxRequestContext requestContext) {
            var url_pinned = new PinnedString(url);
            var __retval = CfxApi.cfx_browser_host_create_browser(CfxWindowInfo.Unwrap(windowInfo), CfxClient.Unwrap(client), url_pinned.Obj.PinnedPtr, url_pinned.Length, CfxBrowserSettings.Unwrap(settings), CfxRequestContext.Unwrap(requestContext));
            url_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Create a new browser window using the window parameters specified by
        /// |windowInfo|. If |requestContext| is NULL the global request context will be
        /// used. This function can only be called on the browser process UI thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public static CfxBrowser CreateBrowserSync(CfxWindowInfo windowInfo, CfxClient client, string url, CfxBrowserSettings settings, CfxRequestContext requestContext) {
            var url_pinned = new PinnedString(url);
            var __retval = CfxApi.cfx_browser_host_create_browser_sync(CfxWindowInfo.Unwrap(windowInfo), CfxClient.Unwrap(client), url_pinned.Obj.PinnedPtr, url_pinned.Length, CfxBrowserSettings.Unwrap(settings), CfxRequestContext.Unwrap(requestContext));
            url_pinned.Obj.Free();
            return CfxBrowser.Wrap(__retval);
        }

        /// <summary>
        /// Returns the hosted browser object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfxBrowser Browser {
            get {
                return CfxBrowser.Wrap(CfxApi.cfx_browser_host_get_browser(NativePtr));
            }
        }

        /// <summary>
        /// Retrieve the window handle for this browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public IntPtr WindowHandle {
            get {
                return CfxApi.cfx_browser_host_get_window_handle(NativePtr);
            }
        }

        /// <summary>
        /// Retrieve the window handle of the browser that opened this browser. Will
        /// return NULL for non-popup windows. This function can be used in combination
        /// with custom handling of modal windows.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public IntPtr OpenerWindowHandle {
            get {
                return CfxApi.cfx_browser_host_get_opener_window_handle(NativePtr);
            }
        }

        /// <summary>
        /// Returns the client for this browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfxClient Client {
            get {
                return CfxClient.Wrap(CfxApi.cfx_browser_host_get_client(NativePtr));
            }
        }

        /// <summary>
        /// Returns the request context for this browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public CfxRequestContext RequestContext {
            get {
                return CfxRequestContext.Wrap(CfxApi.cfx_browser_host_get_request_context(NativePtr));
            }
        }

        /// <summary>
        /// Get the current zoom level. The default zoom level is 0.0. This function
        /// can only be called on the UI thread.
        /// 
        /// Change the zoom level to the specified value. Specify 0.0 to reset the zoom
        /// level. If called on the UI thread the change will be applied immediately.
        /// Otherwise, the change will be applied asynchronously on the UI thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public double ZoomLevel {
            get {
                return CfxApi.cfx_browser_host_get_zoom_level(NativePtr);
            }
            set {
                CfxApi.cfx_browser_host_set_zoom_level(NativePtr, value);
            }
        }

        /// <summary>
        /// Returns true (1) if mouse cursor change is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool IsMouseCursorChangeDisabled {
            get {
                return 0 != CfxApi.cfx_browser_host_is_mouse_cursor_change_disabled(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if window rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public bool IsWindowRenderingDisabled {
            get {
                return 0 != CfxApi.cfx_browser_host_is_window_rendering_disabled(NativePtr);
            }
        }

        /// <summary>
        /// Get the NSTextInputContext implementation for enabling IME on Mac when
        /// window rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public IntPtr NsTextInputContext {
            get {
                return CfxApi.cfx_browser_host_get_nstext_input_context(NativePtr);
            }
        }

        /// <summary>
        /// Request that the browser close. The JavaScript 'onbeforeunload' event will
        /// be fired. If |forceClose| is false (0) the event handler, if any, will be
        /// allowed to prompt the user and the user can optionally cancel the close. If
        /// |forceClose| is true (1) the prompt will not be displayed and the close
        /// will proceed. Results in a call to CfxLifeSpanHandler.DoClose() if
        /// the event handler allows the close or if |forceClose| is true (1). See
        /// CfxLifeSpanHandler.DoClose() documentation for additional usage
        /// information.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void CloseBrowser(bool forceClose) {
            CfxApi.cfx_browser_host_close_browser(NativePtr, forceClose ? 1 : 0);
        }

        /// <summary>
        /// Set whether the browser is focused.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SetFocus(bool focus) {
            CfxApi.cfx_browser_host_set_focus(NativePtr, focus ? 1 : 0);
        }

        /// <summary>
        /// Set whether the window containing the browser is visible
        /// (minimized/unminimized, app hidden/unhidden, etc). Only used on Mac OS X.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SetWindowVisibility(bool visible) {
            CfxApi.cfx_browser_host_set_window_visibility(NativePtr, visible ? 1 : 0);
        }

        /// <summary>
        /// Call to run a file chooser dialog. Only a single file chooser dialog may be
        /// pending at any given time. |mode| represents the type of dialog to display.
        /// |title| to the title to be used for the dialog and may be NULL to show the
        /// default title ("Open" or "Save" depending on the mode). |defaultFileName|
        /// is the default file name to select in the dialog. |acceptTypes| is a list
        /// of valid lower-cased MIME types or file extensions specified in an input
        /// element and is used to restrict selectable files to such types. |callback|
        /// will be executed after the dialog is dismissed or immediately if another
        /// dialog is already pending. The dialog will be initiated asynchronously on
        /// the UI thread.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void RunFileDialog(CfxFileDialogMode mode, string title, string defaultFileName, System.Collections.Generic.List<string> acceptTypes, CfxRunFileDialogCallback callback) {
            var title_pinned = new PinnedString(title);
            var defaultFileName_pinned = new PinnedString(defaultFileName);
            PinnedString[] acceptTypes_handles;
            var acceptTypes_unwrapped = StringFunctions.UnwrapCfxStringList(acceptTypes, out acceptTypes_handles);
            CfxApi.cfx_browser_host_run_file_dialog(NativePtr, mode, title_pinned.Obj.PinnedPtr, title_pinned.Length, defaultFileName_pinned.Obj.PinnedPtr, defaultFileName_pinned.Length, acceptTypes_unwrapped, CfxRunFileDialogCallback.Unwrap(callback));
            title_pinned.Obj.Free();
            defaultFileName_pinned.Obj.Free();
            StringFunctions.FreePinnedStrings(acceptTypes_handles);
            StringFunctions.CfxStringListCopyToManaged(acceptTypes_unwrapped, acceptTypes);
            CfxApi.cfx_string_list_free(acceptTypes_unwrapped);
        }

        /// <summary>
        /// Download the file at |url| using CfxDownloadHandler.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void StartDownload(string url) {
            var url_pinned = new PinnedString(url);
            CfxApi.cfx_browser_host_start_download(NativePtr, url_pinned.Obj.PinnedPtr, url_pinned.Length);
            url_pinned.Obj.Free();
        }

        /// <summary>
        /// Print the current browser contents.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void Print() {
            CfxApi.cfx_browser_host_print(NativePtr);
        }

        /// <summary>
        /// Search for |searchText|. |identifier| can be used to have multiple searches
        /// running simultaniously. |forward| indicates whether to search forward or
        /// backward within the page. |matchCase| indicates whether the search should
        /// be case-sensitive. |findNext| indicates whether this is the first request
        /// or a follow-up.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void Find(int identifier, string searchText, bool forward, bool matchCase, bool findNext) {
            var searchText_pinned = new PinnedString(searchText);
            CfxApi.cfx_browser_host_find(NativePtr, identifier, searchText_pinned.Obj.PinnedPtr, searchText_pinned.Length, forward ? 1 : 0, matchCase ? 1 : 0, findNext ? 1 : 0);
            searchText_pinned.Obj.Free();
        }

        /// <summary>
        /// Cancel all searches that are currently going on.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void StopFinding(int clearSelection) {
            CfxApi.cfx_browser_host_stop_finding(NativePtr, clearSelection);
        }

        /// <summary>
        /// Open developer tools in its own window. If |inspectElementAt| is non-
        /// NULL the element at the specified (x,y) location will be inspected.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void ShowDevTools(CfxWindowInfo windowInfo, CfxClient client, CfxBrowserSettings settings, CfxPoint inspectElementAt) {
            CfxApi.cfx_browser_host_show_dev_tools(NativePtr, CfxWindowInfo.Unwrap(windowInfo), CfxClient.Unwrap(client), CfxBrowserSettings.Unwrap(settings), CfxPoint.Unwrap(inspectElementAt));
        }

        /// <summary>
        /// Explicitly close the developer tools window if one exists for this browser
        /// instance.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void CloseDevTools() {
            CfxApi.cfx_browser_host_close_dev_tools(NativePtr);
        }

        /// <summary>
        /// Retrieve a snapshot of current navigation entries as values sent to the
        /// specified visitor. If |currentOnly| is true (1) only the current
        /// navigation entry will be sent, otherwise all navigation entries will be
        /// sent.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void GetNavigationEntries(CfxNavigationEntryVisitor visitor, bool currentOnly) {
            CfxApi.cfx_browser_host_get_navigation_entries(NativePtr, CfxNavigationEntryVisitor.Unwrap(visitor), currentOnly ? 1 : 0);
        }

        /// <summary>
        /// Set whether mouse cursor change is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SetMouseCursorChangeDisabled(int disabled) {
            CfxApi.cfx_browser_host_set_mouse_cursor_change_disabled(NativePtr, disabled);
        }

        /// <summary>
        /// If a misspelled word is currently selected in an editable node calling this
        /// function will replace it with the specified |word|.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void ReplaceMisspelling(string word) {
            var word_pinned = new PinnedString(word);
            CfxApi.cfx_browser_host_replace_misspelling(NativePtr, word_pinned.Obj.PinnedPtr, word_pinned.Length);
            word_pinned.Obj.Free();
        }

        /// <summary>
        /// Add the specified |word| to the spelling dictionary.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void AddWordToDictionary(string word) {
            var word_pinned = new PinnedString(word);
            CfxApi.cfx_browser_host_add_word_to_dictionary(NativePtr, word_pinned.Obj.PinnedPtr, word_pinned.Length);
            word_pinned.Obj.Free();
        }

        /// <summary>
        /// Notify the browser that the widget has been resized. The browser will first
        /// call CfxRenderHandler.GetViewRect to get the new size and then call
        /// CfxRenderHandler.OnPaint asynchronously with the updated regions. This
        /// function is only used when window rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void WasResized() {
            CfxApi.cfx_browser_host_was_resized(NativePtr);
        }

        /// <summary>
        /// Notify the browser that it has been hidden or shown. Layouting and
        /// CfxRenderHandler.OnPaint notification will stop when the browser is
        /// hidden. This function is only used when window rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void WasHidden(bool hidden) {
            CfxApi.cfx_browser_host_was_hidden(NativePtr, hidden ? 1 : 0);
        }

        /// <summary>
        /// Send a notification to the browser that the screen info has changed. The
        /// browser will then call CfxRenderHandler.GetScreenInfo to update the
        /// screen information with the new values. This simulates moving the webview
        /// window from one display to another, or changing the properties of the
        /// current display. This function is only used when window rendering is
        /// disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void NotifyScreenInfoChanged() {
            CfxApi.cfx_browser_host_notify_screen_info_changed(NativePtr);
        }

        /// <summary>
        /// Invalidate the view. The browser will call CfxRenderHandler.OnPaint
        /// asynchronously. This function is only used when window rendering is
        /// disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void Invalidate(CfxPaintElementType type) {
            CfxApi.cfx_browser_host_invalidate(NativePtr, type);
        }

        /// <summary>
        /// Send a key event to the browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SendKeyEvent(CfxKeyEvent @event) {
            CfxApi.cfx_browser_host_send_key_event(NativePtr, CfxKeyEvent.Unwrap(@event));
        }

        /// <summary>
        /// Send a mouse click event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SendMouseClickEvent(CfxMouseEvent @event, CfxMouseButtonType type, bool mouseUp, int clickCount) {
            CfxApi.cfx_browser_host_send_mouse_click_event(NativePtr, CfxMouseEvent.Unwrap(@event), type, mouseUp ? 1 : 0, clickCount);
        }

        /// <summary>
        /// Send a mouse move event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SendMouseMoveEvent(CfxMouseEvent @event, bool mouseLeave) {
            CfxApi.cfx_browser_host_send_mouse_move_event(NativePtr, CfxMouseEvent.Unwrap(@event), mouseLeave ? 1 : 0);
        }

        /// <summary>
        /// Send a mouse wheel event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view. The |deltaX| and |deltaY|
        /// values represent the movement delta in the X and Y directions respectively.
        /// In order to scroll inside select popups with window rendering disabled
        /// CfxRenderHandler.GetScreenPoint should be implemented properly.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SendMouseWheelEvent(CfxMouseEvent @event, int deltaX, int deltaY) {
            CfxApi.cfx_browser_host_send_mouse_wheel_event(NativePtr, CfxMouseEvent.Unwrap(@event), deltaX, deltaY);
        }

        /// <summary>
        /// Send a focus event to the browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SendFocusEvent(bool setFocus) {
            CfxApi.cfx_browser_host_send_focus_event(NativePtr, setFocus ? 1 : 0);
        }

        /// <summary>
        /// Send a capture lost event to the browser.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void SendCaptureLostEvent() {
            CfxApi.cfx_browser_host_send_capture_lost_event(NativePtr);
        }

        /// <summary>
        /// Notify the browser that the window hosting it is about to be moved or
        /// resized. This function is only used on Windows and Linux.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void NotifyMoveOrResizeStarted() {
            CfxApi.cfx_browser_host_notify_move_or_resize_started(NativePtr);
        }

        /// <summary>
        /// Handles a keyDown event prior to passing it through the NSTextInputClient
        /// machinery.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void HandleKeyEventBeforeTextInputClient(IntPtr keyEvent) {
            CfxApi.cfx_browser_host_handle_key_event_before_text_input_client(NativePtr, keyEvent);
        }

        /// <summary>
        /// Performs any additional actions after NSTextInputClient handles the event.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void HandleKeyEventAfterTextInputClient(IntPtr keyEvent) {
            CfxApi.cfx_browser_host_handle_key_event_after_text_input_client(NativePtr, keyEvent);
        }

        /// <summary>
        /// Call this function when the user drags the mouse into the web view (before
        /// calling DragTargetDragOver/DragTargetLeave/DragTargetDrop). |dragData|
        /// should not contain file contents as this type of data is not allowed to be
        /// dragged into the web view. File contents can be removed using
        /// CfxDragData.ResetFileContents (for example, if |dragData| comes from
        /// CfxRenderHandler.StartDragging). This function is only used when
        /// window rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void DragTargetDragEnter(CfxDragData dragData, CfxMouseEvent @event, CfxDragOperationsMask allowedOps) {
            CfxApi.cfx_browser_host_drag_target_drag_enter(NativePtr, CfxDragData.Unwrap(dragData), CfxMouseEvent.Unwrap(@event), allowedOps);
        }

        /// <summary>
        /// Call this function each time the mouse is moved across the web view during
        /// a drag operation (after calling DragTargetDragEnter and before calling
        /// DragTargetDragLeave/DragTargetDrop). This function is only used when window
        /// rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void DragTargetDragOver(CfxMouseEvent @event, CfxDragOperationsMask allowedOps) {
            CfxApi.cfx_browser_host_drag_target_drag_over(NativePtr, CfxMouseEvent.Unwrap(@event), allowedOps);
        }

        /// <summary>
        /// Call this function when the user drags the mouse out of the web view (after
        /// calling DragTargetDragEnter). This function is only used when window
        /// rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void DragTargetDragLeave() {
            CfxApi.cfx_browser_host_drag_target_drag_leave(NativePtr);
        }

        /// <summary>
        /// Call this function when the user completes the drag operation by dropping
        /// the object onto the web view (after calling DragTargetDragEnter). The
        /// object being dropped is |dragData|, given as an argument to the previous
        /// DragTargetDragEnter call. This function is only used when window rendering
        /// is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void DragTargetDrop(CfxMouseEvent @event) {
            CfxApi.cfx_browser_host_drag_target_drop(NativePtr, CfxMouseEvent.Unwrap(@event));
        }

        /// <summary>
        /// Call this function when the drag operation started by a
        /// CfxRenderHandler.StartDragging call has ended either in a drop or by
        /// being cancelled. |x| and |y| are mouse coordinates relative to the upper-
        /// left corner of the view. If the web view is both the drag source and the
        /// drag target then all DragTarget* functions should be called before
        /// DragSource* mthods. This function is only used when window rendering is
        /// disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void DragSourceEndedAt(int x, int y, CfxDragOperationsMask op) {
            CfxApi.cfx_browser_host_drag_source_ended_at(NativePtr, x, y, op);
        }

        /// <summary>
        /// Call this function when the drag operation started by a
        /// CfxRenderHandler.StartDragging call has completed. This function may
        /// be called immediately without first calling DragSourceEndedAt to cancel a
        /// drag operation. If the web view is both the drag source and the drag target
        /// then all DragTarget* functions should be called before DragSource* mthods.
        /// This function is only used when window rendering is disabled.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_browser_capi.h">cef/include/capi/cef_browser_capi.h</see>.
        /// </remarks>
        public void DragSourceSystemDragEnded() {
            CfxApi.cfx_browser_host_drag_source_system_drag_ended(NativePtr);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}