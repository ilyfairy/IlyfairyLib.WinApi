using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MENUBARINFO]
    public struct MENUBARINFO
    {
        [DWORD] public uint cbSize;
        [RECT] public RECT rcBar;
        [HMENU] public IntPtr hMenu;
        [HWND] public IntPtr hwndMenu;
        [BOOL] public unsafe fixed byte fBarFocused[1]; // 1
        [BOOL] public unsafe fixed byte fFocused[1]; // 1
        [BOOL] public unsafe fixed byte fUnused[30]; // 30
    }


}
