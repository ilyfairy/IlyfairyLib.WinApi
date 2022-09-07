using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.KernelBase
{
    [StructLayout(LayoutKind.Sequential)]
    [NLSVERSIONINFO]
    public struct NLSVERSIONINFO
    {
        [DWORD] public uint dwNLSVersionInfoSize;
        [DWORD] public uint dwNLSVersion;
        [DWORD] public uint dwDefinedVersion;
        [DWORD] public uint dwEffectiveId;
        [GUID] public GUID guidCustomVersion;
    }
}