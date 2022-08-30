using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [RECTL]
    public struct RECTL
    {
        [LONG] public int left;
        [LONG] public int top;
        [LONG] public int right;
        [LONG] public int bottom;
    }


}
