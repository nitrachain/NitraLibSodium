using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.OneTimeAuth
{
    public unsafe partial class Poly1305State : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 256)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed byte opaque[256];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_onetimeauth_poly1305_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.OneTimeAuth.Poly1305State> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.OneTimeAuth.Poly1305State>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.OneTimeAuth.Poly1305State __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.OneTimeAuth.Poly1305State(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.OneTimeAuth.Poly1305State __CreateInstance(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.OneTimeAuth.Poly1305State(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal));
            *(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Poly1305State(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Poly1305State(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Poly1305State()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Poly1305State(global::NitraLibSodium.OneTimeAuth.Poly1305State _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal*)__Instance) = *((global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.OneTimeAuth.Poly1305State __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte[] Opaque
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal*)__Instance)->opaque != null)
                {
                    __value = new byte[256];
                    for (int i = 0; i < 256; i++)
                        __value[i] = ((global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal*)__Instance)->opaque[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 256; i++)
                        ((global::NitraLibSodium.OneTimeAuth.Poly1305State.__Internal*)__Instance)->opaque[i] = value[i];
                }
            }
        }
    }
}
