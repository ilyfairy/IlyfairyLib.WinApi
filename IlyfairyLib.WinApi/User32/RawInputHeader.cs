using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputHeader
    {
        [DWORD] public uint dwType;
        [DWORD] public uint dwSize;
        [HANDLE] public IntPtr hDevice;
        [WPARAM] public IntPtr wParam;
    }
}
