using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.SecretStream
{
    public unsafe partial class Xchacha20poly1305
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_abytes")]
            internal static extern ulong Abytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_headerbytes")]
            internal static extern ulong Headerbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_tag_message")]
            internal static extern byte TagMessage();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_tag_push")]
            internal static extern byte TagPush();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_tag_rekey")]
            internal static extern byte TagRekey();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_tag_final")]
            internal static extern byte TagFinal();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_keygen")]
            internal static extern void Keygen(byte[] k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_init_push")]
            internal static extern int InitPush(global::System.IntPtr state, byte[] header, byte[] k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_push")]
            internal static extern int Push(global::System.IntPtr state, byte* c, ulong* clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte tag);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_init_pull")]
            internal static extern int InitPull(global::System.IntPtr state, byte[] header, byte[] k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_pull")]
            internal static extern int Pull(global::System.IntPtr state, byte* m, ulong* mlen_p, byte* tag_p, byte* c, ulong clen, byte* ad, ulong adlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_secretstream_xchacha20poly1305_rekey")]
            internal static extern void Rekey(global::System.IntPtr state);
        }

        public static ulong Abytes()
        {
            var __ret = __Internal.Abytes();
            return __ret;
        }

        public static ulong Headerbytes()
        {
            var __ret = __Internal.Headerbytes();
            return __ret;
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static ulong MessagebytesMax()
        {
            var __ret = __Internal.MessagebytesMax();
            return __ret;
        }

        public static byte TagMessage()
        {
            var __ret = __Internal.TagMessage();
            return __ret;
        }

        public static byte TagPush()
        {
            var __ret = __Internal.TagPush();
            return __ret;
        }

        public static byte TagRekey()
        {
            var __ret = __Internal.TagRekey();
            return __ret;
        }

        public static byte TagFinal()
        {
            var __ret = __Internal.TagFinal();
            return __ret;
        }

        public static ulong Statebytes()
        {
            var __ret = __Internal.Statebytes();
            return __ret;
        }

        public static void Keygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.Keygen(k);
        }

        public static int InitPush(global::NitraLibSodium.SecretStream.Xchacha20poly1305State state, byte[] header, byte[] k)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            if (header == null || header.Length != 24)
                throw new ArgumentOutOfRangeException("header", "The dimensions of the provided array don't match the required size.");
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.InitPush(__arg0, header, k);
            return __ret;
        }

        public static int Push(global::NitraLibSodium.SecretStream.Xchacha20poly1305State state, byte* c, ref ulong clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte tag)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            fixed (ulong* __refParamPtr2 = &clen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.Push(__arg0, c, __arg2, m, mlen, ad, adlen, tag);
                return __ret;
            }
        }

        public static int InitPull(global::NitraLibSodium.SecretStream.Xchacha20poly1305State state, byte[] header, byte[] k)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            if (header == null || header.Length != 24)
                throw new ArgumentOutOfRangeException("header", "The dimensions of the provided array don't match the required size.");
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.InitPull(__arg0, header, k);
            return __ret;
        }

        public static int Pull(global::NitraLibSodium.SecretStream.Xchacha20poly1305State state, byte* m, ref ulong mlen_p, byte* tag_p, byte* c, ulong clen, byte* ad, ulong adlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            fixed (ulong* __refParamPtr2 = &mlen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.Pull(__arg0, m, __arg2, tag_p, c, clen, ad, adlen);
                return __ret;
            }
        }

        public static void Rekey(global::NitraLibSodium.SecretStream.Xchacha20poly1305State state)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            __Internal.Rekey(__arg0);
        }
    }
}
