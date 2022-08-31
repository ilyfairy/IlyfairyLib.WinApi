using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [COMBOBOXINFO]
    public struct ComboBoxInfo
    {
        [DWORD] public uint cbSize;
        [RECT] public RECT rcItem;
        [RECT] public RECT rcButton;
        [DWORD] public uint stateButton;
        [HWND] public IntPtr hwndCombo;
        [HWND] public IntPtr hwndItem;
        [HWND] public IntPtr hwndList;
    }


}
