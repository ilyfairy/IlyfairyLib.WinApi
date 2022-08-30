using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WNDCLASSEXA
    {
        public uint cbSize;
        public ClassStyle style;
        public WndProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public byte[] lpszMenuName;
        public byte[] lpszClassName;
        public IntPtr hIconSm;
    }

}
