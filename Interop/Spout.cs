using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("Spout.Interop")]

public unsafe partial class SHELLEXECUTEINFOA
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal uint cbSize;

        [FieldOffset(4)]
        internal uint fMask;

        [FieldOffset(8)]
        internal IntPtr hwnd;

        [FieldOffset(16)]
        internal IntPtr lpVerb;

        [FieldOffset(24)]
        internal IntPtr lpFile;

        [FieldOffset(32)]
        internal IntPtr lpParameters;

        [FieldOffset(40)]
        internal IntPtr lpDirectory;

        [FieldOffset(48)]
        internal int nShow;

        [FieldOffset(56)]
        internal IntPtr hInstApp;

        [FieldOffset(64)]
        internal IntPtr lpIDList;

        [FieldOffset(72)]
        internal IntPtr lpClass;

        [FieldOffset(80)]
        internal IntPtr hkeyClass;

        [FieldOffset(88)]
        internal uint dwHotKey;

        [FieldOffset(96)]
        internal global::SHELLEXECUTEINFOA._0.__Internal _0;

        [FieldOffset(104)]
        internal IntPtr hProcess;
    }

    public unsafe partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal IntPtr hIcon;

            [FieldOffset(0)]
            internal IntPtr hMonitor;
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace CompressedPair
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1
        {
            [FieldOffset(0)]
            internal StringVal.__Internalc__N_std_S__String_val____N_std_S__Simple_types__C _Myval2;
        }
    }

    namespace Allocator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="??0?$allocator@D@std@@QEAA@XZ")]
            internal static extern IntPtr ctorc__N_std_S_allocator__C(IntPtr __instance);
        }
    }

    public unsafe partial class Allocator<_Ty> : IDisposable
    {
        public IntPtr __Instance { get; protected set; }

        internal static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Allocator<_Ty>> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Allocator<_Ty>>();

        protected bool __ownsNativeInstance;

        internal static Allocator<_Ty> __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Allocator<_Ty>(native.ToPointer(), skipVTables);
        }

        internal static Allocator<_Ty> __CreateInstance(Allocator.__Internal native, bool skipVTables = false)
        {
            return new Allocator<_Ty>(native, skipVTables);
        }

        private static void* __CopyValue(Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Allocator.__Internal));
            *(Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public Allocator()
        {
            var ___Ty = typeof(_Ty);
            if (___Ty.IsAssignableFrom(typeof(sbyte)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(Allocator.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Allocator.__Internal.ctorc__N_std_S_allocator__C(__Instance);
                return;
            }
            throw new ArgumentOutOfRangeException("_Ty", string.Join(", ", new[] { typeof(_Ty).FullName }), "global::Std.Allocator<_Ty> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte>.");
        }

        ~Allocator()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            Allocator<_Ty> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
    namespace BasicString
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public unsafe partial struct __Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C
        {
            [FieldOffset(0)]
            internal CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1 _Mypair;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="??0?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QEAA@XZ")]
            internal static extern IntPtr ctorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="??1?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QEAA@XZ")]
            internal static extern void dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(IntPtr __instance, int delete);
        }
    }

    public unsafe partial class BasicString<_Elem, _Traits, _Alloc> : IDisposable
    {
        public IntPtr __Instance { get; protected set; }

        internal static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, BasicString<_Elem, _Traits, _Alloc>> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, BasicString<_Elem, _Traits, _Alloc>>();

        protected bool __ownsNativeInstance;

        internal static BasicString<_Elem, _Traits, _Alloc> __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new BasicString<_Elem, _Traits, _Alloc>(native.ToPointer(), skipVTables);
        }

        internal static BasicString<_Elem, _Traits, _Alloc> __CreateInstance(BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native, bool skipVTables = false)
        {
            return new BasicString<_Elem, _Traits, _Alloc>(native, skipVTables);
        }

        private static void* __CopyValue(BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C));
            *(BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) ret = native;
            return ret.ToPointer();
        }

        private BasicString(BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected BasicString(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public BasicString()
        {
            var ___Elem = typeof(_Elem);
            var ___Traits = typeof(_Traits);
            var ___Alloc = typeof(_Alloc);
            if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(Allocator<sbyte>)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C.ctorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__Instance);
                return;
            }
            throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
        }

        ~BasicString()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            BasicString<_Elem, _Traits, _Alloc> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
            {
                var ___Elem = typeof(_Elem);
                var ___Traits = typeof(_Traits);
                var ___Alloc = typeof(_Alloc);
                if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(Allocator<sbyte>)))
                {
                    BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C.dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__Instance, 0);
                    return;
                }
                throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    namespace StringVal
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public unsafe partial struct __Internalc__N_std_S__String_val____N_std_S__Simple_types__C
        {
            [FieldOffset(0)]
            internal Bxty.__Internal _Bx;

            [FieldOffset(16)]
            internal ulong _Mysize;

            [FieldOffset(24)]
            internal ulong _Myres;
        }

        namespace Bxty
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal fixed sbyte _Buf[16];

                [FieldOffset(0)]
                internal IntPtr _Ptr;

                [FieldOffset(0)]
                internal fixed sbyte _Alias[16];
            }
        }

    }

    namespace CharTraits
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class CharTraits<_Elem> : IDisposable
    {
        public IntPtr __Instance { get; protected set; }

        internal static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CharTraits<_Elem>> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CharTraits<_Elem>>();

        protected bool __ownsNativeInstance;

        internal static CharTraits<_Elem> __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CharTraits<_Elem>(native.ToPointer(), skipVTables);
        }

        internal static CharTraits<_Elem> __CreateInstance(CharTraits.__Internal native, bool skipVTables = false)
        {
            return new CharTraits<_Elem>(native, skipVTables);
        }

        private static void* __CopyValue(CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(CharTraits.__Internal));
            *(CharTraits.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CharTraits(CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        ~CharTraits()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            CharTraits<_Elem> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    public unsafe static partial class BasicStringExtensions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="?assign@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QEAAAEAV12@QEBD@Z")]
            internal static extern IntPtr Assign(IntPtr __instance, [MarshalAs(UnmanagedType.LPUTF8Str)] string _Ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="?data@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QEBAPEBDXZ")]
            internal static extern IntPtr Data(IntPtr __instance);
        }

        public static BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>> Assign(this BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>> @this, string _Ptr)
        {
            var __arg0 = ReferenceEquals(@this, null) ? IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.Assign(__arg0, _Ptr);
            BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>> __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>>.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>>) BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>>.NativeToManagedMap[__ret];
            else __result0 = BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>>.__CreateInstance(__ret);
            return __result0;
        }

        public static string Data(this BasicString<sbyte, CharTraits<sbyte>, Allocator<sbyte>> @this)
        {
            var __arg0 = ReferenceEquals(@this, null) ? IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.Data(__arg0);
            if (__ret == IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*) __ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return System.Text.Encoding.UTF8.GetString((byte*) __ret, __length);
        }
    }
}

public enum D3DFORMAT
{
}

public enum D3D_FEATURE_LEVEL
{
}

public enum D3D_DRIVER_TYPE
{
}

public enum DXGI_FORMAT
{
}
