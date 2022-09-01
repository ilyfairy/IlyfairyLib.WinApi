using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.WinNT;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [PRIVILEGE_SET]
    public struct PRIVILEGE_SET
    {
        [DWORD] public uint PrivilegeCount;
        [DWORD] public uint Control;
        [LUID_AND_ATTRIBUTES] public LUID_AND_ATTRIBUTES Privilege;
    }
}
