using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Sign
{
    public unsafe partial class Ed25519
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519ph_statebytes")]
            internal static extern ulong PhStatebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_seedbytes")]
            internal static extern ulong Seedbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_publickeybytes")]
            internal static extern ulong Publickeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_secretkeybytes")]
            internal static extern ulong Secretkeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519")]
            internal static extern int Ed25519(byte* sm, ulong* smlen_p, byte* m, ulong mlen, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_open")]
            internal static extern int Open(byte* m, ulong* mlen_p, byte* sm, ulong smlen, byte* pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_detached")]
            internal static extern int Detached(byte* sig, ulong* siglen_p, byte* m, ulong mlen, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_verify_detached")]
            internal static extern int VerifyDetached(byte* sig, byte* m, ulong mlen, byte* pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_keypair")]
            internal static extern int Keypair(byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_seed_keypair")]
            internal static extern int SeedKeypair(byte* pk, byte* sk, byte* seed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_pk_to_curve25519")]
            internal static extern int PkToCurve25519(byte* curve25519_pk, byte* ed25519_pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_sk_to_curve25519")]
            internal static extern int SkToCurve25519(byte* curve25519_sk, byte* ed25519_sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_sk_to_seed")]
            internal static extern int SkToSeed(byte* seed, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519_sk_to_pk")]
            internal static extern int SkToPk(byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519ph_init")]
            internal static extern int PhInit(global::System.IntPtr state);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519ph_update")]
            internal static extern int PhUpdate(global::System.IntPtr state, byte* m, ulong mlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519ph_final_create")]
            internal static extern int PhFinalCreate(global::System.IntPtr state, byte* sig, ulong* siglen_p, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_ed25519ph_final_verify")]
            internal static extern int PhFinalVerify(global::System.IntPtr state, byte* sig, byte* pk);
        }

        public static ulong PhStatebytes()
        {
            var __ret = __Internal.PhStatebytes();
            return __ret;
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
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

        public static ulong MessagebytesMax()
        {
            var __ret = __Internal.MessagebytesMax();
            return __ret;
        }

        public static int CryptoEd25519(byte[] sm, ref ulong smlen_p, byte[] m, ulong mlen, byte[] sk)
        {
            fixed (ulong* __refParamPtr1 = &smlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Ed25519(MarshalHelper.ByteArrayToIntPtr(sm), __arg1, MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(sk));
                return __ret;
            }
        }

        public static int Open(byte[] m, ref ulong mlen_p, byte[] sm, ulong smlen, byte[] pk)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Open(MarshalHelper.ByteArrayToIntPtr(m), __arg1, MarshalHelper.ByteArrayToIntPtr(sm), smlen, MarshalHelper.ByteArrayToIntPtr(pk));
                return __ret;
            }
        }

        public static int Detached(byte[] sig, ref ulong siglen_p, byte[] m, ulong mlen, byte[] sk)
        {
            fixed (ulong* __refParamPtr1 = &siglen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Detached(MarshalHelper.ByteArrayToIntPtr(sig), __arg1, MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(sk));
                return __ret;
            }
        }

        public static int VerifyDetached(byte[] sig, byte[] m, ulong mlen, byte[] pk)
        {
            var __ret = __Internal.VerifyDetached(MarshalHelper.ByteArrayToIntPtr(sig), MarshalHelper.ByteArrayToIntPtr(m), mlen, MarshalHelper.ByteArrayToIntPtr(pk));
            return __ret;
        }

        public static int Keypair(byte[] pk, byte[] sk)
        {
            var __ret = __Internal.Keypair(MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int SeedKeypair(byte[] pk, byte[] sk, byte[] seed)
        {
            var __ret = __Internal.SeedKeypair(MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk), MarshalHelper.ByteArrayToIntPtr(seed));
            return __ret;
        }

        public static int PkToCurve25519(byte[] curve25519_pk, byte[] ed25519_pk)
        {
            var __ret = __Internal.PkToCurve25519(MarshalHelper.ByteArrayToIntPtr(curve25519_pk), MarshalHelper.ByteArrayToIntPtr(ed25519_pk));
            return __ret;
        }

        public static int SkToCurve25519(byte[] curve25519_sk, byte[] ed25519_sk)
        {
            var __ret = __Internal.SkToCurve25519(MarshalHelper.ByteArrayToIntPtr(curve25519_sk), MarshalHelper.ByteArrayToIntPtr(ed25519_sk));
            return __ret;
        }

        public static int SkToSeed(byte[] seed, byte[] sk)
        {
            var __ret = __Internal.SkToSeed(MarshalHelper.ByteArrayToIntPtr(seed), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int SkToPk(byte[] pk, byte[] sk)
        {
            var __ret = __Internal.SkToPk(MarshalHelper.ByteArrayToIntPtr(pk), MarshalHelper.ByteArrayToIntPtr(sk));
            return __ret;
        }

        public static int PhInit(global::NitraLibSodium.Sign.Ed25519phState state)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.PhInit(__arg0);
            return __ret;
        }

        public static int PhUpdate(global::NitraLibSodium.Sign.Ed25519phState state, byte[] m, ulong mlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.PhUpdate(__arg0, MarshalHelper.ByteArrayToIntPtr(m), mlen);
            return __ret;
        }

        public static int PhFinalCreate(global::NitraLibSodium.Sign.Ed25519phState state, byte[] sig, ref ulong siglen_p, byte[] sk)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            fixed (ulong* __refParamPtr2 = &siglen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.PhFinalCreate(__arg0, MarshalHelper.ByteArrayToIntPtr(sig), __arg2, MarshalHelper.ByteArrayToIntPtr(sk));
                return __ret;
            }
        }

        public static int PhFinalVerify(global::NitraLibSodium.Sign.Ed25519phState state, byte[] sig, byte[] pk)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.PhFinalVerify(__arg0, MarshalHelper.ByteArrayToIntPtr(sig), MarshalHelper.ByteArrayToIntPtr(pk));
            return __ret;
        }
    }
}
