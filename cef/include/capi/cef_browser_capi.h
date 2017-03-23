// Copyright (c) 2017 Marshall A. Greenblatt. All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//    * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//    * Neither the name of Google Inc. nor the name Chromium Embedded
// Framework nor the names of its contributors may be used to endorse
// or promote products derived from this software without specific prior
// written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// ---------------------------------------------------------------------------
//
// This file was generated by the CEF translator tool and should not edited
// by hand. See the translator.README.txt file in the tools directory for
// more information.
//

#ifndef CEF_INCLUDE_CAPI_CEF_BROWSER_CAPI_H_
#define CEF_INCLUDE_CAPI_CEF_BROWSER_CAPI_H_
#pragma once

#include "include/capi/cef_base_capi.h"
#include "include/capi/cef_drag_data_capi.h"
#include "include/capi/cef_frame_capi.h"
#include "include/capi/cef_image_capi.h"
#include "include/capi/cef_navigation_entry_capi.h"
#include "include/capi/cef_process_message_capi.h"
#include "include/capi/cef_request_context_capi.h"

#ifdef __cplusplus
extern "C" {
#endif

struct _cef_browser_host_t;
struct _cef_client_t;

///
// Structure used to represent a browser window. When used in the browser
// process the functions of this structure may be called on any thread unless
// otherwise indicated in the comments. When used in the render process the
// functions of this structure may only be called on the main thread.
///
typedef struct _cef_browser_t {
  ///
  // Base structure.
  ///
  cef_base_ref_counted_t base;

  ///
  // Returns the browser host object. This function can only be called in the
  // browser process.
  ///
  struct _cef_browser_host_t* (CEF_CALLBACK *get_host)(
      struct _cef_browser_t* self);

  ///
  // Returns true (1) if the browser can navigate backwards.
  ///
  int (CEF_CALLBACK *can_go_back)(struct _cef_browser_t* self);

  ///
  // Navigate backwards.
  ///
  void (CEF_CALLBACK *go_back)(struct _cef_browser_t* self);

  ///
  // Returns true (1) if the browser can navigate forwards.
  ///
  int (CEF_CALLBACK *can_go_forward)(struct _cef_browser_t* self);

  ///
  // Navigate forwards.
  ///
  void (CEF_CALLBACK *go_forward)(struct _cef_browser_t* self);

  ///
  // Returns true (1) if the browser is currently loading.
  ///
  int (CEF_CALLBACK *is_loading)(struct _cef_browser_t* self);

  ///
  // Reload the current page.
  ///
  void (CEF_CALLBACK *reload)(struct _cef_browser_t* self);

  ///
  // Reload the current page ignoring any cached data.
  ///
  void (CEF_CALLBACK *reload_ignore_cache)(struct _cef_browser_t* self);

  ///
  // Stop loading the page.
  ///
  void (CEF_CALLBACK *stop_load)(struct _cef_browser_t* self);

  ///
  // Returns the globally unique identifier for this browser.
  ///
  int (CEF_CALLBACK *get_identifier)(struct _cef_browser_t* self);

  ///
  // Returns true (1) if this object is pointing to the same handle as |that|
  // object.
  ///
  int (CEF_CALLBACK *is_same)(struct _cef_browser_t* self,
      struct _cef_browser_t* that);

  ///
  // Returns true (1) if the window is a popup window.
  ///
  int (CEF_CALLBACK *is_popup)(struct _cef_browser_t* self);

  ///
  // Returns true (1) if a document has been loaded in the browser.
  ///
  int (CEF_CALLBACK *has_document)(struct _cef_browser_t* self);

  ///
  // Returns the main (top-level) frame for the browser window.
  ///
  struct _cef_frame_t* (CEF_CALLBACK *get_main_frame)(
      struct _cef_browser_t* self);

  ///
  // Returns the focused frame for the browser window.
  ///
  struct _cef_frame_t* (CEF_CALLBACK *get_focused_frame)(
      struct _cef_browser_t* self);

  ///
  // Returns the frame with the specified identifier, or NULL if not found.
  ///
  struct _cef_frame_t* (CEF_CALLBACK *get_frame_byident)(
      struct _cef_browser_t* self, int64 identifier);

  ///
  // Returns the frame with the specified name, or NULL if not found.
  ///
  struct _cef_frame_t* (CEF_CALLBACK *get_frame)(struct _cef_browser_t* self,
      const cef_string_t* name);

  ///
  // Returns the number of frames that currently exist.
  ///
  size_t (CEF_CALLBACK *get_frame_count)(struct _cef_browser_t* self);

  ///
  // Returns the identifiers of all existing frames.
  ///
  void (CEF_CALLBACK *get_frame_identifiers)(struct _cef_browser_t* self,
      size_t* identifiersCount, int64* identifiers);

  ///
  // Returns the names of all existing frames.
  ///
  void (CEF_CALLBACK *get_frame_names)(struct _cef_browser_t* self,
      cef_string_list_t names);

  ///
  // Send a message to the specified |target_process|. Returns true (1) if the
  // message was sent successfully.
  ///
  int (CEF_CALLBACK *send_process_message)(struct _cef_browser_t* self,
      cef_process_id_t target_process,
      struct _cef_process_message_t* message);
} cef_browser_t;


///
// Callback structure for cef_browser_host_t::RunFileDialog. The functions of
// this structure will be called on the browser process UI thread.
///
typedef struct _cef_run_file_dialog_callback_t {
  ///
  // Base structure.
  ///
  cef_base_ref_counted_t base;

  ///
  // Called asynchronously after the file dialog is dismissed.
  // |selected_accept_filter| is the 0-based index of the value selected from
  // the accept filters array passed to cef_browser_host_t::RunFileDialog.
  // |file_paths| will be a single value or a list of values depending on the
  // dialog mode. If the selection was cancelled |file_paths| will be NULL.
  ///
  void (CEF_CALLBACK *on_file_dialog_dismissed)(
      struct _cef_run_file_dialog_callback_t* self, int selected_accept_filter,
      cef_string_list_t file_paths);
} cef_run_file_dialog_callback_t;


///
// Callback structure for cef_browser_host_t::GetNavigationEntries. The
// functions of this structure will be called on the browser process UI thread.
///
typedef struct _cef_navigation_entry_visitor_t {
  ///
  // Base structure.
  ///
  cef_base_ref_counted_t base;

  ///
  // Method that will be executed. Do not keep a reference to |entry| outside of
  // this callback. Return true (1) to continue visiting entries or false (0) to
  // stop. |current| is true (1) if this entry is the currently loaded
  // navigation entry. |index| is the 0-based index of this entry and |total| is
  // the total number of entries.
  ///
  int (CEF_CALLBACK *visit)(struct _cef_navigation_entry_visitor_t* self,
      struct _cef_navigation_entry_t* entry, int current, int index,
      int total);
} cef_navigation_entry_visitor_t;


///
// Callback structure for cef_browser_host_t::PrintToPDF. The functions of this
// structure will be called on the browser process UI thread.
///
typedef struct _cef_pdf_print_callback_t {
  ///
  // Base structure.
  ///
  cef_base_ref_counted_t base;

  ///
  // Method that will be executed when the PDF printing has completed. |path| is
  // the output path. |ok| will be true (1) if the printing completed
  // successfully or false (0) otherwise.
  ///
  void (CEF_CALLBACK *on_pdf_print_finished)(
      struct _cef_pdf_print_callback_t* self, const cef_string_t* path,
      int ok);
} cef_pdf_print_callback_t;


///
// Callback structure for cef_browser_host_t::DownloadImage. The functions of
// this structure will be called on the browser process UI thread.
///
typedef struct _cef_download_image_callback_t {
  ///
  // Base structure.
  ///
  cef_base_ref_counted_t base;

  ///
  // Method that will be executed when the image download has completed.
  // |image_url| is the URL that was downloaded and |http_status_code| is the
  // resulting HTTP status code. |image| is the resulting image, possibly at
  // multiple scale factors, or NULL if the download failed.
  ///
  void (CEF_CALLBACK *on_download_image_finished)(
      struct _cef_download_image_callback_t* self,
      const cef_string_t* image_url, int http_status_code,
      struct _cef_image_t* image);
} cef_download_image_callback_t;


///
// Structure used to represent the browser process aspects of a browser window.
// The functions of this structure can only be called in the browser process.
// They may be called on any thread in that process unless otherwise indicated
// in the comments.
///
typedef struct _cef_browser_host_t {
  ///
  // Base structure.
  ///
  cef_base_ref_counted_t base;

  ///
  // Returns the hosted browser object.
  ///
  struct _cef_browser_t* (CEF_CALLBACK *get_browser)(
      struct _cef_browser_host_t* self);

  ///
  // Request that the browser close. The JavaScript 'onbeforeunload' event will
  // be fired. If |force_close| is false (0) the event handler, if any, will be
  // allowed to prompt the user and the user can optionally cancel the close. If
  // |force_close| is true (1) the prompt will not be displayed and the close
  // will proceed. Results in a call to cef_life_span_handler_t::do_close() if
  // the event handler allows the close or if |force_close| is true (1). See
  // cef_life_span_handler_t::do_close() documentation for additional usage
  // information.
  ///
  void (CEF_CALLBACK *close_browser)(struct _cef_browser_host_t* self,
      int force_close);

  ///
  // Helper for closing a browser. Call this function from the top-level window
  // close handler. Internally this calls CloseBrowser(false (0)) if the close
  // has not yet been initiated. This function returns false (0) while the close
  // is pending and true (1) after the close has completed. See close_browser()
  // and cef_life_span_handler_t::do_close() documentation for additional usage
  // information. This function must be called on the browser process UI thread.
  ///
  int (CEF_CALLBACK *try_close_browser)(struct _cef_browser_host_t* self);

  ///
  // Set whether the browser is focused.
  ///
  void (CEF_CALLBACK *set_focus)(struct _cef_browser_host_t* self, int focus);

  ///
  // Retrieve the window handle for this browser. If this browser is wrapped in
  // a cef_browser_view_t this function should be called on the browser process
  // UI thread and it will return the handle for the top-level native window.
  ///
  cef_window_handle_t (CEF_CALLBACK *get_window_handle)(
      struct _cef_browser_host_t* self);

  ///
  // Retrieve the window handle of the browser that opened this browser. Will
  // return NULL for non-popup windows or if this browser is wrapped in a
  // cef_browser_view_t. This function can be used in combination with custom
  // handling of modal windows.
  ///
  cef_window_handle_t (CEF_CALLBACK *get_opener_window_handle)(
      struct _cef_browser_host_t* self);

  ///
  // Returns true (1) if this browser is wrapped in a cef_browser_view_t.
  ///
  int (CEF_CALLBACK *has_view)(struct _cef_browser_host_t* self);

  ///
  // Returns the client for this browser.
  ///
  struct _cef_client_t* (CEF_CALLBACK *get_client)(
      struct _cef_browser_host_t* self);

  ///
  // Returns the request context for this browser.
  ///
  struct _cef_request_context_t* (CEF_CALLBACK *get_request_context)(
      struct _cef_browser_host_t* self);

  ///
  // Get the current zoom level. The default zoom level is 0.0. This function
  // can only be called on the UI thread.
  ///
  double (CEF_CALLBACK *get_zoom_level)(struct _cef_browser_host_t* self);

  ///
  // Change the zoom level to the specified value. Specify 0.0 to reset the zoom
  // level. If called on the UI thread the change will be applied immediately.
  // Otherwise, the change will be applied asynchronously on the UI thread.
  ///
  void (CEF_CALLBACK *set_zoom_level)(struct _cef_browser_host_t* self,
      double zoomLevel);

  ///
  // Call to run a file chooser dialog. Only a single file chooser dialog may be
  // pending at any given time. |mode| represents the type of dialog to display.
  // |title| to the title to be used for the dialog and may be NULL to show the
  // default title ("Open" or "Save" depending on the mode). |default_file_path|
  // is the path with optional directory and/or file name component that will be
  // initially selected in the dialog. |accept_filters| are used to restrict the
  // selectable file types and may any combination of (a) valid lower-cased MIME
  // types (e.g. "text/*" or "image/*"), (b) individual file extensions (e.g.
  // ".txt" or ".png"), or (c) combined description and file extension delimited
  // using "|" and ";" (e.g. "Image Types|.png;.gif;.jpg").
  // |selected_accept_filter| is the 0-based index of the filter that will be
  // selected by default. |callback| will be executed after the dialog is
  // dismissed or immediately if another dialog is already pending. The dialog
  // will be initiated asynchronously on the UI thread.
  ///
  void (CEF_CALLBACK *run_file_dialog)(struct _cef_browser_host_t* self,
      cef_file_dialog_mode_t mode, const cef_string_t* title,
      const cef_string_t* default_file_path, cef_string_list_t accept_filters,
      int selected_accept_filter,
      struct _cef_run_file_dialog_callback_t* callback);

  ///
  // Download the file at |url| using cef_download_handler_t.
  ///
  void (CEF_CALLBACK *start_download)(struct _cef_browser_host_t* self,
      const cef_string_t* url);

  ///
  // Download |image_url| and execute |callback| on completion with the images
  // received from the renderer. If |is_favicon| is true (1) then cookies are
  // not sent and not accepted during download. Images with density independent
  // pixel (DIP) sizes larger than |max_image_size| are filtered out from the
  // image results. Versions of the image at different scale factors may be
  // downloaded up to the maximum scale factor supported by the system. If there
  // are no image results <= |max_image_size| then the smallest image is resized
  // to |max_image_size| and is the only result. A |max_image_size| of 0 means
  // unlimited. If |bypass_cache| is true (1) then |image_url| is requested from
  // the server even if it is present in the browser cache.
  ///
  void (CEF_CALLBACK *download_image)(struct _cef_browser_host_t* self,
      const cef_string_t* image_url, int is_favicon, uint32 max_image_size,
      int bypass_cache, struct _cef_download_image_callback_t* callback);

  ///
  // Print the current browser contents.
  ///
  void (CEF_CALLBACK *print)(struct _cef_browser_host_t* self);

  ///
  // Print the current browser contents to the PDF file specified by |path| and
  // execute |callback| on completion. The caller is responsible for deleting
  // |path| when done. For PDF printing to work on Linux you must implement the
  // cef_print_handler_t::GetPdfPaperSize function.
  ///
  void (CEF_CALLBACK *print_to_pdf)(struct _cef_browser_host_t* self,
      const cef_string_t* path,
      const struct _cef_pdf_print_settings_t* settings,
      struct _cef_pdf_print_callback_t* callback);

  ///
  // Search for |searchText|. |identifier| can be used to have multiple searches
  // running simultaniously. |forward| indicates whether to search forward or
  // backward within the page. |matchCase| indicates whether the search should
  // be case-sensitive. |findNext| indicates whether this is the first request
  // or a follow-up. The cef_find_handler_t instance, if any, returned via
  // cef_client_t::GetFindHandler will be called to report find results.
  ///
  void (CEF_CALLBACK *find)(struct _cef_browser_host_t* self, int identifier,
      const cef_string_t* searchText, int forward, int matchCase,
      int findNext);

  ///
  // Cancel all searches that are currently going on.
  ///
  void (CEF_CALLBACK *stop_finding)(struct _cef_browser_host_t* self,
      int clearSelection);

  ///
  // Open developer tools (DevTools) in its own browser. The DevTools browser
  // will remain associated with this browser. If the DevTools browser is
  // already open then it will be focused, in which case the |windowInfo|,
  // |client| and |settings| parameters will be ignored. If |inspect_element_at|
  // is non-NULL then the element at the specified (x,y) location will be
  // inspected. The |windowInfo| parameter will be ignored if this browser is
  // wrapped in a cef_browser_view_t.
  ///
  void (CEF_CALLBACK *show_dev_tools)(struct _cef_browser_host_t* self,
      const struct _cef_window_info_t* windowInfo,
      struct _cef_client_t* client,
      const struct _cef_browser_settings_t* settings,
      const cef_point_t* inspect_element_at);

  ///
  // Explicitly close the associated DevTools browser, if any.
  ///
  void (CEF_CALLBACK *close_dev_tools)(struct _cef_browser_host_t* self);

  ///
  // Returns true (1) if this browser currently has an associated DevTools
  // browser. Must be called on the browser process UI thread.
  ///
  int (CEF_CALLBACK *has_dev_tools)(struct _cef_browser_host_t* self);

  ///
  // Retrieve a snapshot of current navigation entries as values sent to the
  // specified visitor. If |current_only| is true (1) only the current
  // navigation entry will be sent, otherwise all navigation entries will be
  // sent.
  ///
  void (CEF_CALLBACK *get_navigation_entries)(struct _cef_browser_host_t* self,
      struct _cef_navigation_entry_visitor_t* visitor, int current_only);

  ///
  // Set whether mouse cursor change is disabled.
  ///
  void (CEF_CALLBACK *set_mouse_cursor_change_disabled)(
      struct _cef_browser_host_t* self, int disabled);

  ///
  // Returns true (1) if mouse cursor change is disabled.
  ///
  int (CEF_CALLBACK *is_mouse_cursor_change_disabled)(
      struct _cef_browser_host_t* self);

  ///
  // If a misspelled word is currently selected in an editable node calling this
  // function will replace it with the specified |word|.
  ///
  void (CEF_CALLBACK *replace_misspelling)(struct _cef_browser_host_t* self,
      const cef_string_t* word);

  ///
  // Add the specified |word| to the spelling dictionary.
  ///
  void (CEF_CALLBACK *add_word_to_dictionary)(struct _cef_browser_host_t* self,
      const cef_string_t* word);

  ///
  // Returns true (1) if window rendering is disabled.
  ///
  int (CEF_CALLBACK *is_window_rendering_disabled)(
      struct _cef_browser_host_t* self);

  ///
  // Notify the browser that the widget has been resized. The browser will first
  // call cef_render_handler_t::GetViewRect to get the new size and then call
  // cef_render_handler_t::OnPaint asynchronously with the updated regions. This
  // function is only used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *was_resized)(struct _cef_browser_host_t* self);

  ///
  // Notify the browser that it has been hidden or shown. Layouting and
  // cef_render_handler_t::OnPaint notification will stop when the browser is
  // hidden. This function is only used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *was_hidden)(struct _cef_browser_host_t* self, int hidden);

  ///
  // Send a notification to the browser that the screen info has changed. The
  // browser will then call cef_render_handler_t::GetScreenInfo to update the
  // screen information with the new values. This simulates moving the webview
  // window from one display to another, or changing the properties of the
  // current display. This function is only used when window rendering is
  // disabled.
  ///
  void (CEF_CALLBACK *notify_screen_info_changed)(
      struct _cef_browser_host_t* self);

  ///
  // Invalidate the view. The browser will call cef_render_handler_t::OnPaint
  // asynchronously. This function is only used when window rendering is
  // disabled.
  ///
  void (CEF_CALLBACK *invalidate)(struct _cef_browser_host_t* self,
      cef_paint_element_type_t type);

  ///
  // Send a key event to the browser.
  ///
  void (CEF_CALLBACK *send_key_event)(struct _cef_browser_host_t* self,
      const struct _cef_key_event_t* event);

  ///
  // Send a mouse click event to the browser. The |x| and |y| coordinates are
  // relative to the upper-left corner of the view.
  ///
  void (CEF_CALLBACK *send_mouse_click_event)(struct _cef_browser_host_t* self,
      const struct _cef_mouse_event_t* event, cef_mouse_button_type_t type,
      int mouseUp, int clickCount);

  ///
  // Send a mouse move event to the browser. The |x| and |y| coordinates are
  // relative to the upper-left corner of the view.
  ///
  void (CEF_CALLBACK *send_mouse_move_event)(struct _cef_browser_host_t* self,
      const struct _cef_mouse_event_t* event, int mouseLeave);

  ///
  // Send a mouse wheel event to the browser. The |x| and |y| coordinates are
  // relative to the upper-left corner of the view. The |deltaX| and |deltaY|
  // values represent the movement delta in the X and Y directions respectively.
  // In order to scroll inside select popups with window rendering disabled
  // cef_render_handler_t::GetScreenPoint should be implemented properly.
  ///
  void (CEF_CALLBACK *send_mouse_wheel_event)(struct _cef_browser_host_t* self,
      const struct _cef_mouse_event_t* event, int deltaX, int deltaY);

  ///
  // Send a focus event to the browser.
  ///
  void (CEF_CALLBACK *send_focus_event)(struct _cef_browser_host_t* self,
      int setFocus);

  ///
  // Send a capture lost event to the browser.
  ///
  void (CEF_CALLBACK *send_capture_lost_event)(
      struct _cef_browser_host_t* self);

  ///
  // Notify the browser that the window hosting it is about to be moved or
  // resized. This function is only used on Windows and Linux.
  ///
  void (CEF_CALLBACK *notify_move_or_resize_started)(
      struct _cef_browser_host_t* self);

  ///
  // Returns the maximum rate in frames per second (fps) that
  // cef_render_handler_t:: OnPaint will be called for a windowless browser. The
  // actual fps may be lower if the browser cannot generate frames at the
  // requested rate. The minimum value is 1 and the maximum value is 60 (default
  // 30). This function can only be called on the UI thread.
  ///
  int (CEF_CALLBACK *get_windowless_frame_rate)(
      struct _cef_browser_host_t* self);

  ///
  // Set the maximum rate in frames per second (fps) that cef_render_handler_t::
  // OnPaint will be called for a windowless browser. The actual fps may be
  // lower if the browser cannot generate frames at the requested rate. The
  // minimum value is 1 and the maximum value is 60 (default 30). Can also be
  // set at browser creation via cef_browser_tSettings.windowless_frame_rate.
  ///
  void (CEF_CALLBACK *set_windowless_frame_rate)(
      struct _cef_browser_host_t* self, int frame_rate);

  ///
  // Begins a new composition or updates the existing composition. Blink has a
  // special node (a composition node) that allows the input function to change
  // text without affecting other DOM nodes. |text| is the optional text that
  // will be inserted into the composition node. |underlines| is an optional set
  // of ranges that will be underlined in the resulting text.
  // |replacement_range| is an optional range of the existing text that will be
  // replaced. |selection_range| is an optional range of the resulting text that
  // will be selected after insertion or replacement. The |replacement_range|
  // value is only used on OS X.
  //
  // This function may be called multiple times as the composition changes. When
  // the client is done making changes the composition should either be canceled
  // or completed. To cancel the composition call ImeCancelComposition. To
  // complete the composition call either ImeCommitText or
  // ImeFinishComposingText. Completion is usually signaled when:
  //   A. The client receives a WM_IME_COMPOSITION message with a GCS_RESULTSTR
  //      flag (on Windows), or;
  //   B. The client receives a "commit" signal of GtkIMContext (on Linux), or;
  //   C. insertText of NSTextInput is called (on Mac).
  //
  // This function is only used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *ime_set_composition)(struct _cef_browser_host_t* self,
      const cef_string_t* text, size_t underlinesCount,
      cef_composition_underline_t const* underlines,
      const cef_range_t* replacement_range,
      const cef_range_t* selection_range);

  ///
  // Completes the existing composition by optionally inserting the specified
  // |text| into the composition node. |replacement_range| is an optional range
  // of the existing text that will be replaced. |relative_cursor_pos| is where
  // the cursor will be positioned relative to the current cursor position. See
  // comments on ImeSetComposition for usage. The |replacement_range| and
  // |relative_cursor_pos| values are only used on OS X. This function is only
  // used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *ime_commit_text)(struct _cef_browser_host_t* self,
      const cef_string_t* text, const cef_range_t* replacement_range,
      int relative_cursor_pos);

  ///
  // Completes the existing composition by applying the current composition node
  // contents. If |keep_selection| is false (0) the current selection, if any,
  // will be discarded. See comments on ImeSetComposition for usage. This
  // function is only used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *ime_finish_composing_text)(
      struct _cef_browser_host_t* self, int keep_selection);

  ///
  // Cancels the existing composition and discards the composition node contents
  // without applying them. See comments on ImeSetComposition for usage. This
  // function is only used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *ime_cancel_composition)(struct _cef_browser_host_t* self);

  ///
  // Call this function when the user drags the mouse into the web view (before
  // calling DragTargetDragOver/DragTargetLeave/DragTargetDrop). |drag_data|
  // should not contain file contents as this type of data is not allowed to be
  // dragged into the web view. File contents can be removed using
  // cef_drag_data_t::ResetFileContents (for example, if |drag_data| comes from
  // cef_render_handler_t::StartDragging). This function is only used when
  // window rendering is disabled.
  ///
  void (CEF_CALLBACK *drag_target_drag_enter)(struct _cef_browser_host_t* self,
      struct _cef_drag_data_t* drag_data,
      const struct _cef_mouse_event_t* event,
      cef_drag_operations_mask_t allowed_ops);

  ///
  // Call this function each time the mouse is moved across the web view during
  // a drag operation (after calling DragTargetDragEnter and before calling
  // DragTargetDragLeave/DragTargetDrop). This function is only used when window
  // rendering is disabled.
  ///
  void (CEF_CALLBACK *drag_target_drag_over)(struct _cef_browser_host_t* self,
      const struct _cef_mouse_event_t* event,
      cef_drag_operations_mask_t allowed_ops);

  ///
  // Call this function when the user drags the mouse out of the web view (after
  // calling DragTargetDragEnter). This function is only used when window
  // rendering is disabled.
  ///
  void (CEF_CALLBACK *drag_target_drag_leave)(struct _cef_browser_host_t* self);

  ///
  // Call this function when the user completes the drag operation by dropping
  // the object onto the web view (after calling DragTargetDragEnter). The
  // object being dropped is |drag_data|, given as an argument to the previous
  // DragTargetDragEnter call. This function is only used when window rendering
  // is disabled.
  ///
  void (CEF_CALLBACK *drag_target_drop)(struct _cef_browser_host_t* self,
      const struct _cef_mouse_event_t* event);

  ///
  // Call this function when the drag operation started by a
  // cef_render_handler_t::StartDragging call has ended either in a drop or by
  // being cancelled. |x| and |y| are mouse coordinates relative to the upper-
  // left corner of the view. If the web view is both the drag source and the
  // drag target then all DragTarget* functions should be called before
  // DragSource* mthods. This function is only used when window rendering is
  // disabled.
  ///
  void (CEF_CALLBACK *drag_source_ended_at)(struct _cef_browser_host_t* self,
      int x, int y, cef_drag_operations_mask_t op);

  ///
  // Call this function when the drag operation started by a
  // cef_render_handler_t::StartDragging call has completed. This function may
  // be called immediately without first calling DragSourceEndedAt to cancel a
  // drag operation. If the web view is both the drag source and the drag target
  // then all DragTarget* functions should be called before DragSource* mthods.
  // This function is only used when window rendering is disabled.
  ///
  void (CEF_CALLBACK *drag_source_system_drag_ended)(
      struct _cef_browser_host_t* self);

  ///
  // Returns the current visible navigation entry for this browser. This
  // function can only be called on the UI thread.
  ///
  struct _cef_navigation_entry_t* (CEF_CALLBACK *get_visible_navigation_entry)(
      struct _cef_browser_host_t* self);
} cef_browser_host_t;


///
// Create a new browser window using the window parameters specified by
// |windowInfo|. All values will be copied internally and the actual window will
// be created on the UI thread. If |request_context| is NULL the global request
// context will be used. This function can be called on any browser process
// thread and will not block.
///
CEF_EXPORT int cef_browser_host_create_browser(
    const cef_window_info_t* windowInfo, struct _cef_client_t* client,
    const cef_string_t* url, const struct _cef_browser_settings_t* settings,
    struct _cef_request_context_t* request_context);

///
// Create a new browser window using the window parameters specified by
// |windowInfo|. If |request_context| is NULL the global request context will be
// used. This function can only be called on the browser process UI thread.
///
CEF_EXPORT cef_browser_t* cef_browser_host_create_browser_sync(
    const cef_window_info_t* windowInfo, struct _cef_client_t* client,
    const cef_string_t* url, const struct _cef_browser_settings_t* settings,
    struct _cef_request_context_t* request_context);


#ifdef __cplusplus
}
#endif

#endif  // CEF_INCLUDE_CAPI_CEF_BROWSER_CAPI_H_
