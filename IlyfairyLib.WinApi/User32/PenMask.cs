using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [PEN_MASK]
    public enum PenMask
    {
        PEN_MASK_NONE = 0x00000000,
        PEN_MASK_PRESSURE = 0x00000001,
        PEN_MASK_ROTATION = 0x00000002,
        PEN_MASK_TILT_X = 0x00000004,
        PEN_MASK_TILT_Y = 0x00000008,
    }


}
