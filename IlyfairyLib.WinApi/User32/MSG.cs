using System;

namespace IlyfairyLib.WinApi.User32
{
    public struct MSG // tagMSG Msg
    {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public POINT pt;
    }
}
