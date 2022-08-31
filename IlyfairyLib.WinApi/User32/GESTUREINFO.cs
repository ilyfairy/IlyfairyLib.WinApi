using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [GESTUREINFO]
    public struct GESTUREINFO
    {
        [UINT] public uint cbSize;
        [DWORD] public uint dwFlags;
        [DWORD] public uint dwID;
        [HWND] public IntPtr hwndTarget;
        [POINTS] public POINTS ptsLocation;
        [DWORD] public uint dwInstanceID;
        [DWORD] public uint dwSequenceID;
        [ULONGLONG] public ulong ullArguments;
        [UINT] public uint cbExtraArgs;
    }


}
