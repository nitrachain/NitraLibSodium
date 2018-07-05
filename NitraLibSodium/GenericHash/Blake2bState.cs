using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.GenericHash
{
    public unsafe partial class Blake2bState : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 384)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed ulong h[8];

            [FieldOffset(64)]
            internal fixed ulong t[2];

            [FieldOffset(80)]
            internal fixed ulong f[2];

            [FieldOffset(96)]
            internal fixed byte buf[256];

            [FieldOffset(352)]
            internal ulong buflen;

            [FieldOffset(360)]
            internal byte last_node;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_generichash_blake2b_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.GenericHash.Blake2bState> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.GenericHash.Blake2bState>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.GenericHash.Blake2bState __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.GenericHash.Blake2bState(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.GenericHash.Blake2bState __CreateInstance(global::NitraLibSodium.GenericHash.Blake2bState.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.GenericHash.Blake2bState(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.GenericHash.Blake2bState.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.GenericHash.Blake2bState.__Internal));
            *(global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Blake2bState(global::NitraLibSodium.GenericHash.Blake2bState.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Blake2bState(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Blake2bState()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.GenericHash.Blake2bState.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Blake2bState(global::NitraLibSodium.GenericHash.Blake2bState _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.GenericHash.Blake2bState.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance) = *((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.GenericHash.Blake2bState __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong[] H
        {
            get
            {
                ulong[] __value = null;
                if (((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->h != null)
                {
                    __value = new ulong[8];
                    for (int i = 0; i < 8; i++)
                        __value[i] = ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->h[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->h[i] = value[i];
                }
            }
        }

        public ulong[] T
        {
            get
            {
                ulong[] __value = null;
                if (((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->t != null)
                {
                    __value = new ulong[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->t[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->t[i] = value[i];
                }
            }
        }

        public ulong[] F
        {
            get
            {
                ulong[] __value = null;
                if (((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->f != null)
                {
                    __value = new ulong[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->f[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->f[i] = value[i];
                }
            }
        }

        public byte[] Buf
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->buf != null)
                {
                    __value = new byte[256];
                    for (int i = 0; i < 256; i++)
                        __value[i] = ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->buf[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 256; i++)
                        ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->buf[i] = value[i];
                }
            }
        }

        public ulong Buflen
        {
            get
            {
                return ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->buflen;
            }

            set
            {
                ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->buflen = value;
            }
        }

        public byte LastNode
        {
            get
            {
                return ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->last_node;
            }

            set
            {
                ((global::NitraLibSodium.GenericHash.Blake2bState.__Internal*)__Instance)->last_node = value;
            }
        }
    }
}
