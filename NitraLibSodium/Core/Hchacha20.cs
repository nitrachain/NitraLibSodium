using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Core
{
    public unsafe partial class Hchacha20
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hchacha20_outputbytes")]
            internal static extern ulong Outputbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hchacha20_inputbytes")]
            internal static extern ulong Inputbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hchacha20_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hchacha20_constbytes")]
            internal static extern ulong Constbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_core_hchacha20")]
            internal static extern int Hchacha20(byte* @out, byte* @in, byte* k, byte* c);
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

        public static int CryptoHchacha20(byte* @out, byte* @in, byte* k, byte* c)
        {
            var __ret = __Internal.Hchacha20(@out, @in, k, c);
            return __ret;
        }
    }
}
