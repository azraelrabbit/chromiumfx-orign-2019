﻿// Copyright (c) 2014-2015 Wolfgang Borgsmüller
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Chromium.Remote;
using Chromium.Remote.Event;

namespace Chromium.WebBrowser {

    /// <summary>
    /// Represents a javascript object in the render process to be added as 
    /// a property to a browser frame's global object or to another JSObject.
    /// </summary>
    public class JSObject : JSProperty {


        private readonly Dictionary<string, JSProperty> jsProperties = new Dictionary<string, JSProperty>();
        private CfrV8Accessor v8Accessor;

        /// <summary>
        /// If true, dynamic properties and functions in this object 
        /// are executed on the thread that owns the browser's 
        /// underlying window handle. Preserves affinity to the render thread.
        /// </summary>
        public bool InvokeOnBrowser { get; private set; }

        /// <summary>
        /// Creates a new javascript object to be added as a property 
        /// to a browser frame's global object or to another JSObject.
        /// </summary>
        public JSObject()
            : base(JSPropertyType.Object) {
        }

        /// <summary>
        /// Creates a new javascript object to be added as a property 
        /// to a browser frame's global object or to another JSObject.
        /// If invokeOnBrowser is true, dynamic properties and functions 
        /// in this object are executed on the thread that owns the browser's 
        /// underlying window handle. Preserves affinity to the render thread.
        /// </summary>
        public JSObject(bool invokeOnBrowser)
            : base(JSPropertyType.Object) {
            this.InvokeOnBrowser = invokeOnBrowser;
        }

        /// <summary>
        /// Add a javascript property to this object.
        /// </summary>
        public void AddProperty(string propertyName, JSProperty property) {
            property.SetParent(propertyName, this);
            if(jsProperties.ContainsKey(propertyName))
                throw new CfxException("Property already exists.");
            jsProperties.Add(propertyName, property);
        }

        /// <summary>
        /// Add a javascript function as a property to this object.
        /// If InvokeOnBrowser is true, the function is executed 
        /// on the thread that owns the browser's 
        /// underlying window handle. Preserves affinity to 
        /// the original thread.
        /// </summary>
        public JSFunction AddFunction(string functionName) {
            var f = new JSFunction(InvokeOnBrowser);
            AddProperty(functionName, f);
            return f;
        }

        /// <summary>
        /// Add another javascript object as a property to this object.
        /// If InvokeOnBrowser is true, any functions of the other object
        /// are executed on the thread that owns the browser's 
        /// underlying window handle. Preserves affinity to 
        /// the original thread.
        /// </summary>
        public JSObject AddObject(string objectName) {
            var o = new JSObject(InvokeOnBrowser);
            AddProperty(objectName, o);
            return o;
        }

        /// <summary>
        /// Add a dynamic javascript property to this object.
        /// If InvokeOnBrowser is true, the property's 
        /// setter and getter events are executed 
        /// on the thread that owns the browser's 
        /// underlying window handle. Preserves affinity to 
        /// the original thread.
        /// </summary>
        public JSDynamicProperty AddDynamicProperty(string propertyName) {
            var p = new JSDynamicProperty(InvokeOnBrowser);
            AddProperty(propertyName, p);
            return p;
        }


        internal override CfrV8Value CreateV8Value() {
            v8Accessor = new CfrV8Accessor(v8Context.RemoteRuntime);
            v8Accessor.Get += v8Accessor_Get;
            v8Accessor.Set += v8Accessor_Set;
            var o = CfrV8Value.CreateObject(v8Context.RemoteRuntime, v8Accessor);
            foreach(var p in jsProperties) {
                if(p.Value.PropertyType == JSPropertyType.Dynamic) {
                    o.SetValue(p.Key, CfxV8AccessControl.Default, CfxV8PropertyAttribute.DontDelete);
                } else {
                    o.SetValue(p.Key, p.Value.GetV8Value(v8Context), CfxV8PropertyAttribute.DontDelete | CfxV8PropertyAttribute.ReadOnly);
                }
            }
            return o;
        }

        void v8Accessor_Set(object sender, CfrV8AccessorSetEventArgs e) {
            JSProperty property;
            if(jsProperties.TryGetValue(e.Name, out property)) {
                ((JSDynamicProperty)property).RaisePropertySet(e);
            } else {
                //this should never be reached
                e.SetReturnValue(false);
            }
        }

        void v8Accessor_Get(object sender, CfrV8AccessorGetEventArgs e) {
            JSProperty property;
            if(jsProperties.TryGetValue(e.Name, out property)) {
                ((JSDynamicProperty)property).RaisePropertyGet(e);
            } else {
                //this should never be reached
                e.SetReturnValue(false);
            }
        }
    }
}
