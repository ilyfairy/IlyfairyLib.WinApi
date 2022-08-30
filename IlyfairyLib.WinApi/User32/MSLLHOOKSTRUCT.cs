using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public int mouseData; // be careful, this must be ints, not uints (was wrong before I changed it...). regards, cmew.
        public int flags;
        public int time;
        public UIntPtr dwExtraInfo;
    }
}
