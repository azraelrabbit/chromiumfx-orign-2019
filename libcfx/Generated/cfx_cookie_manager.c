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


// cef_cookie_manager

#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT cef_cookie_manager_t* cef_cookie_manager_get_global_manager();
CFX_EXPORT cef_cookie_manager_t* cfx_cookie_manager_get_global_manager() {
    return cef_cookie_manager_get_global_manager();
}
// CEF_EXPORT cef_cookie_manager_t* cef_cookie_manager_create_manager(const cef_string_t* path, int persist_session_cookies);
CFX_EXPORT cef_cookie_manager_t* cfx_cookie_manager_create_manager(char16 *path_str, int path_length, int persist_session_cookies) {
    cef_string_t path = { path_str, path_length, 0 };
    return cef_cookie_manager_create_manager(&path, persist_session_cookies);
}
// cef_base_t base

// set_supported_schemes
CFX_EXPORT void cfx_cookie_manager_set_supported_schemes(cef_cookie_manager_t* self, cef_string_list_t schemes) {
    self->set_supported_schemes(self, schemes);
}

// visit_all_cookies
CFX_EXPORT int cfx_cookie_manager_visit_all_cookies(cef_cookie_manager_t* self, cef_cookie_visitor_t* visitor) {
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    return self->visit_all_cookies(self, visitor);
}

// visit_url_cookies
CFX_EXPORT int cfx_cookie_manager_visit_url_cookies(cef_cookie_manager_t* self, char16 *url_str, int url_length, int includeHttpOnly, cef_cookie_visitor_t* visitor) {
    cef_string_t url = { url_str, url_length, 0 };
    if(visitor) ((cef_base_t*)visitor)->add_ref((cef_base_t*)visitor);
    return self->visit_url_cookies(self, &url, includeHttpOnly, visitor);
}

// set_cookie
CFX_EXPORT int cfx_cookie_manager_set_cookie(cef_cookie_manager_t* self, char16 *url_str, int url_length, const cef_cookie_t* cookie) {
    cef_string_t url = { url_str, url_length, 0 };
    return self->set_cookie(self, &url, cookie);
}

// delete_cookies
CFX_EXPORT int cfx_cookie_manager_delete_cookies(cef_cookie_manager_t* self, char16 *url_str, int url_length, char16 *cookie_name_str, int cookie_name_length) {
    cef_string_t url = { url_str, url_length, 0 };
    cef_string_t cookie_name = { cookie_name_str, cookie_name_length, 0 };
    return self->delete_cookies(self, &url, &cookie_name);
}

// set_storage_path
CFX_EXPORT int cfx_cookie_manager_set_storage_path(cef_cookie_manager_t* self, char16 *path_str, int path_length, int persist_session_cookies) {
    cef_string_t path = { path_str, path_length, 0 };
    return self->set_storage_path(self, &path, persist_session_cookies);
}

// flush_store
CFX_EXPORT int cfx_cookie_manager_flush_store(cef_cookie_manager_t* self, cef_completion_callback_t* callback) {
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    return self->flush_store(self, callback);
}


#ifdef __cplusplus
} // extern "C"
#endif
