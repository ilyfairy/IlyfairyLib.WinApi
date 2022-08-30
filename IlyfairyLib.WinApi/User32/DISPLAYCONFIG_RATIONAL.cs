using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_RATIONAL]
    public struct DISPLAYCONFIG_RATIONAL
    {
        [UINT32] public uint Numerator;
        [UINT32] public uint Denominator;
    }


}
