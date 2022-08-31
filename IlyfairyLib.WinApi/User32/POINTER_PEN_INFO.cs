using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTER_PEN_INFO]
    public struct PointerPenInfo
    {
        [POINTER_INFO]public PointerInfo pointerInfo;
        [PEN_FLAGS]public PenFlags penFlags;
        [PEN_MASK] public PenMask penMask;
        [UINT32] public uint pressure;
        [UINT32] public uint rotation;
        [INT32] public int tiltX;
        [INT32] public int tiltY;
    }


}
