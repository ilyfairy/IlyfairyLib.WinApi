using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [TOUCH_HIT_TESTING_INPUT]
    public struct TouchHitTestingInput
    {
        [UINT32]
        public uint pointerId;
        [POINT]
        public POINT point;
        [RECT]
        public RECT boundingBox;
        [RECT]
        public RECT nonOccludedBoundingBox;
        [UINT32]
        public uint orientation;
    }
}
