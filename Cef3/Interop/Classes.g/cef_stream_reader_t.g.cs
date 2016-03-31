//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_stream_reader_t
    {
        internal cef_base_t _base;
        internal IntPtr _read;
        internal IntPtr _seek;
        internal IntPtr _tell;
        internal IntPtr _eof;
        
        // CreateForFile
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_reader_create_for_file", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_reader_t* create_for_file(cef_string_t* fileName);
        
        // CreateForData
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_reader_create_for_data", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_reader_t* create_for_data(void* data, UIntPtr size);
        
        // CreateForHandler
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_reader_create_for_handler", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_reader_t* create_for_handler(cef_read_handler_t* handler);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_stream_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_stream_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_stream_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr read_delegate(cef_stream_reader_t* self, void* ptr, UIntPtr size, UIntPtr n);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int seek_delegate(cef_stream_reader_t* self, long offset, int whence);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate long tell_delegate(cef_stream_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int eof_delegate(cef_stream_reader_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_stream_reader_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            return d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_stream_reader_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static get_refct_delegate _d2;
        
        public static int get_refct(cef_stream_reader_t* self)
        {
            get_refct_delegate d;
            var p = self->_base._get_refct;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (get_refct_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_refct_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // Read
        private static IntPtr _p3;
        private static read_delegate _d3;
        
        public static UIntPtr read(cef_stream_reader_t* self, void* ptr, UIntPtr size, UIntPtr n)
        {
            read_delegate d;
            var p = self->_read;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (read_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(read_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self, ptr, size, n);
        }
        
        // Seek
        private static IntPtr _p4;
        private static seek_delegate _d4;
        
        public static int seek(cef_stream_reader_t* self, long offset, int whence)
        {
            seek_delegate d;
            var p = self->_seek;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (seek_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(seek_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self, offset, whence);
        }
        
        // Tell
        private static IntPtr _p5;
        private static tell_delegate _d5;
        
        public static long tell(cef_stream_reader_t* self)
        {
            tell_delegate d;
            var p = self->_tell;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (tell_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(tell_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // Eof
        private static IntPtr _p6;
        private static eof_delegate _d6;
        
        public static int eof(cef_stream_reader_t* self)
        {
            eof_delegate d;
            var p = self->_eof;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (eof_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(eof_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
    }
}
