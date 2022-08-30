using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [CHANGEFILTERSTRUCT]
    public struct ChangeFilterStruct
    {
        [DWORD] public uint cbSize;
        [DWORD] public uint ExtStatus;
    }
}
