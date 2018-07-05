using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Hash
{
    public unsafe partial class Sha512State : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 208)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed ulong state[8];

            [FieldOffset(64)]
            internal fixed ulong count[2];

            [FieldOffset(80)]
            internal fixed byte buf[128];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_hash_sha512_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Hash.Sha512State> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Hash.Sha512State>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.Hash.Sha512State __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Hash.Sha512State(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.Hash.Sha512State __CreateInstance(global::NitraLibSodium.Hash.Sha512State.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Hash.Sha512State(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.Hash.Sha512State.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Hash.Sha512State.__Internal));
            *(global::NitraLibSodium.Hash.Sha512State.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Sha512State(global::NitraLibSodium.Hash.Sha512State.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Sha512State(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Sha512State()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Hash.Sha512State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Sha512State(global::NitraLibSodium.Hash.Sha512State _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Hash.Sha512State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance) = *((global::NitraLibSodium.Hash.Sha512State.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.Hash.Sha512State __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong[] State
        {
            get
            {
                ulong[] __value = null;
                if (((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->state != null)
                {
                    __value = new ulong[8];
                    for (int i = 0; i < 8; i++)
                        __value[i] = ((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->state[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->state[i] = value[i];
                }
            }
        }

        public ulong[] Count
        {
            get
            {
                ulong[] __value = null;
                if (((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->count != null)
                {
                    __value = new ulong[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->count[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->count[i] = value[i];
                }
            }
        }

        public byte[] Buf
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->buf != null)
                {
                    __value = new byte[128];
                    for (int i = 0; i < 128; i++)
                        __value[i] = ((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->buf[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 128; i++)
                        ((global::NitraLibSodium.Hash.Sha512State.__Internal*)__Instance)->buf[i] = value[i];
                }
            }
        }
    }
}
