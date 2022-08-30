using System;

namespace IlyfairyLib.WinApi.User32
{
    [Flags]
    public enum AcceleratorFlags : byte
    {
        FVIRTKEY = 1,
        FNOINVERT = 2,
        FSHIFT = 4,
        FCONTROL = 8,
        FALT = 16
    }
}
