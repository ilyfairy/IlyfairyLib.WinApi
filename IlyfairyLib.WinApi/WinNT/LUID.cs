using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [LUID]
    public struct LUID
    {
        [DWORD ] public uint LowPart;
        [LONG]  public uint HighPart;
    }
}
