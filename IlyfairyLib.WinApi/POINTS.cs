using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTS]
    public struct POINTS
    {
        [SHORT] public short x;
        [SHORT] public short y;
    }


}
