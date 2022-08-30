using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [TOUCHINPUT]
    public struct TouchInput
    {
        [LONG]public int x;
        [LONG]public int y;
        [HANDLE]public IntPtr hSource;
        [DWORD]public uint dwID;
        [DWORD]public uint dwFlags;
        [DWORD]public uint dwMask;
        [DWORD]public uint dwTime;
        [ULONG_PTR]public UIntPtr dwExtraInfo;
        [DWORD]public uint cxContact;
        [DWORD]public uint cyContact;
    }
}
