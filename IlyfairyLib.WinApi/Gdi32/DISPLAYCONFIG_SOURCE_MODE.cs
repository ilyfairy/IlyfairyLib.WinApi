using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.User32;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_SOURCE_MODE]
    public struct DISPLAYCONFIG_SOURCE_MODE
    {
        [UINT32] public uint width;
        [UINT32] public uint height;
        [DISPLAYCONFIG_PIXELFORMAT] public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
        [POINTL] public POINTL position;
    }


}
