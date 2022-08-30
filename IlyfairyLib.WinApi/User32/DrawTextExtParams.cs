using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DRAWTEXTPARAMS]
    public struct DrawTextExtParams
    {
        [UINT] public uint cbSize;
        public int iTabLength;
        public int iLeftMargin;
        public int iRightMargin;
        [UINT] public uint uiLengthDrawn;
    }
}