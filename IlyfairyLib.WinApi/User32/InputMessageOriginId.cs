using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [INPUT_MESSAGE_ORIGIN_ID]
    public enum InputMessageOriginId
    {
        IMO_UNAVAILABLE = 0x00000000,
        IMO_HARDWARE = 0x00000001,
        IMO_INJECTED = 0x00000002,
        IMO_SYSTEM = 0x00000004
    }
    

}
