using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [TPMPARAMS]
    public struct TPMParams
    {
        [UINT] public uint cbSize;
        [RECT] public RECT rcExclude;
    }


}
