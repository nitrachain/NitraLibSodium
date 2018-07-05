using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Aead
{
    public unsafe partial class Aes256gcm
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_is_available")]
            internal static extern int IsAvailable();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_nsecbytes")]
            internal static extern ulong Nsecbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_npubbytes")]
            internal static extern ulong Npubbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_abytes")]
            internal static extern ulong Abytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_encrypt")]
            internal static extern int Encrypt(byte* c, ulong* clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_decrypt")]
            internal static extern int Decrypt(byte* m, ulong* mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_encrypt_detached")]
            internal static extern int EncryptDetached(byte* c, byte* mac, ulong* maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_decrypt_detached")]
            internal static extern int DecryptDetached(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_beforenm")]
            internal static extern int Beforenm(byte[] ctx_, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_encrypt_afternm")]
            internal static extern int EncryptAfternm(byte* c, ulong* clen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte[] ctx_);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_decrypt_afternm")]
            internal static extern int DecryptAfternm(byte* m, ulong* mlen_p, byte* nsec, byte* c, ulong clen, byte* ad, ulong adlen, byte* npub, byte[] ctx_);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_encrypt_detached_afternm")]
            internal static extern int EncryptDetachedAfternm(byte* c, byte* mac, ulong* maclen_p, byte* m, ulong mlen, byte* ad, ulong adlen, byte* nsec, byte* npub, byte[] ctx_);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_decrypt_detached_afternm")]
            internal static extern int DecryptDetachedAfternm(byte* m, byte* nsec, byte* c, ulong clen, byte* mac, byte* ad, ulong adlen, byte* npub, byte[] ctx_);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_aead_aes256gcm_keygen")]
            internal static extern void Keygen(byte[] k);
        }

        public static int IsAvailable()
        {
            var __ret = __Internal.IsAvailable();
            return __ret;
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

        public static ulong Statebytes()
        {
            var __ret = __Internal.Statebytes();
            return __ret;
        }

        public static int Encrypt(byte[] c, ref ulong clen_p, byte[] m, ulong mlen, byte[] ad, ulong adlen, byte[] nsec, byte[] npub, byte[] k)
        {
            fixed (ulong* __refParamPtr1 = &clen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Encrypt(MarshalHelper.ByteArrayToIntPtr(c), __arg1, MarshalHelper.ByteArrayToIntPtr(m), 
                    mlen, MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(nsec), 
                    MarshalHelper.ByteArrayToIntPtr(npub), MarshalHelper.ByteArrayToIntPtr(k));
                return __ret;
            }
        }

        public static int Decrypt(byte[] m, ref ulong mlen_p, byte[] nsec, byte[] c, ulong clen, byte[] ad, ulong adlen, byte[] npub, byte[] k)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Decrypt(MarshalHelper.ByteArrayToIntPtr(m), __arg1, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(c), 
                    clen, MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(npub), MarshalHelper.ByteArrayToIntPtr(k));
                return __ret;
            }
        }

        public static int EncryptDetached(byte[] c, byte[] mac, ref ulong maclen_p, byte[] m, ulong mlen, byte[] ad, ulong adlen, byte[] nsec, byte[] npub, byte[] k)
        {
            fixed (ulong* __refParamPtr2 = &maclen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.EncryptDetached(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), __arg2, MarshalHelper.ByteArrayToIntPtr(m), 
                    mlen, MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(npub), 
                    MarshalHelper.ByteArrayToIntPtr(k));
                return __ret;
            }
        }

        public static int DecryptDetached(byte[] m, byte[] nsec, byte[] c, ulong clen, byte[] mac, byte[] ad, ulong adlen, byte[] npub, byte[] k)
        {
            var __ret = __Internal.DecryptDetached(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(c), 
                clen, MarshalHelper.ByteArrayToIntPtr(mac), MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(npub), 
                MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int Beforenm(byte[] ctx_, byte[] k)
        {
            if (ctx_ == null || ctx_.Length != 512)
                throw new ArgumentOutOfRangeException("ctx_", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.Beforenm(ctx_, MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int EncryptAfternm(byte[] c, ref ulong clen_p, byte[] m, ulong mlen, byte[] ad, ulong adlen, byte[] nsec, byte[] npub, byte[] ctx_)
        {
            fixed (ulong* __refParamPtr1 = &clen_p)
            {
                var __arg1 = __refParamPtr1;
                if (ctx_ == null || ctx_.Length != 512)
                    throw new ArgumentOutOfRangeException("ctx_", "The dimensions of the provided array don't match the required size.");
                var __ret = __Internal.EncryptAfternm(MarshalHelper.ByteArrayToIntPtr(c), __arg1, MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(ad), 
                    adlen, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(npub), ctx_);
                return __ret;
            }
        }

        public static int DecryptAfternm(byte[] m, ref ulong mlen_p, byte[] nsec, byte[] c, ulong clen, byte[] ad, ulong adlen, byte[] npub, byte[] ctx_)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                if (ctx_ == null || ctx_.Length != 512)
                    throw new ArgumentOutOfRangeException("ctx_", "The dimensions of the provided array don't match the required size.");
                var __ret = __Internal.DecryptAfternm(MarshalHelper.ByteArrayToIntPtr(m), __arg1, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(c), 
                    clen, MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(npub), ctx_);
                return __ret;
            }
        }

        public static int EncryptDetachedAfternm(byte[] c, byte[] mac, ref ulong maclen_p, byte[] m, ulong mlen, byte[] ad, ulong adlen, byte[] nsec, byte[] npub, byte[] ctx_)
        {
            fixed (ulong* __refParamPtr2 = &maclen_p)
            {
                var __arg2 = __refParamPtr2;
                if (ctx_ == null || ctx_.Length != 512)
                    throw new ArgumentOutOfRangeException("ctx_", "The dimensions of the provided array don't match the required size.");
                var __ret = __Internal.EncryptDetachedAfternm(MarshalHelper.ByteArrayToIntPtr(c), MarshalHelper.ByteArrayToIntPtr(mac), __arg2, MarshalHelper.ByteArrayToIntPtr(m), mlen,
                    MarshalHelper.ByteArrayToIntPtr(ad), adlen, MarshalHelper.ByteArrayToIntPtr(nsec), MarshalHelper.ByteArrayToIntPtr(npub), ctx_);
                return __ret;
            }
        }

        public static int DecryptDetachedAfternm(byte[] m, byte[] nsec, byte[] c, ulong clen, byte[] mac, byte[] ad, ulong adlen, byte[] npub, byte[] ctx_)
        {
            if (ctx_ == null || ctx_.Length != 512)
                throw new ArgumentOutOfRangeException("ctx_", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.DecryptDetachedAfternm(MarshalHelper.ByteArrayToIntPtr(m), MarshalHelper.ByteArrayToIntPtr(nsec),
                MarshalHelper.ByteArrayToIntPtr(c), clen, MarshalHelper.ByteArrayToIntPtr(mac), MarshalHelper.ByteArrayToIntPtr(ad), adlen, 
                MarshalHelper.ByteArrayToIntPtr(npub), ctx_);
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
