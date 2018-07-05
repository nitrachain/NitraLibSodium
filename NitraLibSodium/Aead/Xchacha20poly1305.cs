using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Aead
{
    public unsafe partial class Xchacha20poly1305
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_keybytes")]
            internal static extern ulong IetfKeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_nsecbytes")]
            internal static extern ulong IetfNsecbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_npubbytes")]
            internal static extern ulong IetfNpubbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_abytes")]
            internal static extern ulong IetfAbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_messagebytes_max")]
            internal static extern ulong IetfMessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_encrypt")]
            internal static extern int IetfEncrypt(byte* c, ulong* clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_decrypt")]
            internal static extern int IetfDecrypt(byte* m, ulong* mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_encrypt_detached")]
            internal static extern int IetfEncryptDetached(byte* c, byte* mac, ulong* maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_decrypt_detached")]
            internal static extern int IetfDecryptDetached(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_xchacha20poly1305_ietf_keygen")]
            internal static extern void IetfKeygen(byte[] k);
        }

        public static ulong IetfKeybytes()
        {
            var __ret = __Internal.IetfKeybytes();
            return __ret;
        }

        public static ulong IetfNsecbytes()
        {
            var __ret = __Internal.IetfNsecbytes();
            return __ret;
        }

        public static ulong IetfNpubbytes()
        {
            var __ret = __Internal.IetfNpubbytes();
            return __ret;
        }

        public static ulong IetfAbytes()
        {
            var __ret = __Internal.IetfAbytes();
            return __ret;
        }

        public static ulong IetfMessagebytesMax()
        {
            var __ret = __Internal.IetfMessagebytesMax();
            return __ret;
        }

        public static int IetfEncrypt(byte[] c, ref ulong clen_p, byte[] m, ulong mlen, byte[] ad, ulong adlen, byte[] nsec, byte[] npub, byte[] k)
        {
            fixed (ulong* __refParamPtr1 = &clen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.IetfEncrypt(MarshalHelper.ByteArrayToIntPtr(c), __arg1, MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(ad), adlen,
                    MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(npub), MarshalHelper.ByteArrayToIntPtr(k));
                return __ret;
            }
        }

        public static int IetfDecrypt(byte[] m, ref ulong mlen_p, byte[] nsec, byte[] c, ulong clen, byte[] ad, ulong adlen, byte[] npub, byte[] k)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.IetfDecrypt(MarshalHelper.ByteArrayToIntPtr(m), __arg1, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(c), 
                    clen, MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(npub), MarshalHelper.ByteArrayToIntPtr(k));
                return __ret;
            }
        }

        public static int IetfEncryptDetached(byte[] c, byte[] mac, ref ulong maclen_p, byte[] m, ulong mlen, byte[] ad, ulong adlen, byte[] nsec, byte[] npub, byte[] k)
        {
            fixed (ulong* __refParamPtr2 = &maclen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.IetfEncryptDetached(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), __arg2, MarshalHelper.ByteArrayToIntPtr(m), 
                    mlen, MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(npub), MarshalHelper.ByteArrayToIntPtr(k));
                return __ret;
            }
        }

        public static int IetfDecryptDetached(byte[] m, byte[] nsec, byte[] c, ulong clen, byte[] mac, byte[] ad, ulong adlen, byte[] npub, byte[] k)
        {
            var __ret = __Internal.IetfDecryptDetached(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(mac),
                MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(npub), MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static void IetfKeygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.IetfKeygen(k);
        }
    }
}
