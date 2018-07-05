using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NitraLibSodium.SecretStream
{
    public unsafe partial class Xchacha20poly1305State : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 52)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed byte k[32];

            [FieldOffset(32)]
            internal fixed byte nonce[12];

            [FieldOffset(44)]
            internal fixed byte _pad[8];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libsodium", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0crypto_secretstream_xchacha20poly1305_state@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.SecretStream.Xchacha20poly1305State> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NitraLibSodium.SecretStream.Xchacha20poly1305State>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NitraLibSodium.SecretStream.Xchacha20poly1305State __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.SecretStream.Xchacha20poly1305State(native.ToPointer(), skipVTables);
        }

        internal static global::NitraLibSodium.SecretStream.Xchacha20poly1305State __CreateInstance(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal native, bool skipVTables = false)
        {
            return new global::NitraLibSodium.SecretStream.Xchacha20poly1305State(native, skipVTables);
        }

        private static void* __CopyValue(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal));
            *(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Xchacha20poly1305State(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Xchacha20poly1305State(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Xchacha20poly1305State()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Xchacha20poly1305State(global::NitraLibSodium.SecretStream.Xchacha20poly1305State _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance) = *((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NitraLibSodium.SecretStream.Xchacha20poly1305State __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte[] K
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->k != null)
                {
                    __value = new byte[32];
                    for (int i = 0; i < 32; i++)
                        __value[i] = ((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->k[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 32; i++)
                        ((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->k[i] = value[i];
                }
            }
        }

        public byte[] Nonce
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->nonce != null)
                {
                    __value = new byte[12];
                    for (int i = 0; i < 12; i++)
                        __value[i] = ((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->nonce[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 12; i++)
                        ((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->nonce[i] = value[i];
                }
            }
        }

        public byte[] Pad
        {
            get
            {
                byte[] __value = null;
                if (((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->_pad != null)
                {
                    __value = new byte[8];
                    for (int i = 0; i < 8; i++)
                        __value[i] = ((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->_pad[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((global::NitraLibSodium.SecretStream.Xchacha20poly1305State.__Internal*)__Instance)->_pad[i] = value[i];
                }
            }
        }
    }
}
