using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NitraLibSodium
{
    public static class MarshalHelper
    {
        internal unsafe static byte* ByteArrayToIntPtr(byte[] @in)
        {
            fixed(byte* _ret = @in)
            {
                return _ret;
            }
        }

        public unsafe static sbyte* SByteArrayToIntPtr(sbyte[] @in)
        {
            fixed (sbyte* _ret = @in)
            {
                return _ret;
            }
        }

        public unsafe static sbyte** SByteArrayToDoubleIntPtr(sbyte[] @in)
        {
            fixed (sbyte* _ret0 = @in)
            {
                sbyte*[] _ret1 = { _ret0 };
                fixed (sbyte** _ret = _ret1)
                {
                    return _ret;
                }
            }
        }
    }
}
