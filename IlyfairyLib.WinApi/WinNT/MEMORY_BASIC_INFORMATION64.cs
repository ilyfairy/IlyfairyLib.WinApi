using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [MEMORY_BASIC_INFORMATION64]
    public struct MEMORY_BASIC_INFORMATION64
    {
        [ULONGLONG] public  ulong   BaseAddress;
        [ULONGLONG] public  ulong  AllocationBase;
        [DWORD] public  uint  AllocationProtect;
        [DWORD] public   uint __alignment1;
        [ULONGLONG] public  ulong  RegionSize;
        [DWORD] public  uint  State;
        [DWORD] public  uint  Protect;
        [DWORD] public  uint  Type;
        [DWORD] public  uint  __alignment2;
    }
}