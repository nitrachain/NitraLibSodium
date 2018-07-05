using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Verify
{
    public unsafe partial class Verify32
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_verify_32_bytes")]
            internal static extern ulong Verify32Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_verify_32")]
            internal static extern int Verify32(byte* x, byte* y);
        }

        public static ulong Verify32Bytes()
        {
            var __ret = __Internal.Verify32Bytes();
            return __ret;
        }

        public static int CryptoVerify32(byte[] x, byte[] y)
        {
            var __ret = __Internal.Verify32(MarshalHelper.ByteArrayToIntPtr(x), MarshalHelper.ByteArrayToIntPtr(y));
            return __ret;
        }
    }
}
