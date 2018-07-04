using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Hash
{
    public unsafe partial class Hash
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash")]
            internal static extern int Hash(byte* @out, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_primitive")]
            internal static extern global::System.IntPtr Primitive();
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static int CryptoHash(byte* @out, byte* @in, ulong inlen)
        {
            var __ret = __Internal.Hash(@out, @in, inlen);
            return __ret;
        }

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }
    }
}
