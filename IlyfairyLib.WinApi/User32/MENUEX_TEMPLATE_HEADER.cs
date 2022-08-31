using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MENUEX_TEMPLATE_HEADER]
    public struct MENUEX_TEMPLATE_HEADER
    {
        [WORD] public ushort wVersion;
        [WORD] public ushort wOffset;
        [DWORD] public uint dwHelpId;
    }


}
