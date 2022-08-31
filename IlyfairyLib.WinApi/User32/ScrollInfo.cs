using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [SCROLLINFO]
    public struct ScrollInfo
    {
        [UINT] public uint cbSize;
        [UINT] public uint fMask;
        public int nMin;
        public int nMax;
        [UINT] public uint nPage;
        public int nPos;
        public int nTrackPos;
    }


}
