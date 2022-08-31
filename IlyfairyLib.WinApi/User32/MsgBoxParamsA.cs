using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [MSGBOXPARAMSA]
    public unsafe struct MsgBoxParamsA
    {
        [UINT] public uint cbSize;
        [HWND] public IntPtr hwndOwner;
        [HINSTANCE] public IntPtr hInstance;
        [LPCSTR] public byte[] lpszText;
        [LPCSTR] public byte[] lpszCaption;
        [DWORD] public uint dwStyle;
        [LPCSTR] public byte* lpszIcon;
        [DWORD_PTR] public IntPtr dwContextHelpId;
        [MSGBOXCALLBACK] public MsgBoxCallback lpfnMsgBoxCallback;
        [DWORD] public uint dwLanguageId;
    }
    

}
