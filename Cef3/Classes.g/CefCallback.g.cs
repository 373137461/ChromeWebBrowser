//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3
{
    using System;

    using Cef3.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefCallback : IDisposable
    {
        internal static CefCallback FromNative(cef_callback_t* ptr)
        {
            return new CefCallback(ptr);
        }
        
        internal static CefCallback FromNativeOrNull(cef_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefCallback(ptr);
        }
        
        private cef_callback_t* _self;
        
        private CefCallback(cef_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_callback_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_callback_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_callback_t.get_refct(_self); }
        }
        
        internal cef_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
