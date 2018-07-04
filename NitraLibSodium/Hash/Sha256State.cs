using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Hash
{
    public unsafe partial class Sha256State : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 104)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed uint state[8];

            [FieldOffset(32)]
            internal ulong count;

            [FieldOffset(40)]
            internal fixed byte buf[64];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_hash_sha256_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Hash.Sha256State> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Hash.Sha256State>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.Hash.Sha256State __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Hash.Sha256State(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.Hash.Sha256State __CreateInstance(global::NitraLibSodium.Hash.Sha256State.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Hash.Sha256State(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.Hash.Sha256State.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Hash.Sha256State.__Internal));
            *(global::NitraLibSodium.Hash.Sha256State.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Sha256State(global::NitraLibSodium.Hash.Sha256State.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Sha256State(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Sha256State()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Hash.Sha256State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Sha256State(global::NitraLibSodium.Hash.Sha256State _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Hash.Sha256State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance) = *((global::NitraLibSodium.Hash.Sha256State.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.Hash.Sha256State __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint[] State
        {
            get
            {
                uint[] __value = null;
                if (((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->state != null)
                {
                    __value = new uint[8];
                    for (int i = 0; i < 8; i++)
                        __value[i] = ((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->state[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->state[i] = value[i];
                }
            }
        }

        public ulong Count
        {
            get
            {
                return ((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->count;
            }

            set
            {
                ((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->count = value;
            }
        }

        public byte[] Buf
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->buf != null)
                {
                    __value = new byte[64];
                    for (int i = 0; i < 64; i++)
                        __value[i] = ((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->buf[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 64; i++)
                        ((global::NitraLibSodium.Hash.Sha256State.__Internal*)__Instance)->buf[i] = value[i];
                }
            }
        }
    }
}
