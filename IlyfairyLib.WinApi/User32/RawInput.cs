using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInput
    {
        [RAWINPUTHEADER] public RawInputHeader header;
        public DataUnion data;

        public struct DataUnion
        {
            [RAWMOUSE] public RawMouse mouse;
            [RAWKEYBOARD] public int keyboard;
            [RAWHID] public int hid;
        }
    }
}
