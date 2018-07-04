using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.ScalarMult
{
    public unsafe partial class ScalarMult
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_scalarbytes")]
            internal static extern ulong Scalarbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_base")]
            internal static extern int Base(byte* q, byte* n);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult")]
            internal static extern int Scalarmult(byte* q, byte* n, byte* p);
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static ulong Scalarbytes()
        {
            var __ret = __Internal.Scalarbytes();
            return __ret;
        }

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int Base(byte* q, byte* n)
        {
            var __ret = __Internal.Base(q, n);
            return __ret;
        }

        public static int CryptoScalarmult(byte* q, byte* n, byte* p)
        {
            var __ret = __Internal.Scalarmult(q, n, p);
            return __ret;
        }
    }
}
