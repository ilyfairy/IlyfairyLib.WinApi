using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MONITORINFO]
    public struct MonitorInfo
    {
        [DWORD] public uint cbSize;
        [RECT] public RECT rcMonitor;
        [RECT] public RECT rcWork;
        [DWORD] public uint dwFlags;
    }


}
