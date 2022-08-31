using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [HELPINFO]
    public struct HELPINFO
    {
        [UINT] public uint cbSize;
        public int iContextType;
        public int iCtrlId;
        [HANDLE] public IntPtr hItemHandle;
        [DWORD_PTR] public IntPtr dwContextId;
        [POINT] public POINT MousePos;
    }


}
