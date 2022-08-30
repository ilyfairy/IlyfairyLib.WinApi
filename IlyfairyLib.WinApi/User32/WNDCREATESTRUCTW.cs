using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCREATESTRUCTW // Only Unicode char ver.
    {
        public uint cbSize;
        public string lpszClassName;
        public string lpszWindowName;
        public WindowStyle dwStyle;
        public WindowStyleEx dwExStyle;
        public int X;
        public int Y;
        public int nWidth;
        public int nHeight;
        public IntPtr hWndParent;
        public IntPtr hMenu;
        public IntPtr hInstance;
        public IntPtr lpParam;
        public short Reversed1;
        public short nExpWinVer;
        public int dwFlags;
    }
}