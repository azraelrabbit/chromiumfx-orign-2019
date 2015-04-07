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


// cef_task

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_task_t {
    cef_task_t cef_task;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_task_t;

int CEF_CALLBACK _cfx_task_add_ref(struct _cef_base_t* base) {
    return InterlockedIncrement(&((cfx_task_t*)base)->ref_count);
}
int CEF_CALLBACK _cfx_task_release(struct _cef_base_t* base) {
    int count = InterlockedDecrement(&((cfx_task_t*)base)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_task_t*)base)->gc_handle);
        free(base);
        return 0;
    }
    return count;
}
int CEF_CALLBACK _cfx_task_get_refct(struct _cef_base_t* base) {
    return ((cfx_task_t*)base)->ref_count;
}

static cfx_task_t* cfx_task_ctor(gc_handle_t gc_handle) {
    cfx_task_t* ptr = (cfx_task_t*)calloc(1, sizeof(cfx_task_t));
    if(!ptr) return 0;
    ptr->cef_task.base.size = sizeof(cef_task_t);
    ptr->cef_task.base.add_ref = _cfx_task_add_ref;
    ptr->cef_task.base.release = _cfx_task_release;
    ptr->cef_task.base.get_refct = _cfx_task_get_refct;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

static gc_handle_t cfx_task_get_gc_handle(cfx_task_t* self) {
    return self->gc_handle;
}

// execute

void (CEF_CALLBACK *cfx_task_execute_callback)(gc_handle_t self);

void CEF_CALLBACK cfx_task_execute(cef_task_t* self) {
    cfx_task_execute_callback(((cfx_task_t*)self)->gc_handle);
}


static void cfx_task_set_managed_callback(cef_task_t* self, int index, void* callback) {
    switch(index) {
    case 0:
        if(callback && !cfx_task_execute_callback)
            cfx_task_execute_callback = (void (CEF_CALLBACK *)(gc_handle_t self)) callback;
        self->execute = callback ? cfx_task_execute : 0;
        break;
    }
}

#ifdef __cplusplus
} // extern "C"
#endif

