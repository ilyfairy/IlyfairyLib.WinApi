using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GUITHREADINFO
    {
        [DWORD] public uint cbSize;
        [DWORD] public uint flags;
        [HWND] public IntPtr hwndActive;
        [HWND] public IntPtr hwndFocus;
        [HWND] public IntPtr hwndCapture;
        [HWND] public IntPtr hwndMenuOwner;
        [HWND] public IntPtr hwndMoveSize;
        [HWND] public IntPtr hwndCaret;
        [RECT] public RECT rcCaret;
    }
}
