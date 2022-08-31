using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [RAWINPUTDEVICELIST]
    public struct RAWINPUTDEVICELIST
    {
        [HANDLE]public IntPtr hDevice;
        [DWORD]public uint dwType;
    }


}
