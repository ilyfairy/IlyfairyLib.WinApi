using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.User32;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_DESKTOP_IMAGE_INFO]
    public struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO
    {
        [POINTL] public POINTL PathSourceSize;
        [RECTL] public RECTL DesktopImageRegion;
        [RECTL] public RECTL DesktopImageClip;
    }


}
