using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.SecretBox
{
    public unsafe partial class Xsalsa20poly1305
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_macbytes")]
            internal static extern ulong Macbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305")]
            internal static extern int Xsalsa20poly1305(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_open")]
            internal static extern int Open(byte* m, byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_keygen")]
            internal static extern void Keygen(byte[] k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_boxzerobytes")]
            internal static extern ulong Boxzerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xsalsa20poly1305_zerobytes")]
            internal static extern ulong Zerobytes();
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

        public static ulong Macbytes()
        {
            var __ret = __Internal.Macbytes();
            return __ret;
        }

        public static ulong MessagebytesMax()
        {
            var __ret = __Internal.MessagebytesMax();
            return __ret;
        }

        public static int CryptoXsalsa20poly1305(byte* c, byte* m, ulong mlen, byte* n, byte* k)
        {
            var __ret = __Internal.Xsalsa20poly1305(c, m, mlen, n, k);
            return __ret;
        }

        public static int Open(byte* m, byte* c, ulong clen, byte* n, byte* k)
        {
            var __ret = __Internal.Open(m, c, clen, n, k);
            return __ret;
        }

        public static void Keygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.Keygen(k);
        }

        public static ulong Boxzerobytes()
        {
            var __ret = __Internal.Boxzerobytes();
            return __ret;
        }

        public static ulong Zerobytes()
        {
            var __ret = __Internal.Zerobytes();
            return __ret;
        }
    }
}
