using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [TOUCH_MASK]
    public enum TouchMask
    {
        TOUCH_MASK_NONE = 0x00000000,
        TOUCH_MASK_CONTACTAREA = 0x00000001,
        TOUCH_MASK_ORIENTATION = 0x00000002,
        TOUCH_MASK_PRESSURE = 0x00000004,
    }


}
