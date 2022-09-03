using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [SCROLLBARINFO]
    public struct ScrollBarInfo
    {
        [DWORD] public uint cbSize;
        [RECT] public RECT rcScrollBar;
        public int dxyLineButton;
        public int xyThumbTop;
        public int xyThumbBottom;
        public int reserved;
        [DWORD] public unsafe fixed uint rgstate[6];
    }


}
