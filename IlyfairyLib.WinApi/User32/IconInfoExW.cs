using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential,CharSet = CharSet.Unicode)]
    [ICONINFOEXW]
    public struct IconInfoExW
    {
        [DWORD] public uint cbSize;
        [BOOL] public BOOL fIcon;
        [DWORD] public uint xHotspot;
        [DWORD] public uint yHotspot;
        [HBITMAP] public IntPtr hbmMask;
        [HBITMAP] public IntPtr hbmColor;
        [WORD] public ushort wResID;
        [CHAR] public unsafe fixed char szModName[260];
        [CHAR] public unsafe fixed char szResName[260];
    }
}
