using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Sign
{
    public unsafe partial class Ed25519phState : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 208)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NitraLibSodium.Hash.Sha512State.__Internal hs;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_sign_ed25519ph_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Sign.Ed25519phState> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Sign.Ed25519phState>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.Sign.Ed25519phState __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Sign.Ed25519phState(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.Sign.Ed25519phState __CreateInstance(global::NitraLibSodium.Sign.Ed25519phState.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Sign.Ed25519phState(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.Sign.Ed25519phState.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Sign.Ed25519phState.__Internal));
            *(global::NitraLibSodium.Sign.Ed25519phState.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ed25519phState(global::NitraLibSodium.Sign.Ed25519phState.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ed25519phState(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ed25519phState()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Sign.Ed25519phState.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ed25519phState(global::NitraLibSodium.Sign.Ed25519phState _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Sign.Ed25519phState.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.Sign.Ed25519phState.__Internal*)__Instance) = *((global::NitraLibSodium.Sign.Ed25519phState.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.Sign.Ed25519phState __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::NitraLibSodium.Hash.Sha512State Hs
        {
            get
            {
                return global::NitraLibSodium.Hash.Sha512State.__CreateInstance(new global::System.IntPtr(&((global::NitraLibSodium.Sign.Ed25519phState.__Internal*)__Instance)->hs));
            }

            set
            {
                ((global::NitraLibSodium.Sign.Ed25519phState.__Internal*)__Instance)->hs = ReferenceEquals(value, null) ? new global::NitraLibSodium.Hash.Sha512State.__Internal() : *(global::NitraLibSodium.Hash.Sha512State.__Internal*)value.__Instance;
            }
        }
    }
}
