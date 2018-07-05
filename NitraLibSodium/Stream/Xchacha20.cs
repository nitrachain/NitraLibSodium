using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Stream
{
    public unsafe partial class Xchacha20
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20_noncebytes")]
            internal static extern ulong Noncebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20")]
            internal static extern int Xchacha20(byte* c, ulong clen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20_xor")]
            internal static extern int Xor(byte* c, byte* m, ulong mlen, byte* n, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20_xor_ic")]
            internal static extern int XorIc(byte* c, byte* m, ulong mlen, byte* n, ulong ic, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_stream_xchacha20_keygen")]
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

        public static int CryptoXchacha20(byte[] c, ulong clen, byte[] n, byte[] k)
        {
            var __ret = __Internal.Xchacha20(MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int Xor(byte[] c, byte[] m, ulong mlen, byte[] n, byte[] k)
        {
            var __ret = __Internal.Xor(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int XorIc(byte[] c, byte[] m, ulong mlen, byte[] n, ulong ic, byte[] k)
        {
            var __ret = __Internal.XorIc(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(n), ic, MarshalHelper.ByteArrayToIntPtr(k));
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
