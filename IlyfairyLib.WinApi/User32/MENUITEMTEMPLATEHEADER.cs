using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MENUITEMTEMPLATEHEADER]
    public struct MENUITEMTEMPLATEHEADER
    {
        [WORD] public ushort versionNumber;
        [WORD] public ushort offset;
    }


}
