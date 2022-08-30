using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [ICONINFO]
    public struct IconInfo
    {
        [BOOL] public BOOL fIcon;
        [DWORD] public uint xHotspot;
        [DWORD] public uint yHotspot;
        [HBITMAP] public IntPtr hbmMask;
        [HBITMAP] public IntPtr hbmColor;
    }
}