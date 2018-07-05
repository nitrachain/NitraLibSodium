using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Hash
{
    public unsafe partial class Sha512
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha512_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha512_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha512")]
            internal static extern int Sha512(byte* @out, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha512_init")]
            internal static extern int Init(global::System.IntPtr state);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha512_update")]
            internal static extern int Update(global::System.IntPtr state, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_hash_sha512_final")]
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

        public static int CryptoSha512(byte[] @out, byte[] @in, ulong inLength)
        {
            var __ret = __Internal.Sha512(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), (ulong)@in.Length);
            return __ret;
        }

        public static int Init(global::NitraLibSodium.Hash.Sha512State state)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0);
            return __ret;
        }

        public static int Update(global::NitraLibSodium.Hash.Sha512State state, byte[] @in, ulong inlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            int __ret = __Internal.Update(__arg0, MarshalHelper.ByteArrayToIntPtr(@in), inlen);
            return __ret;
        }

        public static int Final(global::NitraLibSodium.Hash.Sha512State state, out byte[] @out)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            int __ret;
            fixed (byte* _out = @out)
            {
                __ret = __Internal.Final(__arg0, _out);
                Marshal.Copy((IntPtr)_out, @out, 0, @out.Length);
            }
            return __ret;
        }
    }
}
