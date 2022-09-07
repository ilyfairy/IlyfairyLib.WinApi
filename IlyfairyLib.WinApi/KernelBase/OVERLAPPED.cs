using System;
using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.KernelBase
{
    //minwinbase.h
    [StructLayout(LayoutKind.Sequential)]
    [OVERLAPPED]
    public struct OVERLAPPED
    {
        [ULONG_PTR]public UIntPtr Internal;
        [ULONG_PTR]public UIntPtr InternalHigh;
        public OffsetUnion offsetUnion;
        [HANDLE]public IntPtr hEvent;

        [StructLayout(LayoutKind.Explicit)]
        public struct OffsetUnion
        {
            [FieldOffset(0)]
            [DWORD]public uint Offset;
            [FieldOffset(4)]
            [DWORD]public uint OffsetHigh;

            [FieldOffset(0)]
            [PVOID]public IntPtr Pointer;
        }
    }
}