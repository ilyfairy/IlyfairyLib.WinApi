using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.WinNT;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [CONVCONTEXT]
    public struct ConvContext
    {
        [UINT] public uint cb;
        [UINT] public uint wFlags;
        [UINT] public uint wCountryID;
        public int iCodePage;
        [DWORD] public uint dwLangID;
        [DWORD] public uint dwSecurity;
        [SECURITY_QUALITY_OF_SERVICE] public SECURITY_QUALITY_OF_SERVICE qos;
    }
}
