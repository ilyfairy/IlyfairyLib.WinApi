using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTER_TYPE_INFO]
    public struct PointerTypeInfo
    {
        [POINTER_INPUT_TYPE] public PointerInputType type;
        public InfoUnion info;

        [StructLayout(LayoutKind.Explicit)]
        public struct InfoUnion
        {
            [FieldOffset(0)]
            [POINTER_TOUCH_INFO] public PointerTouchInfo touchInfo;
            [FieldOffset(0)]
            [POINTER_PEN_INFO] public PointerPenInfo penInfo;
        }
    }


}
