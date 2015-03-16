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
    /// Structure representing window information.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types_win.h">cef/include/internal/cef_types_win.h</see>.
    /// </remarks>
    public sealed class CfxWindowInfo : CfxStructure {

        static CfxWindowInfo () {
            CfxApi.cfx_window_info_ctor = (CfxApi.cfx_ctor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_ctor", typeof(CfxApi.cfx_ctor_delegate));
            CfxApi.cfx_window_info_dtor = (CfxApi.cfx_dtor_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_dtor", typeof(CfxApi.cfx_dtor_delegate));
            CfxApi.cfx_window_info_set_ex_style = (CfxApi.cfx_window_info_set_ex_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_ex_style", typeof(CfxApi.cfx_window_info_set_ex_style_delegate));
            CfxApi.cfx_window_info_get_ex_style = (CfxApi.cfx_window_info_get_ex_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_ex_style", typeof(CfxApi.cfx_window_info_get_ex_style_delegate));
            CfxApi.cfx_window_info_set_window_name = (CfxApi.cfx_window_info_set_window_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_window_name", typeof(CfxApi.cfx_window_info_set_window_name_delegate));
            CfxApi.cfx_window_info_get_window_name = (CfxApi.cfx_window_info_get_window_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_window_name", typeof(CfxApi.cfx_window_info_get_window_name_delegate));
            CfxApi.cfx_window_info_set_style = (CfxApi.cfx_window_info_set_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_style", typeof(CfxApi.cfx_window_info_set_style_delegate));
            CfxApi.cfx_window_info_get_style = (CfxApi.cfx_window_info_get_style_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_style", typeof(CfxApi.cfx_window_info_get_style_delegate));
            CfxApi.cfx_window_info_set_x = (CfxApi.cfx_window_info_set_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_x", typeof(CfxApi.cfx_window_info_set_x_delegate));
            CfxApi.cfx_window_info_get_x = (CfxApi.cfx_window_info_get_x_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_x", typeof(CfxApi.cfx_window_info_get_x_delegate));
            CfxApi.cfx_window_info_set_y = (CfxApi.cfx_window_info_set_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_y", typeof(CfxApi.cfx_window_info_set_y_delegate));
            CfxApi.cfx_window_info_get_y = (CfxApi.cfx_window_info_get_y_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_y", typeof(CfxApi.cfx_window_info_get_y_delegate));
            CfxApi.cfx_window_info_set_width = (CfxApi.cfx_window_info_set_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_width", typeof(CfxApi.cfx_window_info_set_width_delegate));
            CfxApi.cfx_window_info_get_width = (CfxApi.cfx_window_info_get_width_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_width", typeof(CfxApi.cfx_window_info_get_width_delegate));
            CfxApi.cfx_window_info_set_height = (CfxApi.cfx_window_info_set_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_height", typeof(CfxApi.cfx_window_info_set_height_delegate));
            CfxApi.cfx_window_info_get_height = (CfxApi.cfx_window_info_get_height_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_height", typeof(CfxApi.cfx_window_info_get_height_delegate));
            CfxApi.cfx_window_info_set_parent_window = (CfxApi.cfx_window_info_set_parent_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_parent_window", typeof(CfxApi.cfx_window_info_set_parent_window_delegate));
            CfxApi.cfx_window_info_get_parent_window = (CfxApi.cfx_window_info_get_parent_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_parent_window", typeof(CfxApi.cfx_window_info_get_parent_window_delegate));
            CfxApi.cfx_window_info_set_menu = (CfxApi.cfx_window_info_set_menu_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_menu", typeof(CfxApi.cfx_window_info_set_menu_delegate));
            CfxApi.cfx_window_info_get_menu = (CfxApi.cfx_window_info_get_menu_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_menu", typeof(CfxApi.cfx_window_info_get_menu_delegate));
            CfxApi.cfx_window_info_set_windowless_rendering_enabled = (CfxApi.cfx_window_info_set_windowless_rendering_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_windowless_rendering_enabled", typeof(CfxApi.cfx_window_info_set_windowless_rendering_enabled_delegate));
            CfxApi.cfx_window_info_get_windowless_rendering_enabled = (CfxApi.cfx_window_info_get_windowless_rendering_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_windowless_rendering_enabled", typeof(CfxApi.cfx_window_info_get_windowless_rendering_enabled_delegate));
            CfxApi.cfx_window_info_set_transparent_painting_enabled = (CfxApi.cfx_window_info_set_transparent_painting_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_transparent_painting_enabled", typeof(CfxApi.cfx_window_info_set_transparent_painting_enabled_delegate));
            CfxApi.cfx_window_info_get_transparent_painting_enabled = (CfxApi.cfx_window_info_get_transparent_painting_enabled_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_transparent_painting_enabled", typeof(CfxApi.cfx_window_info_get_transparent_painting_enabled_delegate));
            CfxApi.cfx_window_info_set_window = (CfxApi.cfx_window_info_set_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_set_window", typeof(CfxApi.cfx_window_info_set_window_delegate));
            CfxApi.cfx_window_info_get_window = (CfxApi.cfx_window_info_get_window_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_window_info_get_window", typeof(CfxApi.cfx_window_info_get_window_delegate));
        }

        internal static CfxWindowInfo Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxWindowInfo(nativePtr);
        }

        internal static CfxWindowInfo WrapOwned(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxWindowInfo(nativePtr, CfxApi.cfx_window_info_dtor);
        }

        public CfxWindowInfo() : base(CfxApi.cfx_window_info_ctor, CfxApi.cfx_window_info_dtor) {}
        internal CfxWindowInfo(IntPtr nativePtr) : base(nativePtr) {}
        internal CfxWindowInfo(IntPtr nativePtr, CfxApi.cfx_dtor_delegate cfx_dtor) : base(nativePtr, cfx_dtor) {}

        /// <summary>
        /// Standard parameters required by CreateWindowEx()
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types_win.h">cef/include/internal/cef_types_win.h</see>.
        /// </remarks>
        public int ExStyle {
            get {
                int value;
                CfxApi.cfx_window_info_get_ex_style(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_ex_style(nativePtrUnchecked, value);
            }
        }

        public string WindowName {
            get {
                IntPtr value_str;
                int value_length;
                CfxApi.cfx_window_info_get_window_name(nativePtrUnchecked, out value_str, out value_length);
                return StringFunctions.PtrToStringUni(value_str, value_length);
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_window_info_set_window_name(nativePtrUnchecked, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        public int Style {
            get {
                int value;
                CfxApi.cfx_window_info_get_style(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_style(nativePtrUnchecked, value);
            }
        }

        public int X {
            get {
                int value;
                CfxApi.cfx_window_info_get_x(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_x(nativePtrUnchecked, value);
            }
        }

        public int Y {
            get {
                int value;
                CfxApi.cfx_window_info_get_y(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_y(nativePtrUnchecked, value);
            }
        }

        public int Width {
            get {
                int value;
                CfxApi.cfx_window_info_get_width(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_width(nativePtrUnchecked, value);
            }
        }

        public int Height {
            get {
                int value;
                CfxApi.cfx_window_info_get_height(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_height(nativePtrUnchecked, value);
            }
        }

        public IntPtr ParentWindow {
            get {
                IntPtr value;
                CfxApi.cfx_window_info_get_parent_window(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_parent_window(nativePtrUnchecked, value);
            }
        }

        public IntPtr Menu {
            get {
                IntPtr value;
                CfxApi.cfx_window_info_get_menu(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_menu(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Set to true (1) to create the browser using windowless (off-screen)
        /// rendering. No window will be created for the browser and all rendering will
        /// occur via the CfxRenderHandler interface. The |parentWindow| value will be
        /// used to identify monitor info and to act as the parent window for dialogs,
        /// context menus, etc. If |parentWindow| is not provided then the main screen
        /// monitor will be used and some functionality that requires a parent window
        /// may not function correctly. In order to create windowless browsers the
        /// CfxSettings.WindowlessRenderingEnabled value must be set to true.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types_win.h">cef/include/internal/cef_types_win.h</see>.
        /// </remarks>
        public bool WindowlessRenderingEnabled {
            get {
                int value;
                CfxApi.cfx_window_info_get_windowless_rendering_enabled(nativePtrUnchecked, out value);
                return 0 != value;
            }
            set {
                CfxApi.cfx_window_info_set_windowless_rendering_enabled(nativePtrUnchecked, value ? 1 : 0);
            }
        }

        /// <summary>
        /// Set to true (1) to enable transparent painting in combination with
        /// windowless rendering. When this value is true a transparent background
        /// color will be used (RGBA=0x00000000). When this value is false the
        /// background will be white and opaque.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types_win.h">cef/include/internal/cef_types_win.h</see>.
        /// </remarks>
        public bool TransparentPaintingEnabled {
            get {
                int value;
                CfxApi.cfx_window_info_get_transparent_painting_enabled(nativePtrUnchecked, out value);
                return 0 != value;
            }
            set {
                CfxApi.cfx_window_info_set_transparent_painting_enabled(nativePtrUnchecked, value ? 1 : 0);
            }
        }

        /// <summary>
        /// Handle for the new browser window. Only used with windowed rendering.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/internal/cef_types_win.h">cef/include/internal/cef_types_win.h</see>.
        /// </remarks>
        public IntPtr Window {
            get {
                IntPtr value;
                CfxApi.cfx_window_info_get_window(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_window_info_set_window(nativePtrUnchecked, value);
            }
        }

    }
}