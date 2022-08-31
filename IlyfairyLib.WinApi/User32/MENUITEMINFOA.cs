using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MENUITEMINFOA]
    public struct MenuItemInfoA
    {
        [UINT] public uint cbSize;
        [UINT] public uint fMask;
        [UINT] public uint fType;
        [UINT] public uint fState;
        [UINT] public uint wID;
        [HMENU] public IntPtr hSubMenu;
        [HBITMAP] public IntPtr hbmpChecked;
        [HBITMAP] public IntPtr hbmpUnchecked;
        [ULONG_PTR] public UIntPtr dwItemData;
        [LPSTR] public byte[] dwTypeData;
        [UINT] public uint cch;
        [HBITMAP] public IntPtr hbmpItem;
    }


}
