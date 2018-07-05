using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Auth
{
    public unsafe partial class HmacSha256State : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 208)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NitraLibSodium.Hash.Sha256State.__Internal ictx;

            [FieldOffset(104)]
            internal global::NitraLibSodium.Hash.Sha256State.__Internal octx;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_auth_hmacsha256_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Auth.HmacSha256State> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Auth.HmacSha256State>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.Auth.HmacSha256State __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Auth.HmacSha256State(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.Auth.HmacSha256State __CreateInstance(global::NitraLibSodium.Auth.HmacSha256State.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Auth.HmacSha256State(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.Auth.HmacSha256State.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Auth.HmacSha256State.__Internal));
            *(global::NitraLibSodium.Auth.HmacSha256State.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private HmacSha256State(global::NitraLibSodium.Auth.HmacSha256State.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected HmacSha256State(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public HmacSha256State()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Auth.HmacSha256State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public HmacSha256State(global::NitraLibSodium.Auth.HmacSha256State _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Auth.HmacSha256State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.Auth.HmacSha256State.__Internal*)__Instance) = *((global::NitraLibSodium.Auth.HmacSha256State.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.Auth.HmacSha256State __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::NitraLibSodium.Hash.Sha256State Ictx
        {
            get
            {
                return global::NitraLibSodium.Hash.Sha256State.__CreateInstance(new global::System.IntPtr(&((global::NitraLibSodium.Auth.HmacSha256State.__Internal*)__Instance)->ictx));
            }

            set
            {
                ((global::NitraLibSodium.Auth.HmacSha256State.__Internal*)__Instance)->ictx = ReferenceEquals(value, null) ? new global::NitraLibSodium.Hash.Sha256State.__Internal() : *(global::NitraLibSodium.Hash.Sha256State.__Internal*)value.__Instance;
            }
        }

        public global::NitraLibSodium.Hash.Sha256State Octx
        {
            get
            {
                return global::NitraLibSodium.Hash.Sha256State.__CreateInstance(new global::System.IntPtr(&((global::NitraLibSodium.Auth.HmacSha256State.__Internal*)__Instance)->octx));
            }

            set
            {
                ((global::NitraLibSodium.Auth.HmacSha256State.__Internal*)__Instance)->octx = ReferenceEquals(value, null) ? new global::NitraLibSodium.Hash.Sha256State.__Internal() : *(global::NitraLibSodium.Hash.Sha256State.__Internal*)value.__Instance;
            }
        }
    }
}
