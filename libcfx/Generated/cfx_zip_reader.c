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


// cef_zip_reader

#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT cef_zip_reader_t* cef_zip_reader_create(cef_stream_reader_t* stream);
CFX_EXPORT cef_zip_reader_t* cfx_zip_reader_create(cef_stream_reader_t* stream) {
    if(stream) ((cef_base_t*)stream)->add_ref((cef_base_t*)stream);
    return cef_zip_reader_create(stream);
}
// cef_base_t base

// move_to_first_file
CFX_EXPORT int cfx_zip_reader_move_to_first_file(cef_zip_reader_t* self) {
    return self->move_to_first_file(self);
}

// move_to_next_file
CFX_EXPORT int cfx_zip_reader_move_to_next_file(cef_zip_reader_t* self) {
    return self->move_to_next_file(self);
}

// move_to_file
CFX_EXPORT int cfx_zip_reader_move_to_file(cef_zip_reader_t* self, char16 *fileName_str, int fileName_length, int caseSensitive) {
    cef_string_t fileName = { fileName_str, fileName_length, 0 };
    return self->move_to_file(self, &fileName, caseSensitive);
}

// close
CFX_EXPORT int cfx_zip_reader_close(cef_zip_reader_t* self) {
    return self->close(self);
}

// get_file_name
CFX_EXPORT cef_string_userfree_t cfx_zip_reader_get_file_name(cef_zip_reader_t* self) {
    return self->get_file_name(self);
}

// get_file_size
CFX_EXPORT int64 cfx_zip_reader_get_file_size(cef_zip_reader_t* self) {
    return self->get_file_size(self);
}

// get_file_last_modified
CFX_EXPORT int64 cfx_zip_reader_get_file_last_modified(cef_zip_reader_t* self) {
    return (int64)(self->get_file_last_modified(self));
}

// open_file
CFX_EXPORT int cfx_zip_reader_open_file(cef_zip_reader_t* self, char16 *password_str, int password_length) {
    cef_string_t password = { password_str, password_length, 0 };
    return self->open_file(self, &password);
}

// close_file
CFX_EXPORT int cfx_zip_reader_close_file(cef_zip_reader_t* self) {
    return self->close_file(self);
}

// read_file
CFX_EXPORT int cfx_zip_reader_read_file(cef_zip_reader_t* self, void* buffer, int bufferSize) {
    return self->read_file(self, buffer, (size_t)(bufferSize));
}

// tell
CFX_EXPORT int64 cfx_zip_reader_tell(cef_zip_reader_t* self) {
    return self->tell(self);
}

// eof
CFX_EXPORT int cfx_zip_reader_eof(cef_zip_reader_t* self) {
    return self->eof(self);
}


#ifdef __cplusplus
} // extern "C"
#endif
