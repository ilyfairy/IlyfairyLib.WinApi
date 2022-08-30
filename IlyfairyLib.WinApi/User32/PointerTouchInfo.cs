using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTER_TOUCH_INFO]
    public struct PointerTouchInfo
    {
        [POINTER_INFO]public PointerInfo pointerInfo;
        [TOUCH_FLAGS] public TouchFlags touchFlags;
        [TOUCH_MASK] public TouchMask touchMask;
        [RECT] public RECT rcContact;
        [RECT] public RECT rcContactRaw;
        [UINT32] public uint orientation;
        [UINT32] public uint pressure;
    }


}
