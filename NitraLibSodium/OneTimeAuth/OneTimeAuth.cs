using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.OneTimeAuth
{
    public unsafe partial class OneTimeAuth
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth")]
            internal static extern int Onetimeauth(byte* @out, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_verify")]
            internal static extern int Verify(byte* h, byte* @in, ulong inlen, byte* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_init")]
            internal static extern int Init(global::System.IntPtr state, byte* key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_update")]
            internal static extern int Update(global::System.IntPtr state, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_final")]
            internal static extern int Final(global::System.IntPtr state, byte* @out);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_onetimeauth_keygen")]
            internal static extern void Keygen(byte[] k);
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

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int CryptoOnetimeauth(byte* @out, byte* @in, ulong inlen, byte* k)
        {
            var __ret = __Internal.Onetimeauth(@out, @in, inlen, k);
            return __ret;
        }

        public static int Verify(byte* h, byte* @in, ulong inlen, byte* k)
        {
            var __ret = __Internal.Verify(h, @in, inlen, k);
            return __ret;
        }

        public static int Init(global::NitraLibSodium.OneTimeAuth.Poly1305State state, byte* key)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0, key);
            return __ret;
        }

        public static int Update(global::NitraLibSodium.OneTimeAuth.Poly1305State state, byte* @in, ulong inlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Update(__arg0, @in, inlen);
            return __ret;
        }

        public static int Final(global::NitraLibSodium.OneTimeAuth.Poly1305State state, byte* @out)
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
