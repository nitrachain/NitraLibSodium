using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Hash
{
    public unsafe partial class Sha256
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha256_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha256_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha256")]
            internal static extern int Sha256(byte* @out, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha256_init")]
            internal static extern int Init(global::System.IntPtr state);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha256_update")]
            internal static extern int Update(global::System.IntPtr state, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha256_final")]
            internal static extern int Final(global::System.IntPtr state, byte* @out);
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

        public static int CryptoSha256(byte[] @out, byte[] @in, ulong inlen)
        {
            var __ret = __Internal.Sha256(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), inlen);
            return __ret;
        }

        public static int Init(global::NitraLibSodium.Hash.Sha256State state)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0);
            return __ret;
        }

        public static int Update(global::NitraLibSodium.Hash.Sha256State state, byte[] @in, ulong inlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Update(__arg0, MarshalHelper.ByteArrayToIntPtr(@in), inlen);
            return __ret;
        }

        public static int Final(global::NitraLibSodium.Hash.Sha256State state, byte[] @out)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Final(__arg0, MarshalHelper.ByteArrayToIntPtr(@out));
            return __ret;
        }
    }
}
