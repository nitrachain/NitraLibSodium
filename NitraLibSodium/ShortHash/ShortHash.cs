using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.ShortHash
{
    public unsafe partial class ShortHash
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash")]
            internal static extern int Shorthash(byte* @out, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_keygen")]
            internal static extern void Keygen(byte[] k);
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int CryptoShorthash(byte[] @out, byte[] @in, ulong inlen, byte[] k)
        {
            var __ret = __Internal.Shorthash(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static void Keygen(byte[] k)
        {
            if (k == null || k.Length != 16)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.Keygen(k);
        }
    }
}
