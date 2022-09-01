using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.Gdi32;
using IlyfairyLib.WinApi.User32;
using IlyfairyLib.WinApi.WinNT;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_DEVICE_INFO_HEADER]
    public struct DisplayConfigDeviceInfoHeader
    {

        [DISPLAYCONFIG_DEVICE_INFO_TYPE] public DISPLAYCONFIG_DEVICE_INFO_TYPE type;
        [UINT32] public uint size;
        [LUID] public LUID adapterId;
        [UINT32] public uint id;
    }
    

}
