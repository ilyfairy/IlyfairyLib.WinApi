using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_TARGET_MODE]
    public struct DISPLAYCONFIG_TARGET_MODE
    {
        [DISPLAYCONFIG_VIDEO_SIGNAL_INFO] public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
    }


}
