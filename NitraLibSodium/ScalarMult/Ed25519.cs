﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.ScalarMult
{
    public unsafe partial class Ed25519
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_ed25519_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_ed25519_scalarbytes")]
            internal static extern ulong Scalarbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_ed25519")]
            internal static extern int Ed25519(byte* q, byte* n, byte* p);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_scalarmult_ed25519_base")]
            internal static extern int Base(byte* q, byte* n);
        }

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static ulong Scalarbytes()
        {
            var __ret = __Internal.Scalarbytes();
            return __ret;
        }

        public static int CryptoEd25519(byte[] q, byte[] n, byte[] p)
        {
            var __ret = __Internal.Ed25519(MarshalHelper.ByteArrayToIntPtr(q), MarshalHelper.ByteArrayToIntPtr(n), MarshalHelper.ByteArrayToIntPtr(p));
            return __ret;
        }

        public static int Base(byte[] q, byte[] n)
        {
            var __ret = __Internal.Base(MarshalHelper.ByteArrayToIntPtr(q), MarshalHelper.ByteArrayToIntPtr(n));
            return __ret;
        }
    }
}
