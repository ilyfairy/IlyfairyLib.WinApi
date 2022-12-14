using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [WNDCLASSEXW]
    public struct WNDCLASSEXW
    {
        [UINT] public uint cbSize;
        [UINT] public ClassStyle style;
        [WNDPROC] public WndProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        [HINSTANCE] public IntPtr hInstance;
        [HICON] public IntPtr hIcon;
        [HCURSOR] public IntPtr hCursor;
        [HBRUSH] public IntPtr hbrBackground;
        [LPCWSTR] public string lpszMenuName;
        [LPCWSTR] public string lpszClassName;
        [HICON] public IntPtr hIconSm;
    }

}