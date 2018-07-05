using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Box
{
    public unsafe partial class Curve25519xsalsa20poly1305
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_seedbytes")]
            internal static extern ulong Seedbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_publickeybytes")]
            internal static extern ulong Publickeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_secretkeybytes")]
            internal static extern ulong Secretkeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_beforenmbytes")]
            internal static extern ulong Beforenmbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_macbytes")]
            internal static extern ulong Macbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_seed_keypair")]
            internal static extern int SeedKeypair(byte* pk, byte* sk, byte* seed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_keypair")]
            internal static extern int Keypair(byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_beforenm")]
            internal static extern int Beforenm(byte* k, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_boxzerobytes")]
            internal static extern ulong Boxzerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_zerobytes")]
            internal static extern ulong Zerobytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305")]
            internal static extern int BoxCurve25519xsalsa20poly1305(byte* c, byte* m, ulong mlen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_open")]
            internal static extern int Open(byte* m, byte* c, ulong clen, byte* n, byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_afternm")]
            internal static extern int Afternm(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_box_curve25519xsalsa20poly1305_open_afternm")]
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

        public static ulong Beforenmbytes()
        {
            var __ret = __Internal.Beforenmbytes();
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

        public static int Beforenm(byte[] k, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Beforenm(MarshalHelper.ByteArrayToIntPtr(k), MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
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

        public static int BoxCurve25519xsalsa20poly1305(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] pk, byte[] sk)
        {
            var __ret = __Internal.BoxCurve25519xsalsa20poly1305(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, 
                MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
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
