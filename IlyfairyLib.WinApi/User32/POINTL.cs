using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTL]
    public struct POINTL
    {
        [LONG] public int x;
        [LONG] public int y;
    }


}
