using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [MEMORY_BASIC_INFORMATION32]
    public struct MEMORY_BASIC_INFORMATION32
    {
        [DWORD]public uint BaseAddress;
        [DWORD]public uint AllocationBase;
        [DWORD]public uint AllocationProtect;
        [DWORD]public uint RegionSize;
        [DWORD]public uint State;
        [DWORD]public uint Protect;
        [DWORD]public uint Type;
    }
}