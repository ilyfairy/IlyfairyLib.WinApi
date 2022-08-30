using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DLGTEMPLATE]
    public struct DlgTemplate
    {
        [DWORD] public uint style;
        [DWORD] public uint dwExtendedStyle;
        [WORD] public ushort cdit;
        public short x;
        public short y;
        public short cx;
        public short cy;
    }
}
