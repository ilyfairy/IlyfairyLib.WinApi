using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.WinNT;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [LUID_AND_ATTRIBUTES]
    public struct LUID_AND_ATTRIBUTES
    {
        [LUID] public LUID Luid;
        [DWORD] public uint Attributes;
    }
}
