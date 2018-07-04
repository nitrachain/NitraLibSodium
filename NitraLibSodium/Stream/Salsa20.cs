using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Stream
{
    public unsafe partial class Salsa20
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20")]
            internal static extern int Salsa20(byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20_xor")]
            internal static extern int Xor(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20_xor_ic")]
            internal static extern int XorIc(byte* c, byte* m, ulong mlen, byte* n, ulong ic, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_salsa20_keygen")]
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

        public static int CryptoSalsa20(byte* c, ulong clen, byte* n, byte* k)
        {
            var __ret = __Internal.Salsa20(c, clen, n, k);
            return __ret;
        }

        public static int Xor(byte* c, byte* m, ulong mlen, byte* n, byte* k)
        {
            var __ret = __Internal.Xor(c, m, mlen, n, k);
            return __ret;
        }

        public static int XorIc(byte* c, byte* m, ulong mlen, byte* n, ulong ic, byte* k)
        {
            var __ret = __Internal.XorIc(c, m, mlen, n, ic, k);
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
