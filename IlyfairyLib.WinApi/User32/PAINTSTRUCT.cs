using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc; // 4 ~ 8
        public BOOL fErase; // 4
        public RECT rcPaint; // 16
        public BOOL fRestore; // 4
        public BOOL fIncUpdate; // 4
        public unsafe fixed byte rgbReserved[32]; // 32
        // 0 ~ 4
    }
}
