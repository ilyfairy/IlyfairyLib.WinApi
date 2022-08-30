using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [RAWMOUSE]
    public struct RawMouse
    {
        [USHORT] public ushort usFlags;
        public ButtonUnion buttons;
        [ULONG] public uint ulRawButtons;
        [LONG] public int lLastX;
        [LONG] public int lLastY;
        [ULONG] public uint ulExtraInformation;

        [StructLayout(LayoutKind.Explicit)]
        public struct ButtonUnion
        {
            [FieldOffset(0)]
            [ULONG]public uint ulButtons;
            [FieldOffset(0)]
            public UsButton usButton;
        }

        public struct UsButton
        {
            [USHORT] public ushort usButtonFlags;
            [USHORT] public ushort usButtonData;
        }
    }
}
