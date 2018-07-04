﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.PWHash
{
    public unsafe partial class Scryptsalsa208sha256
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_bytes_min")]
            internal static extern ulong BytesMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_bytes_max")]
            internal static extern ulong BytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_passwd_min")]
            internal static extern ulong PasswdMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_passwd_max")]
            internal static extern ulong PasswdMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_saltbytes")]
            internal static extern ulong Saltbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_strbytes")]
            internal static extern ulong Strbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_strprefix")]
            internal static extern global::System.IntPtr Strprefix();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_opslimit_min")]
            internal static extern ulong OpslimitMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_opslimit_max")]
            internal static extern ulong OpslimitMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_memlimit_min")]
            internal static extern ulong MemlimitMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_memlimit_max")]
            internal static extern ulong MemlimitMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_opslimit_interactive")]
            internal static extern ulong OpslimitInteractive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_memlimit_interactive")]
            internal static extern ulong MemlimitInteractive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_opslimit_sensitive")]
            internal static extern ulong OpslimitSensitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_memlimit_sensitive")]
            internal static extern ulong MemlimitSensitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256")]
            internal static extern int Scryptsalsa208sha256(byte* @out, ulong outlen, [MarshalAs(UnmanagedType.LPStr)] string passwd, ulong passwdlen, byte* salt, ulong opslimit, ulong memlimit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_str")]
            internal static extern int Str(sbyte[] @out, [MarshalAs(UnmanagedType.LPStr)] string passwd, ulong passwdlen, ulong opslimit, ulong memlimit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_str_verify")]
            internal static extern int StrVerify(sbyte[] str, [MarshalAs(UnmanagedType.LPStr)] string passwd, ulong passwdlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_ll")]
            internal static extern int Ll(byte* passwd, ulong passwdlen, byte* salt, ulong saltlen, ulong N, uint r, uint p, byte* buf, ulong buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_scryptsalsa208sha256_str_needs_rehash")]
            internal static extern int StrNeedsRehash(sbyte[] str, ulong opslimit, ulong memlimit);
        }

        public static ulong BytesMin()
        {
            var __ret = __Internal.BytesMin();
            return __ret;
        }

        public static ulong BytesMax()
        {
            var __ret = __Internal.BytesMax();
            return __ret;
        }

        public static ulong PasswdMin()
        {
            var __ret = __Internal.PasswdMin();
            return __ret;
        }

        public static ulong PasswdMax()
        {
            var __ret = __Internal.PasswdMax();
            return __ret;
        }

        public static ulong Saltbytes()
        {
            var __ret = __Internal.Saltbytes();
            return __ret;
        }

        public static ulong Strbytes()
        {
            var __ret = __Internal.Strbytes();
            return __ret;
        }

        public static string Strprefix()
        {
            var __ret = __Internal.Strprefix();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static ulong OpslimitMin()
        {
            var __ret = __Internal.OpslimitMin();
            return __ret;
        }

        public static ulong OpslimitMax()
        {
            var __ret = __Internal.OpslimitMax();
            return __ret;
        }

        public static ulong MemlimitMin()
        {
            var __ret = __Internal.MemlimitMin();
            return __ret;
        }

        public static ulong MemlimitMax()
        {
            var __ret = __Internal.MemlimitMax();
            return __ret;
        }

        public static ulong OpslimitInteractive()
        {
            var __ret = __Internal.OpslimitInteractive();
            return __ret;
        }

        public static ulong MemlimitInteractive()
        {
            var __ret = __Internal.MemlimitInteractive();
            return __ret;
        }

        public static ulong OpslimitSensitive()
        {
            var __ret = __Internal.OpslimitSensitive();
            return __ret;
        }

        public static ulong MemlimitSensitive()
        {
            var __ret = __Internal.MemlimitSensitive();
            return __ret;
        }

        public static int CryptoScryptsalsa208sha256(byte* @out, ulong outlen, string passwd, ulong passwdlen, byte* salt, ulong opslimit, ulong memlimit)
        {
            var __ret = __Internal.Scryptsalsa208sha256(@out, outlen, passwd, passwdlen, salt, opslimit, memlimit);
            return __ret;
        }

        public static int Str(sbyte[] @out, string passwd, ulong passwdlen, ulong opslimit, ulong memlimit)
        {
            if (@out == null || @out.Length != 102)
                throw new ArgumentOutOfRangeException("@out", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.Str(@out, passwd, passwdlen, opslimit, memlimit);
            return __ret;
        }

        public static int StrVerify(sbyte[] str, string passwd, ulong passwdlen)
        {
            if (str == null || str.Length != 102)
                throw new ArgumentOutOfRangeException("str", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.StrVerify(str, passwd, passwdlen);
            return __ret;
        }

        public static int Ll(byte* passwd, ulong passwdlen, byte* salt, ulong saltlen, ulong N, uint r, uint p, byte* buf, ulong buflen)
        {
            var __ret = __Internal.Ll(passwd, passwdlen, salt, saltlen, N, r, p, buf, buflen);
            return __ret;
        }

        public static int StrNeedsRehash(sbyte[] str, ulong opslimit, ulong memlimit)
        {
            if (str == null || str.Length != 102)
                throw new ArgumentOutOfRangeException("str", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.StrNeedsRehash(str, opslimit, memlimit);
            return __ret;
        }
    }
}