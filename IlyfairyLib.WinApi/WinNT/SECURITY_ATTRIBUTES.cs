using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        public uint nLength;
        public IntPtr lpSecurityDescriptor;
        public BOOL bInheritHandle;
    }


}
