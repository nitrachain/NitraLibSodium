using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Auth
{
    public unsafe partial class HmacSha256
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256")]
            internal static extern int AuthHmacsha256(byte* @out, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_verify")]
            internal static extern int Verify(byte* h, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_init")]
            internal static extern int Init(global::System.IntPtr state, byte* key, ulong keylen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_update")]
            internal static extern int Update(global::System.IntPtr state, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_final")]
            internal static extern int Final(global::System.IntPtr state, byte* @out);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha256_keygen")]
            internal static extern void Keygen(byte[] k);
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static int AuthHmacsha256(byte[] @out, byte[] @in, ulong inlen, byte[] k)
        {
            var __ret = __Internal.AuthHmacsha256(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static int Verify(byte[] h, byte[] @in, ulong inlen, byte[] k)
        {
            var __ret = __Internal.Verify(MarshalHelper.ByteArrayToIntPtr(h), MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(k));
            return __ret;
        }

        public static ulong Statebytes()
        {
            var __ret = __Internal.Statebytes();
            return __ret;
        }

        public static int Init(global::NitraLibSodium.Auth.HmacSha256State state, byte[] key, ulong keylen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0, MarshalHelper.ByteArrayToIntPtr(key), keylen);
            return __ret;
        }

        public static int Update(global::NitraLibSodium.Auth.HmacSha256State state, byte[] @in, ulong inlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Update(__arg0, MarshalHelper.ByteArrayToIntPtr(@in), inlen);
            return __ret;
        }

        public static int Final(global::NitraLibSodium.Auth.HmacSha256State state, byte[] @out)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Final(__arg0, MarshalHelper.ByteArrayToIntPtr(@out));
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
