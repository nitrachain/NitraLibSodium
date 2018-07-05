using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.ShortHash
{
    public unsafe partial class Siphash24
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_siphash24_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_siphash24_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_siphash24")]
            internal static extern int Siphash24(byte* @out, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_siphashx24_bytes")]
            internal static extern ulong X24Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_siphashx24_keybytes")]
            internal static extern ulong X24Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_shorthash_siphashx24")]
            internal static extern int SiphashX24(byte* @out, byte* @in, ulong inlen, byte* k);
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

        public static int CryptoSiphash24(byte[] @out, byte[] @in, ulong inlen, byte[] k)
        {
            var __ret = __Internal.Siphash24(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static ulong X24Bytes()
        {
            var __ret = __Internal.X24Bytes();
            return __ret;
        }

        public static ulong X24Keybytes()
        {
            var __ret = __Internal.X24Keybytes();
            return __ret;
        }

        public static int SiphashX24(byte[] @out, byte[] @in, ulong inlen, byte[] k)
        {
            var __ret = __Internal.SiphashX24(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }
    }
}
