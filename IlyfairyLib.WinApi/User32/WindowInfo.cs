using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [WINDOWINFO]
    public struct WindowInfo
    {
        [DWORD] public uint cbSize;
        [RECT] public RECT rcWindow;
        [RECT] public RECT rcClient;
        [DWORD] public uint dwStyle;
        [DWORD] public uint dwExStyle;
        [DWORD] public uint dwWindowStatus;
        [UINT] public uint cxWindowBorders;
        [UINT] public uint cyWindowBorders;
        [ATOM] public ushort atomWindowType;
        [WORD] public ushort wCreatorVersion;
    }
}
