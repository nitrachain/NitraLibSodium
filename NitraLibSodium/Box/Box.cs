using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Box
{
    public unsafe partial class Box
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_seedbytes")]
            internal static extern ulong Seedbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_publickeybytes")]
            internal static extern ulong Publickeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_secretkeybytes")]
            internal static extern ulong Secretkeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_macbytes")]
            internal static extern ulong Macbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_seed_keypair")]
            internal static extern int SeedKeypair(byte* pk, byte* sk, byte* seed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_keypair")]
            internal static extern int Keypair(byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_easy")]
            internal static extern int Easy(byte* c, byte* m, ulong mlen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_open_easy")]
            internal static extern int OpenEasy(byte* m, byte* c, ulong clen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_detached")]
            internal static extern int Detached(byte* c, byte* mac, byte* m, ulong mlen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_open_detached")]
            internal static extern int OpenDetached(byte* m, byte* c, byte* mac, ulong clen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_beforenmbytes")]
            internal static extern ulong Beforenmbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_beforenm")]
            internal static extern int Beforenm(byte* k, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_easy_afternm")]
            internal static extern int EasyAfternm(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_open_easy_afternm")]
            internal static extern int OpenEasyAfternm(byte* m, byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_detached_afternm")]
            internal static extern int DetachedAfternm(byte* c, byte* mac, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_open_detached_afternm")]
            internal static extern int OpenDetachedAfternm(byte* m, byte* c, byte* mac, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_sealbytes")]
            internal static extern ulong Sealbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_seal")]
            internal static extern int Seal(byte* c, byte* m, ulong mlen, byte* pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_seal_open")]
            internal static extern int SealOpen(byte* m, byte* c, ulong clen, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_zerobytes")]
            internal static extern ulong Zerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_boxzerobytes")]
            internal static extern ulong Boxzerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box")]
            internal static extern int Box(byte* c, byte* m, ulong mlen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_open")]
            internal static extern int Open(byte* m, byte* c, ulong clen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_afternm")]
            internal static extern int Afternm(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_open_afternm")]
            internal static extern int OpenAfternm(byte* m, byte* c, ulong clen, byte* n, byte* k);
        }

        public static ulong Seedbytes()
        {
            var __ret = __Internal.Seedbytes();
            return __ret;
        }

        public static ulong Publickeybytes()
        {
            var __ret = __Internal.Publickeybytes();
            return __ret;
        }

        public static ulong Secretkeybytes()
        {
            var __ret = __Internal.Secretkeybytes();
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

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int SeedKeypair(byte[] pk, byte[] sk, byte[] seed)
        {
            var __ret = __Internal.SeedKeypair(MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk), MarshalHelper.ByteArrayToIntPtr(seed));
            return __ret;
        }

        public static int Keypair(byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Keypair(MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int Easy(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Easy(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), 
                MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int OpenEasy(byte[] m, byte[] c, ulong clen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.OpenEasy(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(n), 
                MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int Detached(byte[] c, byte[] mac, byte[] m, ulong mlen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Detached(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), 
                MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int OpenDetached(byte[] m, byte[] c, byte[] mac, ulong clen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.OpenDetached(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), clen, MarshalHelper.ByteArrayToIntPtr(n), 
                MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static ulong Beforenmbytes()
        {
            var __ret = __Internal.Beforenmbytes();
            return __ret;
        }

        public static int Beforenm(byte[] k, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Beforenm(MarshalHelper.ByteArrayToIntPtr(k), MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int EasyAfternm(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] k)
        {
            var __ret = __Internal.EasyAfternm(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, 
                MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int OpenEasyAfternm(byte[] m, byte[] c, ulong clen, byte[] n, byte[] k)
        {
            var __ret = __Internal.OpenEasyAfternm(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), clen, 
                MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int DetachedAfternm(byte[] c, byte[] mac, byte[] m, ulong mlen, byte[] n, byte[] k)
        {
            var __ret = __Internal.DetachedAfternm(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), MarshalHelper.ByteArrayToIntPtr(m), mlen, 
                MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int OpenDetachedAfternm(byte[] m, byte[] c, byte[] mac, ulong clen, byte[] n, byte[] k)
        {
            var __ret = __Internal.OpenDetachedAfternm(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), 
                clen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static ulong Sealbytes()
        {
            var __ret = __Internal.Sealbytes();
            return __ret;
        }

        public static int Seal(byte[] c, byte[] m, ulong mlen, byte[] pk)
        {
            var __ret = __Internal.Seal(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(pk));
            return __ret;
        }

        public static int SealOpen(byte[] m, byte[] c, ulong clen, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.SealOpen(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
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

        public static int CryptoBox(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Box(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int Open(byte[] m, byte[] c, ulong clen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Open(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int Afternm(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] k)
        {
            var __ret = __Internal.Afternm(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int OpenAfternm(byte[] m, byte[] c, ulong clen, byte[] n, byte[] k)
        {
            var __ret = __Internal.OpenAfternm(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }
    }
}
