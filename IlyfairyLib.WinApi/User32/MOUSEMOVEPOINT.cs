using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MOUSEMOVEPOINT]
    public struct MOUSEMOVEPOINT
    {
        public int x;
        public int y;
        [DWORD] public uint time;
        [ULONG_PTR] public UIntPtr dwExtraInfo;
    }


}
