using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [DISPLAY_DEVICEW]
    public struct DisplayDeviceW
    {
        [DWORD] public uint cb;
        [WCHAR] public unsafe fixed char DeviceName[32];
        [WCHAR] public unsafe fixed char DeviceString[128];
        [DWORD] public uint StateFlags;
        [WCHAR] public unsafe fixed char DeviceID[128];
        [WCHAR] public unsafe fixed char DeviceKey[128];
    }
}
