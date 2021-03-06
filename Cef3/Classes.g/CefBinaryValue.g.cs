//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3
{
    using System;

    using Cef3.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefBinaryValue : IDisposable
    {
        internal static CefBinaryValue FromNative(cef_binary_value_t* ptr)
        {
            return new CefBinaryValue(ptr);
        }
        
        internal static CefBinaryValue FromNativeOrNull(cef_binary_value_t* ptr)
        {
            if (ptr == null) return null;
            return new CefBinaryValue(ptr);
        }
        
        private cef_binary_value_t* _self;
        
        private CefBinaryValue(cef_binary_value_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefBinaryValue()
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
            return cef_binary_value_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_binary_value_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_binary_value_t.get_refct(_self); }
        }
        
        internal cef_binary_value_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
