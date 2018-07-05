using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Core
{
    public unsafe partial class Hsalsa20
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hsalsa20_outputbytes")]
            internal static extern ulong Outputbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hsalsa20_inputbytes")]
            internal static extern ulong Inputbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hsalsa20_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hsalsa20_constbytes")]
            internal static extern ulong Constbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hsalsa20")]
            internal static extern int Hsalsa20(byte* @out, byte* @in, byte* k, byte* c);
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

        public static int CryptoHsalsa20(byte[] @out, byte[] @in, byte[] k, byte[] c)
        {
            var __ret = __Internal.Hsalsa20(MarshalHelper.ByteArrayToIntPtr(@out), MarshalHelper.ByteArrayToIntPtr(@in), MarshalHelper.ByteArrayToIntPtr(k), MarshalHelper.ByteArrayToIntPtr(c));
            return __ret;
        }
    }
}
