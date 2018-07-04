using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Kdf
{
    public unsafe partial class Kdf
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_bytes_min")]
            internal static extern ulong BytesMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_bytes_max")]
            internal static extern ulong BytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_contextbytes")]
            internal static extern ulong Contextbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_primitive")]
            internal static extern global::System.IntPtr Primitive();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_derive_from_key")]
            internal static extern int DeriveFromKey(byte* subkey, ulong subkey_len, ulong subkey_id, sbyte[] ctx, byte[] key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_kdf_keygen")]
            internal static extern void Keygen(byte[] k);
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

        public static ulong Contextbytes()
        {
            var __ret = __Internal.Contextbytes();
            return __ret;
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static string Primitive()
        {
            var __ret = __Internal.Primitive();
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static int DeriveFromKey(byte* subkey, ulong subkey_len, ulong subkey_id, sbyte[] ctx, byte[] key)
        {
            if (ctx == null || ctx.Length != 8)
                throw new ArgumentOutOfRangeException("ctx", "The dimensions of the provided array don't match the required size.");
            if (key == null || key.Length != 32)
                throw new ArgumentOutOfRangeException("key", "The dimensions of the provided array don't match the required size.");
            var __ret = __Internal.DeriveFromKey(subkey, subkey_len, subkey_id, ctx, key);
            return __ret;
        }

        public static void Keygen(byte[] k)
        {
            if (k == null || k.Length != 32)
                throw new ArgumentOutOfRangeException("k", "The dimensions of the provided array don't match the required size.");
            __Internal.Keygen(k);
        }
    }
}
