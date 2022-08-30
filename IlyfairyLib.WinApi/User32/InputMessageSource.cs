using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [INPUT_MESSAGE_SOURCE]
    public struct InputMessageSource
    {
        [INPUT_MESSAGE_DEVICE_TYPE] InputMessageDeviceType deviceType;
        [INPUT_MESSAGE_ORIGIN_ID] InputMessageOriginId originId;
    }
    

}
