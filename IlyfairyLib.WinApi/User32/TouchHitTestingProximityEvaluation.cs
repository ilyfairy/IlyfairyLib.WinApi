using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TouchHitTestingProximityEvaluation // TOUCH_HIT_TESTING_PROXIMITY_EVALUATION
    {
        [UINT16] 
        public ushort score;
        [POINT] 
        public POINT adjustedPoint;
    }
}
