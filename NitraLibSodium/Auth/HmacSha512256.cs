using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Auth
{
    public unsafe partial class HmacSha512256
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256")]
            internal static extern int AuthHmacsha512256(byte* @out, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_verify")]
            internal static extern int Verify(byte* h, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_init")]
            internal static extern int Init(global::System.IntPtr state, byte* key, ulong keylen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_update")]
            internal static extern int Update(global::System.IntPtr state, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_final")]
            internal static extern int Final(global::System.IntPtr state, byte* @out);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_auth_hmacsha512256_keygen")]
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

        public static int CryptoAuthHmacsha512256(byte* @out, byte* @in, ulong inlen, byte* k)
        {
            var __ret = __Internal.AuthHmacsha512256(@out, @in, inlen, k);
            return __ret;
        }

        public static int Verify(byte* h, byte* @in, ulong inlen, byte* k)
        {
            var __ret = __Internal.Verify(h, @in, inlen, k);
            return __ret;
        }

        public static ulong Statebytes()
        {
            var __ret = __Internal.Statebytes();
            return __ret;
        }

        public static int Init(global::NitraLibSodium.Auth.HmacSha512State state, byte* key, ulong keylen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0, key, keylen);
            return __ret;
        }

        public static int Update(global::NitraLibSodium.Auth.HmacSha512State state, byte* @in, ulong inlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Update(__arg0, @in, inlen);
            return __ret;
        }

        public static int Final(global::NitraLibSodium.Auth.HmacSha512State state, byte* @out)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Final(__arg0, @out);
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
