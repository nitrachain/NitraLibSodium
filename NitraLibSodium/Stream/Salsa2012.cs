using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Stream
{
    public unsafe partial class Salsa2012
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa2012_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa2012_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa2012_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa2012")]
            internal static extern int Salsa2012(byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa2012_xor")]
            internal static extern int Xor(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa2012_keygen")]
            internal static extern void Keygen(byte[] k);
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static ulong Noncebytes()
        {
            var __ret = __Internal.Noncebytes();
            return __ret;
        }

        public static ulong MessagebytesMax()
        {
            var __ret = __Internal.MessagebytesMax();
            return __ret;
        }

        public static int CryptoSalsa2012(byte[] c, ulong clen, byte[] n, byte[] k)
        {
            var __ret = __Internal.Salsa2012(MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int Xor(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] k)
        {
            var __ret = __Internal.Xor(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static void Keygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.Keygen(k);
        }
    }
}
