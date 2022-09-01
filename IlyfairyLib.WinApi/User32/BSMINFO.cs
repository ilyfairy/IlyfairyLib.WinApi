using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.WinNT;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [BSMINFO]
    public struct BSMInfo
    {
        [UINT] public uint cbSize;
        [HDESK] public IntPtr hdesk;
        [HWND] public IntPtr hwnd;
        [LUID] public LUID luid;
    }
}
