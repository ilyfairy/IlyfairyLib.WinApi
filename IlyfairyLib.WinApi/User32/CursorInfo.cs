using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [CURSORINFO]
    public struct CursorInfo
    {
        [DWORD] public uint cbSize;
        [DWORD] public CursorFlags flags;
        [HCURSOR] public IntPtr hCursor;
        [POINT] public POINT ptScreenPos;
    }
}
