using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Core
{
    public unsafe partial class Ed25519
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_uniformbytes")]
            internal static extern ulong Uniformbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_is_valid_point")]
            internal static extern int IsValidPoint(byte* p);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_add")]
            internal static extern int Add(byte* r, byte* p, byte* q);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_sub")]
            internal static extern int Sub(byte* r, byte* p, byte* q);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_from_uniform")]
            internal static extern int FromUniform(byte* p, byte* r);
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static ulong Uniformbytes()
        {
            var __ret = __Internal.Uniformbytes();
            return __ret;
        }

        public static int IsValidPoint(byte* p)
        {
            var __ret = __Internal.IsValidPoint(p);
            return __ret;
        }

        public static int Add(byte* r, byte* p, byte* q)
        {
            var __ret = __Internal.Add(r, p, q);
            return __ret;
        }

        public static int Sub(byte* r, byte* p, byte* q)
        {
            var __ret = __Internal.Sub(r, p, q);
            return __ret;
        }

        public static int FromUniform(byte* p, byte* r)
        {
            var __ret = __Internal.FromUniform(p, r);
            return __ret;
        }
    }
}
