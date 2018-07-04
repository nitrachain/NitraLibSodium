using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.SecretBox
{
    public unsafe partial class Xchacha20poly1305
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_macbytes")]
            internal static extern ulong Macbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_easy")]
            internal static extern int Easy(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_open_easy")]
            internal static extern int OpenEasy(byte* m, byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_detached")]
            internal static extern int Detached(byte* c, byte* mac, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretbox_xchacha20poly1305_open_detached")]
            internal static extern int OpenDetached(byte* m, byte* c, byte* mac, ulong clen, byte* n, byte* k);
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
    }
}
