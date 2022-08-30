using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [FLASHWINFO]
    [StructLayout(LayoutKind.Sequential)]
    public struct FlashWInfo
    {
        [UINT] public uint cbSize;
        [HWND] public IntPtr hwnd;
        [DWORD] public uint dwFlags;
        [UINT] public uint uCount;
        [DWORD] public uint dwTimeout;
    }
    

}
