using System;
using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [MEMORY_BASIC_INFORMATION]
    public struct MEMORY_BASIC_INFORMATION
    {
        [PVOID] public IntPtr BaseAddress;
        [PVOID] public IntPtr AllocationBase;
        public IntPtr AllocationProtect_PartitionId_Union;
        [SIZE_T] public UIntPtr RegionSize;
        [DWORD] public uint State;
        [DWORD] public uint Protect;
        [DWORD] public uint Type;
    }
}