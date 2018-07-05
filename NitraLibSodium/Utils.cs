using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium
{
    public unsafe partial class Utils
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_memzero")]
            internal static extern void SodiumMemzero(global::System.IntPtr pnt, ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_stackzero")]
            internal static extern void SodiumStackzero(ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_memcmp")]
            internal static extern int SodiumMemcmp(global::System.IntPtr b1_, global::System.IntPtr b2_, ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_compare")]
            internal static extern int SodiumCompare(byte* b1_, byte* b2_, ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_is_zero")]
            internal static extern int SodiumIsZero(byte* n, ulong nlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_increment")]
            internal static extern void SodiumIncrement(byte* n, ulong nlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_add")]
            internal static extern void SodiumAdd(byte* a, byte* b, ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_bin2hex")]
            internal static extern sbyte* SodiumBin2hex(sbyte* hex, ulong hex_maxlen, byte* bin, ulong bin_len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_hex2bin")]
            internal static extern int SodiumHex2bin(byte* bin, ulong bin_maxlen, [MarshalAs(UnmanagedType.LPStr)] string hex, ulong hex_len, [MarshalAs(UnmanagedType.LPStr)] string ignore, ulong* bin_len, sbyte** hex_end);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_base64_encoded_len")]
            internal static extern ulong SodiumBase64EncodedLen(ulong bin_len, int variant);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_bin2base64")]
            internal static extern sbyte* SodiumBin2base64(sbyte* b64, ulong b64_maxlen, byte* bin, ulong bin_len, int variant);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_base642bin")]
            internal static extern int SodiumBase642bin(byte* bin, ulong bin_maxlen, [MarshalAs(UnmanagedType.LPStr)] string b64, ulong b64_len, [MarshalAs(UnmanagedType.LPStr)] string ignore, ulong* bin_len, sbyte** b64_end, int variant);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_mlock")]
            internal static extern int SodiumMlock(global::System.IntPtr addr, ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_munlock")]
            internal static extern int SodiumMunlock(global::System.IntPtr addr, ulong len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_malloc")]
            internal static extern global::System.IntPtr SodiumMalloc(ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_allocarray")]
            internal static extern global::System.IntPtr SodiumAllocarray(ulong count, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_free")]
            internal static extern void SodiumFree(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_mprotect_noaccess")]
            internal static extern int SodiumMprotectNoaccess(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_mprotect_readonly")]
            internal static extern int SodiumMprotectReadonly(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_mprotect_readwrite")]
            internal static extern int SodiumMprotectReadwrite(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_pad")]
            internal static extern int SodiumPad(ulong* padded_buflen_p, byte* buf, ulong unpadded_buflen, ulong blocksize, ulong max_buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sodium_unpad")]
            internal static extern int SodiumUnpad(ulong* unpadded_buflen_p, byte* buf, ulong padded_buflen, ulong blocksize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "_sodium_alloc_init")]
            internal static extern int SodiumAllocInit();
        }

        public static void SodiumMemzero(global::System.IntPtr pnt, ulong len)
        {
            __Internal.SodiumMemzero(pnt, len);
        }

        public static void SodiumStackzero(ulong len)
        {
            __Internal.SodiumStackzero(len);
        }

        public static int SodiumMemcmp(global::System.IntPtr b1_, global::System.IntPtr b2_, ulong len)
        {
            var __ret = __Internal.SodiumMemcmp(b1_, b2_, len);
            return __ret;
        }

        public static int SodiumCompare(byte[] b1_, byte[] b2_, ulong len)
        {
            var __ret = __Internal.SodiumCompare(MarshalHelper.ByteArrayToIntPtr(b1_), MarshalHelper.ByteArrayToIntPtr(b2_), len);
            return __ret;
        }

        public static int SodiumIsZero(byte[] n, ulong nlen)
        {
            var __ret = __Internal.SodiumIsZero(MarshalHelper.ByteArrayToIntPtr(n), nlen);
            return __ret;
        }

        public static void SodiumIncrement(byte[] n, ulong nlen)
        {
            __Internal.SodiumIncrement(MarshalHelper.ByteArrayToIntPtr(n), nlen);
        }

        public static void SodiumAdd(byte[] a, byte[] b, ulong len)
        {
            __Internal.SodiumAdd(MarshalHelper.ByteArrayToIntPtr(a), MarshalHelper.ByteArrayToIntPtr(b), len);
        }

        public static sbyte* SodiumBin2hex(sbyte[] hex, ulong hex_maxlen, byte[] bin, ulong bin_len)
        {
            var __ret = __Internal.SodiumBin2hex(MarshalHelper.SByteArrayToIntPtr(hex), hex_maxlen, MarshalHelper.ByteArrayToIntPtr(bin), bin_len);
            return __ret;
        }

        public static int SodiumHex2bin(byte[] bin, ulong bin_maxlen, string hex, ulong hex_len, string ignore, ref ulong bin_len, sbyte[] hex_end) 
        {
            fixed (ulong* __refParamPtr5 = &bin_len)
            {
                var __arg5 = __refParamPtr5;
                var __ret = __Internal.SodiumHex2bin(MarshalHelper.ByteArrayToIntPtr(bin), bin_maxlen, hex, hex_len, ignore, __arg5, MarshalHelper.SByteArrayToDoubleIntPtr(hex_end));
                return __ret;
            }
        }

        public static ulong SodiumBase64EncodedLen(ulong bin_len, int variant)
        {
            var __ret = __Internal.SodiumBase64EncodedLen(bin_len, variant);
            return __ret;
        }

        public static sbyte* SodiumBin2base64(sbyte[] b64, ulong b64_maxlen, byte[] bin, ulong bin_len, int variant)
        {
            var __ret = __Internal.SodiumBin2base64(MarshalHelper.SByteArrayToIntPtr(b64), b64_maxlen, MarshalHelper.ByteArrayToIntPtr(bin), bin_len, variant);
            return __ret;
        }

        public static int SodiumBase642bin(byte[] bin, ulong bin_maxlen, string b64, ulong b64_len, string ignore, ref ulong bin_len, sbyte[] b64_end, int variant)
        {
            fixed (ulong* __refParamPtr5 = &bin_len)
            {
                var __arg5 = __refParamPtr5;
                var __ret = __Internal.SodiumBase642bin(MarshalHelper.ByteArrayToIntPtr(bin), bin_maxlen, b64, b64_len, ignore, __arg5, MarshalHelper.SByteArrayToDoubleIntPtr(b64_end), variant);
                return __ret;
            }
        }

        public static int SodiumMlock(global::System.IntPtr addr, ulong len)
        {
            var __ret = __Internal.SodiumMlock(addr, len);
            return __ret;
        }

        public static int SodiumMunlock(global::System.IntPtr addr, ulong len)
        {
            var __ret = __Internal.SodiumMunlock(addr, len);
            return __ret;
        }

        public static global::System.IntPtr SodiumMalloc(ulong size)
        {
            var __ret = __Internal.SodiumMalloc(size);
            return __ret;
        }

        public static global::System.IntPtr SodiumAllocarray(ulong count, ulong size)
        {
            var __ret = __Internal.SodiumAllocarray(count, size);
            return __ret;
        }

        public static void SodiumFree(global::System.IntPtr ptr)
        {
            __Internal.SodiumFree(ptr);
        }

        public static int SodiumMprotectNoaccess(global::System.IntPtr ptr)
        {
            var __ret = __Internal.SodiumMprotectNoaccess(ptr);
            return __ret;
        }

        public static int SodiumMprotectReadonly(global::System.IntPtr ptr)
        {
            var __ret = __Internal.SodiumMprotectReadonly(ptr);
            return __ret;
        }

        public static int SodiumMprotectReadwrite(global::System.IntPtr ptr)
        {
            var __ret = __Internal.SodiumMprotectReadwrite(ptr);
            return __ret;
        }

        public static int SodiumPad(ref ulong padded_buflen_p, byte[] buf, ulong unpadded_buflen, ulong blocksize, ulong max_buflen)
        {
            fixed (ulong* __refParamPtr0 = &padded_buflen_p)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.SodiumPad(__arg0, MarshalHelper.ByteArrayToIntPtr(buf), unpadded_buflen, blocksize, max_buflen);
                return __ret;
            }
        }

        public static int SodiumUnpad(ref ulong unpadded_buflen_p, byte[] buf, ulong padded_buflen, ulong blocksize)
        {
            fixed (ulong* __refParamPtr0 = &unpadded_buflen_p)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.SodiumUnpad(__arg0, MarshalHelper.ByteArrayToIntPtr(buf), padded_buflen, blocksize);
                return __ret;
            }
        }

        public static int SodiumAllocInit()
        {
            var __ret = __Internal.SodiumAllocInit();
            return __ret;
        }
    }
}
