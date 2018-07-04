using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium
{
    public unsafe partial class Version
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_version_string")]
            internal static extern global::System.IntPtr SodiumVersionString();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_library_version_major")]
            internal static extern int SodiumLibraryVersionMajor();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_library_version_minor")]
            internal static extern int SodiumLibraryVersionMinor();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_library_minimal")]
            internal static extern int SodiumLibraryMinimal();
        }

        public static string SodiumVersionString()
        {
            var __ret = __Internal.SodiumVersionString();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int SodiumLibraryVersionMajor()
        {
            var __ret = __Internal.SodiumLibraryVersionMajor();
            return __ret;
        }

        public static int SodiumLibraryVersionMinor()
        {
            var __ret = __Internal.SodiumLibraryVersionMinor();
            return __ret;
        }

        public static int SodiumLibraryMinimal()
        {
            var __ret = __Internal.SodiumLibraryMinimal();
            return __ret;
        }
    }
}
