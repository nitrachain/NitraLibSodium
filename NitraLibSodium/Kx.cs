using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium
{
    public unsafe partial class Kx
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_publickeybytes")]
            internal static extern ulong KxPublickeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_secretkeybytes")]
            internal static extern ulong KxSecretkeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_seedbytes")]
            internal static extern ulong KxSeedbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_sessionkeybytes")]
            internal static extern ulong KxSessionkeybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_primitive")]
            internal static extern global::System.IntPtr KxPrimitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_seed_keypair")]
            internal static extern int KxSeedKeypair(byte[] pk, byte[] sk, byte[] seed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_keypair")]
            internal static extern int KxKeypair(byte[] pk, byte[] sk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_client_session_keys")]
            internal static extern int KxClientSessionKeys(byte[] rx, byte[] tx, byte[] client_pk, byte[] client_sk, byte[] server_pk);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kx_server_session_keys")]
            internal static extern int KxServerSessionKeys(byte[] rx, byte[] tx, byte[] server_pk, byte[] server_sk, byte[] client_pk);
        }

        public static ulong KxPublickeybytes()
        {
            var __ret = __Internal.KxPublickeybytes();
            return __ret;
        }

        public static ulong KxSecretkeybytes()
        {
            var __ret = __Internal.KxSecretkeybytes();
            return __ret;
        }

        public static ulong KxSeedbytes()
        {
            var __ret = __Internal.KxSeedbytes();
            return __ret;
        }

        public static ulong KxSessionkeybytes()
        {
            var __ret = __Internal.KxSessionkeybytes();
            return __ret;
        }

        public static string KxPrimitive()
        {
            var __ret = __Internal.KxPrimitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int KxSeedKeypair(byte[] pk, byte[] sk, byte[] seed)
        {
            if (pk == null || pk.Length != 32)
                throw new ArgumentOutOfRangeException("pk", "The dimensions of the provided array don't match the required size.");
            if (sk == null || sk.Length != 32)
                throw new ArgumentOutOfRangeException("sk", "The dimensions of the provided array don't match the required size.");
            if (seed == null || seed.Length != 32)
                throw new ArgumentOutOfRangeException("seed", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.KxSeedKeypair(pk, sk, seed);
            return __ret;
        }

        public static int KxKeypair(byte[] pk, byte[] sk)
        {
            if (pk == null || pk.Length != 32)
                throw new ArgumentOutOfRangeException("pk", "The dimensions of the provided array don't match the required size.");
            if (sk == null || sk.Length != 32)
                throw new ArgumentOutOfRangeException("sk", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.KxKeypair(pk, sk);
            return __ret;
        }

        public static int KxClientSessionKeys(byte[] rx, byte[] tx, byte[] client_pk, byte[] client_sk, byte[] server_pk)
        {
            if (rx == null || rx.Length != 32)
                throw new ArgumentOutOfRangeException("rx", "The dimensions of the provided array don't match the required size.");
            if (tx == null || tx.Length != 32)
                throw new ArgumentOutOfRangeException("tx", "The dimensions of the provided array don't match the required size.");
            if (client_pk == null || client_pk.Length != 32)
                throw new ArgumentOutOfRangeException("client_pk", "The dimensions of the provided array don't match the required size.");
            if (client_sk == null || client_sk.Length != 32)
                throw new ArgumentOutOfRangeException("client_sk", "The dimensions of the provided array don't match the required size.");
            if (server_pk == null || server_pk.Length != 32)
                throw new ArgumentOutOfRangeException("server_pk", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.KxClientSessionKeys(rx, tx, client_pk, client_sk, server_pk);
            return __ret;
        }

        public static int KxServerSessionKeys(byte[] rx, byte[] tx, byte[] server_pk, byte[] server_sk, byte[] client_pk)
        {
            if (rx == null || rx.Length != 32)
                throw new ArgumentOutOfRangeException("rx", "The dimensions of the provided array don't match the required size.");
            if (tx == null || tx.Length != 32)
                throw new ArgumentOutOfRangeException("tx", "The dimensions of the provided array don't match the required size.");
            if (server_pk == null || server_pk.Length != 32)
                throw new ArgumentOutOfRangeException("server_pk", "The dimensions of the provided array don't match the required size.");
            if (server_sk == null || server_sk.Length != 32)
                throw new ArgumentOutOfRangeException("server_sk", "The dimensions of the provided array don't match the required size.");
            if (client_pk == null || client_pk.Length != 32)
                throw new ArgumentOutOfRangeException("client_pk", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.KxServerSessionKeys(rx, tx, server_pk, server_sk, client_pk);
            return __ret;
        }
    }
}
