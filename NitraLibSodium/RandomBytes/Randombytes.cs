using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Randombytes
{
    public unsafe partial class Randombytes
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_seedbytes")]
            internal static extern ulong Seedbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_buf")]
            internal static extern void Buf(global::System.IntPtr buf, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_buf_deterministic")]
            internal static extern void BufDeterministic(global::System.IntPtr buf, ulong size, byte[] seed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_random")]
            internal static extern uint Random();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_uniform")]
            internal static extern uint Uniform(uint upper_bound);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_stir")]
            internal static extern void Stir();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_close")]
            internal static extern int Close();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_set_implementation")]
            internal static extern int SetImplementation(global::System.IntPtr impl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes_implementation_name")]
            internal static extern global::System.IntPtr ImplementationName();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "randombytes")]
            internal static extern void Randombytes(byte* buf, ulong buf_len);
        }

        public static ulong Seedbytes()
        {
            var __ret = __Internal.Seedbytes();
            return __ret;
        }

        public static void Buf(global::System.IntPtr buf, ulong size)
        {
            __Internal.Buf(buf, size);
        }

        public static void BufDeterministic(global::System.IntPtr buf, ulong size, byte[] seed)
        {
            if (seed == null || seed.Length != 32)
                throw new ArgumentOutOfRangeException("seed", "The dimensions of the provided array don't match the required size.");
            __Internal.BufDeterministic(buf, size, seed);
        }

        public static uint Random()
        {
            var __ret = __Internal.Random();
            return __ret;
        }

        public static uint Uniform(uint upper_bound)
        {
            var __ret = __Internal.Uniform(upper_bound);
            return __ret;
        }

        public static void Stir()
        {
            __Internal.Stir();
        }

        public static int Close()
        {
            var __ret = __Internal.Close();
            return __ret;
        }

        public static int SetImplementation(global::NitraLibSodium.Randombytes.Implementation impl)
        {
            var __arg0 = ReferenceEquals(impl, null) ? global::System.IntPtr.Zero : impl.__Instance;
            var __ret = __Internal.SetImplementation(__arg0);
            return __ret;
        }

        public static string ImplementationName()
        {
            var __ret = __Internal.ImplementationName();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static void RandomBytes(byte* buf, ulong buf_len)
        {
            __Internal.Randombytes(buf, buf_len);
        }
    }
}
