using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [ALTTABINFO]
    public struct ALTTABINFO
    {
        [DWORD]public uint cbSize;
        public int cItems;
        public int cColumns;
        public int cRows;
        public int iColFocus;
        public int iRowFocus;
        public int cxItem;
        public int cyItem;
        [POINT]public POINT ptStart;
    }


}
