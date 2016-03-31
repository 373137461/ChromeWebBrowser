//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3
{
    using System;

    using Cef3.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefResponse : IDisposable
    {
        internal static CefResponse FromNative(cef_response_t* ptr)
        {
            return new CefResponse(ptr);
        }
        
        internal static CefResponse FromNativeOrNull(cef_response_t* ptr)
        {
            if (ptr == null) return null;
            return new CefResponse(ptr);
        }
        
        private cef_response_t* _self;
        
        private CefResponse(cef_response_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefResponse()
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
            return cef_response_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_response_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_response_t.get_refct(_self); }
        }
        
        internal cef_response_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
