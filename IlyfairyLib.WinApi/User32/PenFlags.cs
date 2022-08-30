using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [PEN_FLAGS]
    public enum PenFlags
    {
        PEN_FLAG_NONE = 0x00000000,
        PEN_FLAG_BARREL = 0x00000001,
        PEN_FLAG_INVERTED = 0x00000002,
        PEN_FLAG_ERASER = 0x00000004,
    }


}
