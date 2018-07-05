using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Core
{
    public unsafe partial class Core
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_init")]
            internal static extern int SodiumInit();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_set_misuse_handler")]
            internal static extern int SodiumSetMisuseHandler(global::System.IntPtr handler);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_misuse")]
            internal static extern void SodiumMisuse();
        }

        public static int SodiumInit()
        {
            var __ret = __Internal.SodiumInit();
            return __ret;
        }

        public static int SodiumSetMisuseHandler(global::NitraLibSodium.Core.Delegates.Action_ handler)
        {
            var __arg0 = handler == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(handler);
            var __ret = __Internal.SodiumSetMisuseHandler(__arg0);
            return __ret;
        }

        public static void SodiumMisuse()
        {
            __Internal.SodiumMisuse();
        }
    }

    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate void Action_();
    }
}


