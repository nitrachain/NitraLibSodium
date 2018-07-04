using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Aead
{
    public unsafe partial class Chacha20poly1305
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_keybytes")]
            internal static extern ulong IetfKeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_nsecbytes")]
            internal static extern ulong IetfNsecbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_npubbytes")]
            internal static extern ulong IetfNpubbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_abytes")]
            internal static extern ulong IetfAbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_messagebytes_max")]
            internal static extern ulong IetfMessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_encrypt")]
            internal static extern int IetfEncrypt(byte* c, ulong* clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_decrypt")]
            internal static extern int IetfDecrypt(byte* m, ulong* mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_encrypt_detached")]
            internal static extern int IetfEncryptDetached(byte* c, byte* mac, ulong* maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_decrypt_detached")]
            internal static extern int IetfDecryptDetached(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_ietf_keygen")]
            internal static extern void IetfKeygen(byte[] k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_nsecbytes")]
            internal static extern ulong Nsecbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_npubbytes")]
            internal static extern ulong Npubbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_abytes")]
            internal static extern ulong Abytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_encrypt")]
            internal static extern int Encrypt(byte* c, ulong* clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_decrypt")]
            internal static extern int Decrypt(byte* m, ulong* mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_encrypt_detached")]
            internal static extern int EncryptDetached(byte* c, byte* mac, ulong* maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_decrypt_detached")]
            internal static extern int DecryptDetached(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_chacha20poly1305_keygen")]
            internal static extern void Keygen(byte[] k);
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

        public static int IetfEncrypt(byte* c, ref ulong clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k)
        {
            fixed (ulong* __refParamPtr1 = &clen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.IetfEncrypt(c, __arg1, m, mlen, ad, adlen, nsec, npub, k);
                return __ret;
            }
        }

        public static int IetfDecrypt(byte* m, ref ulong mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte* k)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.IetfDecrypt(m, __arg1, nsec, c, clen, ad, adlen, npub, k);
                return __ret;
            }
        }

        public static int IetfEncryptDetached(byte* c, byte* mac, ref ulong maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k)
        {
            fixed (ulong* __refParamPtr2 = &maclen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.IetfEncryptDetached(c, mac, __arg2, m, mlen, ad, adlen, nsec, npub, k);
                return __ret;
            }
        }

        public static int IetfDecryptDetached(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte* k)
        {
            var __ret = __Internal.IetfDecryptDetached(m, nsec, c, clen, mac, ad, adlen, npub, k);
            return __ret;
        }

        public static void IetfKeygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.IetfKeygen(k);
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static ulong Nsecbytes()
        {
            var __ret = __Internal.Nsecbytes();
            return __ret;
        }

        public static ulong Npubbytes()
        {
            var __ret = __Internal.Npubbytes();
            return __ret;
        }

        public static ulong Abytes()
        {
            var __ret = __Internal.Abytes();
            return __ret;
        }

        public static ulong MessagebytesMax()
        {
            var __ret = __Internal.MessagebytesMax();
            return __ret;
        }

        public static int Encrypt(byte* c, ref ulong clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k)
        {
            fixed (ulong* __refParamPtr1 = &clen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Encrypt(c, __arg1, m, mlen, ad, adlen, nsec, npub, k);
                return __ret;
            }
        }

        public static int Decrypt(byte* m, ref ulong mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte* k)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Decrypt(m, __arg1, nsec, c, clen, ad, adlen, npub, k);
                return __ret;
            }
        }

        public static int EncryptDetached(byte* c, byte* mac, ref ulong maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k)
        {
            fixed (ulong* __refParamPtr2 = &maclen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.EncryptDetached(c, mac, __arg2, m, mlen, ad, adlen, nsec, npub, k);
                return __ret;
            }
        }

        public static int DecryptDetached(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte* k)
        {
            var __ret = __Internal.DecryptDetached(m, nsec, c, clen, mac, ad, adlen, npub, k);
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
