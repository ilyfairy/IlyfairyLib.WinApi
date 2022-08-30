﻿using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
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
