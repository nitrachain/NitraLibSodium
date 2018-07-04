using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.PWHash
{
    public unsafe partial class Argon2id
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_alg_argon2id13")]
            internal static extern int AlgArgon2id13();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_bytes_min")]
            internal static extern ulong BytesMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_bytes_max")]
            internal static extern ulong BytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_passwd_min")]
            internal static extern ulong PasswdMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_passwd_max")]
            internal static extern ulong PasswdMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_saltbytes")]
            internal static extern ulong Saltbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_strbytes")]
            internal static extern ulong Strbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_strprefix")]
            internal static extern global::System.IntPtr Strprefix();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_opslimit_min")]
            internal static extern ulong OpslimitMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_opslimit_max")]
            internal static extern ulong OpslimitMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_memlimit_min")]
            internal static extern ulong MemlimitMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_memlimit_max")]
            internal static extern ulong MemlimitMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_opslimit_interactive")]
            internal static extern ulong OpslimitInteractive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_memlimit_interactive")]
            internal static extern ulong MemlimitInteractive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_opslimit_moderate")]
            internal static extern ulong OpslimitModerate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_memlimit_moderate")]
            internal static extern ulong MemlimitModerate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_opslimit_sensitive")]
            internal static extern ulong OpslimitSensitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_memlimit_sensitive")]
            internal static extern ulong MemlimitSensitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id")]
            internal static extern int Argon2id(byte* @out, ulong outlen, [MarshalAs(UnmanagedType.LPStr)] string passwd, ulong passwdlen, byte* salt, ulong opslimit, ulong memlimit, int alg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_str")]
            internal static extern int Str(sbyte[] @out, [MarshalAs(UnmanagedType.LPStr)] string passwd, ulong passwdlen, ulong opslimit, ulong memlimit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_str_verify")]
            internal static extern int StrVerify(sbyte[] str, [MarshalAs(UnmanagedType.LPStr)] string passwd, ulong passwdlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_pwhash_argon2id_str_needs_rehash")]
            internal static extern int StrNeedsRehash(sbyte[] str, ulong opslimit, ulong memlimit);
        }

        public static int AlgArgon2id13()
        {
            var __ret = __Internal.AlgArgon2id13();
            return __ret;
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

        public static ulong OpslimitModerate()
        {
            var __ret = __Internal.OpslimitModerate();
            return __ret;
        }

        public static ulong MemlimitModerate()
        {
            var __ret = __Internal.MemlimitModerate();
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

        public static int CryptoArgon2id(byte* @out, ulong outlen, string passwd, ulong passwdlen, byte* salt, ulong opslimit, ulong memlimit, int alg)
        {
            var __ret = __Internal.Argon2id(@out, outlen, passwd, passwdlen, salt, opslimit, memlimit, alg);
            return __ret;
        }

        public static int Str(sbyte[] @out, string passwd, ulong passwdlen, ulong opslimit, ulong memlimit)
        {
            if (@out == null || @out.Length != 128)
                throw new ArgumentOutOfRangeException("@out", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.Str(@out, passwd, passwdlen, opslimit, memlimit);
            return __ret;
        }

        public static int StrVerify(sbyte[] str, string passwd, ulong passwdlen)
        {
            if (str == null || str.Length != 128)
                throw new ArgumentOutOfRangeException("str", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.StrVerify(str, passwd, passwdlen);
            return __ret;
        }

        public static int StrNeedsRehash(sbyte[] str, ulong opslimit, ulong memlimit)
        {
            if (str == null || str.Length != 128)
                throw new ArgumentOutOfRangeException("str", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.StrNeedsRehash(str, opslimit, memlimit);
            return __ret;
        }
    }
}
