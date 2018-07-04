using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium
{
    public unsafe partial class StreamSalsa208
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa208_keybytes")]
            internal static extern ulong CryptoStreamSalsa208Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa208_noncebytes")]
            internal static extern ulong CryptoStreamSalsa208Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa208_messagebytes_max")]
            internal static extern ulong CryptoStreamSalsa208MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa208")]
            internal static extern int CryptoStreamSalsa208(byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa208_xor")]
            internal static extern int CryptoStreamSalsa208Xor(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa208_keygen")]
            internal static extern void CryptoStreamSalsa208Keygen(byte[] k);
        }

        public static ulong CryptoStreamSalsa208Keybytes()
        {
            var __ret = __Internal.CryptoStreamSalsa208Keybytes();
            return __ret;
        }

        public static ulong CryptoStreamSalsa208Noncebytes()
        {
            var __ret = __Internal.CryptoStreamSalsa208Noncebytes();
            return __ret;
        }

        public static ulong CryptoStreamSalsa208MessagebytesMax()
        {
            var __ret = __Internal.CryptoStreamSalsa208MessagebytesMax();
            return __ret;
        }

        public static int CryptoStreamSalsa208(byte* c, ulong clen, byte* n, byte* k)
        {
            var __ret = __Internal.CryptoStreamSalsa208(c, clen, n, k);
            return __ret;
        }

        public static int CryptoStreamSalsa208Xor(byte* c, byte* m, ulong mlen, byte* n, byte* k)
        {
            var __ret = __Internal.CryptoStreamSalsa208Xor(c, m, mlen, n, k);
            return __ret;
        }

        public static void CryptoStreamSalsa208Keygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.CryptoStreamSalsa208Keygen(k);
        }
    }


}
