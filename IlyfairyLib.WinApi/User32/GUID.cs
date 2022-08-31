using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [GUID]
    public struct GUID
    {
        public uint Data1;
        public ushort Data2;
        public ushort Data3;
        public ulong Data4;
    }


}
