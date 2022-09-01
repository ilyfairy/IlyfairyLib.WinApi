using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [DISPLAY_DEVICEA]
    public struct DisplayDeviceA
    {
        [DWORD] public uint cb;
        [CHAR] public unsafe fixed byte DeviceName[32];
        [CHAR] public unsafe fixed byte DeviceString[128];
        [DWORD] public uint StateFlags;
        [CHAR] public unsafe fixed byte DeviceID[128];
        [CHAR] public unsafe fixed byte DeviceKey[128];
    }
}
