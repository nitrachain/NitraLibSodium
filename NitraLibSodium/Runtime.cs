using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium
{
    public unsafe partial class Runtime
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_neon")]
            internal static extern int SodiumRuntimeHasNeon();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_sse2")]
            internal static extern int SodiumRuntimeHasSse2();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_sse3")]
            internal static extern int SodiumRuntimeHasSse3();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_ssse3")]
            internal static extern int SodiumRuntimeHasSsse3();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_sse41")]
            internal static extern int SodiumRuntimeHasSse41();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_avx")]
            internal static extern int SodiumRuntimeHasAvx();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_avx2")]
            internal static extern int SodiumRuntimeHasAvx2();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_avx512f")]
            internal static extern int SodiumRuntimeHasAvx512f();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_pclmul")]
            internal static extern int SodiumRuntimeHasPclmul();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_aesni")]
            internal static extern int SodiumRuntimeHasAesni();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_runtime_has_rdrand")]
            internal static extern int SodiumRuntimeHasRdrand();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "_sodium_runtime_get_cpu_features")]
            internal static extern int SodiumRuntimeGetCpuFeatures();
        }

        public static int SodiumRuntimeHasNeon()
        {
            var __ret = __Internal.SodiumRuntimeHasNeon();
            return __ret;
        }

        public static int SodiumRuntimeHasSse2()
        {
            var __ret = __Internal.SodiumRuntimeHasSse2();
            return __ret;
        }

        public static int SodiumRuntimeHasSse3()
        {
            var __ret = __Internal.SodiumRuntimeHasSse3();
            return __ret;
        }

        public static int SodiumRuntimeHasSsse3()
        {
            var __ret = __Internal.SodiumRuntimeHasSsse3();
            return __ret;
        }

        public static int SodiumRuntimeHasSse41()
        {
            var __ret = __Internal.SodiumRuntimeHasSse41();
            return __ret;
        }

        public static int SodiumRuntimeHasAvx()
        {
            var __ret = __Internal.SodiumRuntimeHasAvx();
            return __ret;
        }

        public static int SodiumRuntimeHasAvx2()
        {
            var __ret = __Internal.SodiumRuntimeHasAvx2();
            return __ret;
        }

        public static int SodiumRuntimeHasAvx512f()
        {
            var __ret = __Internal.SodiumRuntimeHasAvx512f();
            return __ret;
        }

        public static int SodiumRuntimeHasPclmul()
        {
            var __ret = __Internal.SodiumRuntimeHasPclmul();
            return __ret;
        }

        public static int SodiumRuntimeHasAesni()
        {
            var __ret = __Internal.SodiumRuntimeHasAesni();
            return __ret;
        }

        public static int SodiumRuntimeHasRdrand()
        {
            var __ret = __Internal.SodiumRuntimeHasRdrand();
            return __ret;
        }

        public static int SodiumRuntimeGetCpuFeatures()
        {
            var __ret = __Internal.SodiumRuntimeGetCpuFeatures();
            return __ret;
        }
    }
}
