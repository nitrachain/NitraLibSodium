using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Core
{
    public unsafe partial class Salsa2012
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_salsa2012_outputbytes")]
            internal static extern ulong Outputbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_salsa2012_inputbytes")]
            internal static extern ulong Inputbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_salsa2012_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_salsa2012_constbytes")]
            internal static extern ulong Constbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_salsa2012")]
            internal static extern int Salsa2012(byte* @out, byte* @in, byte* k, byte* c);
        }

        public static ulong Outputbytes()
        {
            var __ret = __Internal.Outputbytes();
            return __ret;
        }

        public static ulong Inputbytes()
        {
            var __ret = __Internal.Inputbytes();
            return __ret;
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static ulong Constbytes()
        {
            var __ret = __Internal.Constbytes();
            return __ret;
        }

        public static int CryptoSalsa2012(byte[] @out, byte[] @in, byte[] k, byte[] c)
        {
            var __ret = __Internal.Salsa2012(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), MarshalHelper.ByteArrayToIntPtr(k), MarshalHelper.ByteArrayToIntPtr(c));
            return __ret;
        }
    }
}
