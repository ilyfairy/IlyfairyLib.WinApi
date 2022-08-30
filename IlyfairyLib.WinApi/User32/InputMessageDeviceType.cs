using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [INPUT_MESSAGE_DEVICE_TYPE]
    public enum InputMessageDeviceType
    {
        IMDT_UNAVAILABLE = 0x00000000,
        IMDT_KEYBOARD = 0x00000001,
        IMDT_MOUSE = 0x00000002,
        IMDT_TOUCH = 0x00000004,
        IMDT_PEN = 0x00000008,
        IMDT_TOUCHPAD = 0x00000010
    }
    

}
