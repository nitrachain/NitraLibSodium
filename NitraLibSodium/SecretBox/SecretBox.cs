using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.SecretBox
{
    public unsafe partial class SecretBox
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_macbytes")]
            internal static extern ulong Macbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_easy")]
            internal static extern int Easy(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_open_easy")]
            internal static extern int OpenEasy(byte* m, byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_detached")]
            internal static extern int Detached(byte* c, byte* mac, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_open_detached")]
            internal static extern int OpenDetached(byte* m, byte* c, byte* mac, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_keygen")]
            internal static extern void Keygen(byte[] k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_zerobytes")]
            internal static extern ulong Zerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_boxzerobytes")]
            internal static extern ulong Boxzerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox")]
            internal static extern int Secretbox(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_open")]
            internal static extern int Open(byte* m, byte* c, ulong clen, byte* n, byte* k);
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

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static ulong MessagebytesMax()
        {
            var __ret = __Internal.MessagebytesMax();
            return __ret;
        }

        public static int Easy(byte* c, byte* m, ulong mlen, byte* n, byte* k)
        {
            var __ret = __Internal.Easy(c, m, mlen, n, k);
            return __ret;
        }

        public static int OpenEasy(byte* m, byte* c, ulong clen, byte* n, byte* k)
        {
            var __ret = __Internal.OpenEasy(m, c, clen, n, k);
            return __ret;
        }

        public static int Detached(byte* c, byte* mac, byte* m, ulong mlen, byte* n, byte* k)
        {
            var __ret = __Internal.Detached(c, mac, m, mlen, n, k);
            return __ret;
        }

        public static int OpenDetached(byte* m, byte* c, byte* mac, ulong clen, byte* n, byte* k)
        {
            var __ret = __Internal.OpenDetached(m, c, mac, clen, n, k);
            return __ret;
        }

        public static void Keygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.Keygen(k);
        }

        public static ulong Zerobytes()
        {
            var __ret = __Internal.Zerobytes();
            return __ret;
        }

        public static ulong Boxzerobytes()
        {
            var __ret = __Internal.Boxzerobytes();
            return __ret;
        }

        public static int CryptoSecretbox(byte* c, byte* m, ulong mlen, byte* n, byte* k)
        {
            var __ret = __Internal.Secretbox(c, m, mlen, n, k);
            return __ret;
        }

        public static int Open(byte* m, byte* c, ulong clen, byte* n, byte* k)
        {
            var __ret = __Internal.Open(m, c, clen, n, k);
            return __ret;
        }
    }
}
