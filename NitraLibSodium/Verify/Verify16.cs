using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Verify
{
    public unsafe partial class Verify16
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_verify_16_bytes")]
            internal static extern ulong Verify16Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_verify_16")]
            internal static extern int Verify16(byte* x, byte* y);
        }

        public static ulong Verify16Bytes()
        {
            var __ret = __Internal.Verify16Bytes();
            return __ret;
        }

        public static int CryptoVerify16(byte[] x, byte[] y)
        {
            var __ret = __Internal.Verify16(MarshalHelper.ByteArrayToIntPtr(x), MarshalHelper.ByteArrayToIntPtr(y));
            return __ret;
        }
    }
}
