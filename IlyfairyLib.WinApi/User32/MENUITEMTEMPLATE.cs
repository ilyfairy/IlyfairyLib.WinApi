using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MENUITEMTEMPLATE]
    public struct MENUITEMTEMPLATE
    {
        [WORD] public ushort mtOption;
        [WORD] public ushort mtID;
        [WCHAR] public char mtString;
    }


}
