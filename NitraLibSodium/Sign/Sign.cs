using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Sign
{
    public unsafe partial class Sign
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_seedbytes")]
            internal static extern ulong Seedbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_publickeybytes")]
            internal static extern ulong Publickeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_secretkeybytes")]
            internal static extern ulong Secretkeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_messagebytes_max")]
            internal static extern ulong MessagebytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_seed_keypair")]
            internal static extern int SeedKeypair(byte* pk, byte* sk, byte* seed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_keypair")]
            internal static extern int Keypair(byte* pk, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign")]
            internal static extern int Sign(byte* sm, ulong* smlen_p, byte* m, ulong mlen, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_open")]
            internal static extern int Open(byte* m, ulong* mlen_p, byte* sm, ulong smlen, byte* pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_detached")]
            internal static extern int Detached(byte* sig, ulong* siglen_p, byte* m, ulong mlen, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_verify_detached")]
            internal static extern int VerifyDetached(byte* sig, byte* m, ulong mlen, byte* pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_init")]
            internal static extern int Init(global::System.IntPtr state);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_update")]
            internal static extern int Update(global::System.IntPtr state, byte* m, ulong mlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_final_create")]
            internal static extern int FinalCreate(global::System.IntPtr state, byte* sig, ulong* siglen_p, byte* sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_sign_final_verify")]
            internal static extern int FinalVerify(global::System.IntPtr state, byte* sig, byte* pk);
        }

        public static ulong Statebytes()
        {
            var __ret = __Internal.Statebytes();
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

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int SeedKeypair(byte* pk, byte* sk, byte* seed)
        {
            var __ret = __Internal.SeedKeypair(pk, sk, seed);
            return __ret;
        }

        public static int Keypair(byte* pk, byte* sk)
        {
            var __ret = __Internal.Keypair(pk, sk);
            return __ret;
        }

        public static int CryptoSign(byte* sm, ref ulong smlen_p, byte* m, ulong mlen, byte* sk)
        {
            fixed (ulong* __refParamPtr1 = &smlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Sign(sm, __arg1, m, mlen, sk);
                return __ret;
            }
        }

        public static int Open(byte* m, ref ulong mlen_p, byte* sm, ulong smlen, byte* pk)
        {
            fixed (ulong* __refParamPtr1 = &mlen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Open(m, __arg1, sm, smlen, pk);
                return __ret;
            }
        }

        public static int Detached(byte* sig, ref ulong siglen_p, byte* m, ulong mlen, byte* sk)
        {
            fixed (ulong* __refParamPtr1 = &siglen_p)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.Detached(sig, __arg1, m, mlen, sk);
                return __ret;
            }
        }

        public static int VerifyDetached(byte* sig, byte* m, ulong mlen, byte* pk)
        {
            var __ret = __Internal.VerifyDetached(sig, m, mlen, pk);
            return __ret;
        }

        public static int Init(global::NitraLibSodium.Sign.Ed25519phState state)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0);
            return __ret;
        }

        public static int Update(global::NitraLibSodium.Sign.Ed25519phState state, byte* m, ulong mlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Update(__arg0, m, mlen);
            return __ret;
        }

        public static int FinalCreate(global::NitraLibSodium.Sign.Ed25519phState state, byte* sig, ref ulong siglen_p, byte* sk)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            fixed (ulong* __refParamPtr2 = &siglen_p)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.FinalCreate(__arg0, sig, __arg2, sk);
                return __ret;
            }
        }

        public static int FinalVerify(global::NitraLibSodium.Sign.Ed25519phState state, byte* sig, byte* pk)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.FinalVerify(__arg0, sig, pk);
            return __ret;
        }
    }
}
