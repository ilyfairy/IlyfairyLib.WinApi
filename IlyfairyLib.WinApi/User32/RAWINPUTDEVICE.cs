using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [RAWINPUTDEVICE]
    public struct RAWINPUTDEVICE
    {
        [USHORT] public ushort usUsagePage;
        [USHORT] public ushort usUsage;
        [DWORD] public uint dwFlags;
        [HWND] public IntPtr hwndTarget;
    }


}
