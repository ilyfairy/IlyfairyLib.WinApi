using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [TITLEBARINFO]
    public struct TitleBarInfo
    {
        [DWORD] public uint cbSize;
        [RECT] public RECT rcTitleBar;
        [DWORD] public unsafe fixed uint rgstate[User32Const.CCHILDREN_TITLEBAR + 1];
    }


}
