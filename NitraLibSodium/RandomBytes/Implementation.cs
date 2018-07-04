using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.Randombytes
{
    public unsafe partial class Implementation : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr implementation_name;

            [FieldOffset(8)]
            internal global::System.IntPtr random;

            [FieldOffset(16)]
            internal global::System.IntPtr stir;

            [FieldOffset(24)]
            internal global::System.IntPtr uniform;

            [FieldOffset(32)]
            internal global::System.IntPtr buf;

            [FieldOffset(40)]
            internal global::System.IntPtr close;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLibSodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0randombytes_implementation@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Randombytes.Implementation> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.Randombytes.Implementation>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.Randombytes.Implementation __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Randombytes.Implementation(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.Randombytes.Implementation __CreateInstance(global::NitraLibSodium.Randombytes.Implementation.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.Randombytes.Implementation(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.Randombytes.Implementation.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Randombytes.Implementation.__Internal));
            *(global::NitraLibSodium.Randombytes.Implementation.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Implementation(global::NitraLibSodium.Randombytes.Implementation.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Implementation(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Implementation()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Randombytes.Implementation.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Implementation(global::NitraLibSodium.Randombytes.Implementation _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.Randombytes.Implementation.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.Randombytes.Implementation.__Internal*)__Instance) = *((global::NitraLibSodium.Randombytes.Implementation.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.Randombytes.Implementation __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}
