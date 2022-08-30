using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MenuInfo
    {
        public uint cbSize;
        public MenuInfoMask fMask;
        public MenuInfoStyle dwStyle;
        public uint cyMax;
        public IntPtr hbrBack;
        public uint dwContextHelpID;
        public IntPtr dwMenuData;
    }
}
