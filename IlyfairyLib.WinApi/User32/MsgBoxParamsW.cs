using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MSGBOXPARAMSW]
    public unsafe struct MsgBoxParamsW
    {
        [UINT] public uint cbSize;
        [HWND] public IntPtr hwndOwner;
        [HINSTANCE] public IntPtr hInstance;
        [LPCWSTR] public string lpszText;
        [LPCWSTR] public string lpszCaption;
        [DWORD] public uint dwStyle;
        [LPCWSTR] public char* lpszIcon;
        [DWORD_PTR] public IntPtr dwContextHelpId;
        [MSGBOXCALLBACK] public MsgBoxCallback lpfnMsgBoxCallback;
        [DWORD] public uint dwLanguageId;
    }
    

}
