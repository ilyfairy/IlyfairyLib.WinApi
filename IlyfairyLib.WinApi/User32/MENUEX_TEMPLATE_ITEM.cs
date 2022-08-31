using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MENUEX_TEMPLATE_ITEM]
    public struct MENUEX_TEMPLATE_ITEM
    {
        [DWORD] public uint dwType;
        [DWORD] public uint dwState;
        [UINT] public uint uId;
        [WORD] public ushort wFlags;
        [WCHAR] public char szText;
    }


}
