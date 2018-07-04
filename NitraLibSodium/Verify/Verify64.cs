using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Verify
{
    public unsafe partial class Verify64
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_verify_64_bytes")]
            internal static extern ulong Verify64Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_verify_64")]
            internal static extern int Verify64(byte* x, byte* y);
        }

        public static ulong Verify64Bytes()
        {
            var __ret = __Internal.Verify64Bytes();
            return __ret;
        }

        public static int CryptoVerify64(byte* x, byte* y)
        {
            var __ret = __Internal.Verify64(x, y);
            return __ret;
        }
    }
}
