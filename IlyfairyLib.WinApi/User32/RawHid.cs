using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [RAWHID]
    public struct RawHid
    {
        [DWORD] uint dwSizeHid;
        [DWORD] uint dwCount;
        [BYTE] byte bRawData;
    }
}
