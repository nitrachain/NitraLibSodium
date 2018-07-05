using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.GenericHash
{
    public unsafe partial class Blake2b
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_bytes_min")]
            internal static extern ulong BytesMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_bytes_max")]
            internal static extern ulong BytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_bytes")]
            internal static extern ulong Bytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_keybytes_min")]
            internal static extern ulong KeybytesMin();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_keybytes_max")]
            internal static extern ulong KeybytesMax();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_keybytes")]
            internal static extern ulong Keybytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_saltbytes")]
            internal static extern ulong Saltbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_personalbytes")]
            internal static extern ulong Personalbytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_statebytes")]
            internal static extern ulong Statebytes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b")]
            internal static extern int Blake2b(byte* @out, ulong outlen, byte* @in, ulong inlen, byte* key, ulong keylen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_salt_personal")]
            internal static extern int SaltPersonal(byte* @out, ulong outlen, byte* @in, ulong inlen, byte* key, ulong keylen, byte* salt, byte* personal);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_init")]
            internal static extern int Init(global::System.IntPtr state, byte* key, ulong keylen, ulong outlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_init_salt_personal")]
            internal static extern int InitSaltPersonal(global::System.IntPtr state, byte* key, ulong keylen, ulong outlen, byte* salt, byte* personal);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_update")]
            internal static extern int Update(global::System.IntPtr state, byte* @in, ulong inlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_final")]
            internal static extern int Final(global::System.IntPtr state, byte* @out, ulong outlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crypto_generichash_blake2b_keygen")]
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

        public static ulong Bytes()
        {
            var __ret = __Internal.Bytes();
            return __ret;
        }

        public static ulong KeybytesMin()
        {
            var __ret = __Internal.KeybytesMin();
            return __ret;
        }

        public static ulong KeybytesMax()
        {
            var __ret = __Internal.KeybytesMax();
            return __ret;
        }

        public static ulong Keybytes()
        {
            var __ret = __Internal.Keybytes();
            return __ret;
        }

        public static ulong Saltbytes()
        {
            var __ret = __Internal.Saltbytes();
            return __ret;
        }

        public static ulong Personalbytes()
        {
            var __ret = __Internal.Personalbytes();
            return __ret;
        }

        public static ulong Statebytes()
        {
            var __ret = __Internal.Statebytes();
            return __ret;
        }

        public static int CryptoBlake2b(byte[] @out, ulong outlen, byte[] @in, ulong inlen, byte[] key, ulong keylen)
        {
            var __ret = __Internal.Blake2b(MarshalHelper.ByteArrayToIntPtr(@out), outlen, MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(key), keylen);
            return __ret;
        }

        public static int SaltPersonal(byte[] @out, ulong outlen, byte[] @in, ulong inlen, byte[] key, ulong keylen, byte[] salt, byte[] personal)
        {
            var __ret = __Internal.SaltPersonal(MarshalHelper.ByteArrayToIntPtr(@out), outlen, MarshalHelper.ByteArrayToIntPtr(@in), inlen, MarshalHelper.ByteArrayToIntPtr(key), keylen, MarshalHelper.ByteArrayToIntPtr(salt), MarshalHelper.ByteArrayToIntPtr(personal));
            return __ret;
        }

        public static int Init(global::NitraLibSodium.GenericHash.Blake2bState state, byte[] key, ulong keylen, ulong outlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Init(__arg0, MarshalHelper.ByteArrayToIntPtr(key), keylen, outlen);
            return __ret;
        }

        public static int InitSaltPersonal(global::NitraLibSodium.GenericHash.Blake2bState state, byte[] key, ulong keylen, ulong outlen, byte[] salt, byte[] personal)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.InitSaltPersonal(__arg0, MarshalHelper.ByteArrayToIntPtr(key), keylen, outlen, MarshalHelper.ByteArrayToIntPtr(salt), MarshalHelper.ByteArrayToIntPtr(personal));
            return __ret;
        }

        public static int Update(global::NitraLibSodium.GenericHash.Blake2bState state, byte[] @in, ulong inlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Update(__arg0, MarshalHelper.ByteArrayToIntPtr(@in), inlen);
            return __ret;
        }

        public static int Final(global::NitraLibSodium.GenericHash.Blake2bState state, byte[] @out, ulong outlen)
        {
            var __arg0 = ReferenceEquals(state, null) ? global::System.IntPtr.Zero : state.__Instance;
            var __ret = __Internal.Final(__arg0, MarshalHelper.ByteArrayToIntPtr(@out), outlen);
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
