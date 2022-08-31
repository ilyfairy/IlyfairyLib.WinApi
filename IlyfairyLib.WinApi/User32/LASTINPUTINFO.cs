using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [LASTINPUTINFO]
    public struct LASTINPUTINFO
    {
        [UINT] public uint cbSize;
        [DWORD] public uint dwTime;
    }


}
