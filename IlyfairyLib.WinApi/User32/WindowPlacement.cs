using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [WINDOWPLACEMENT]
    public struct WindowPlacement
    {
        [UINT] public uint length;
        [UINT] public uint flags;
        [UINT] public uint showCmd;
        [POINT] public POINT ptMinPosition;
        [POINT] public POINT ptMaxPosition;
        [RECT] public RECT rcNormalPosition;
    }
}
