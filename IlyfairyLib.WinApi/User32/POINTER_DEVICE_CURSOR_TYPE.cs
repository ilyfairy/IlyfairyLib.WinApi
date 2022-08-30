using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [POINTER_DEVICE_CURSOR_TYPE]
    public enum PointerDeviceCursorType : uint
    {
        POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0x00000000,
        POINTER_DEVICE_CURSOR_TYPE_TIP = 0x00000001,
        POINTER_DEVICE_CURSOR_TYPE_ERASER = 0x00000002,
        POINTER_DEVICE_CURSOR_TYPE_MAX = 0xFFFFFFFF
    }


}
