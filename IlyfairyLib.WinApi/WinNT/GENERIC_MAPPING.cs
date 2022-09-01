using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [GENERIC_MAPPING]
    public struct GENERIC_MAPPING
    {
        [ACCESS_MASK] public uint GenericRead;
        [ACCESS_MASK] public uint GenericWrite;
        [ACCESS_MASK] public uint GenericExecute;
        [ACCESS_MASK] public uint GenericAll;
    }
}
