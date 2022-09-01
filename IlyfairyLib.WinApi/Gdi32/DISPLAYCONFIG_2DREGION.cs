using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_2DREGION]
    public struct DISPLAYCONFIG_2DREGION
    {
        [UINT32] public uint cx;
        [UINT32] public uint cy;
    }


}
