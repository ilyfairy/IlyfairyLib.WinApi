using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.KernelBase
{
    [StructLayout(LayoutKind.Sequential)]
    [FILETIME]
    public struct FILETIME
    {
        [DWORD] public uint dwLowDateTime;
        [DWORD] public uint dwHighDateTime;
    }

}