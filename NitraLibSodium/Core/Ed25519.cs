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
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_uniformbytes")]
            internal static extern ulong Uniformbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_is_valid_point")]
            internal static extern int IsValidPoint(byte* p);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_add")]
            internal static extern int Add(byte* r, byte* p, byte* q);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_ed25519_sub")]
            internal static extern int Sub(byte* r, byte* p, byte* q);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
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

        public static int IsValidPoint(byte[] p)
        {
            var __ret = __Internal.IsValidPoint(MarshalHelper.ByteArrayToIntPtr(p));
            return __ret;
        }

        public static int Add(byte[] r, byte[] p, byte[] q)
        {
            var __ret = __Internal.Add(MarshalHelper.ByteArrayToIntPtr(r), MarshalHelper.ByteArrayToIntPtr(p), MarshalHelper.ByteArrayToIntPtr(q));
            return __ret;
        }

        public static int Sub(byte[] r, byte[] p, byte[] q)
        {
            var __ret = __Internal.Sub(MarshalHelper.ByteArrayToIntPtr(r), MarshalHelper.ByteArrayToIntPtr(p), MarshalHelper.ByteArrayToIntPtr(q));
            return __ret;
        }

        public static int FromUniform(byte[] p, byte[] r)
        {
            var __ret = __Internal.FromUniform(MarshalHelper.ByteArrayToIntPtr(p), MarshalHelper.ByteArrayToIntPtr(r));
            return __ret;
        }
    }
}
