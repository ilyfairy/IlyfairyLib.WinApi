using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Comctl32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [TASKDIALOGCONFIG]
    public struct TASKDIALOGCONFIG
    {
        public static unsafe uint Size => sizeof(IntPtr) == 4 ? 96u : 160u;

        [UINT] public uint cbSize;
        [HWND] public IntPtr hwndParent;
        [HINSTANCE] public IntPtr hInstance;
        [TASKDIALOG_FLAGS] public TASKDIALOG_FLAGS dwFlags;
        [TASKDIALOG_COMMON_BUTTON_FLAGS] public TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;
        [PCWSTR] public string pszWindowTitle;
        public MainIconUnion mainIconUnion;

        [PCWSTR] public string pszMainInstruction;
        [PCWSTR] public string pszContent;
        [UINT] public uint cButtons;
        [TASKDIALOG_BUTTON, Ptr, CONST] public unsafe TASKDIALOG_BUTTON* pButtons;
        public int nDefaultButton;
        [UINT] public uint cRadioButtons;
        [TASKDIALOG_BUTTON, Ptr, CONST] public unsafe TASKDIALOG_BUTTON* pRadioButtons;
        public int nDefaultRadioButton;
        [PCWSTR] public string pszVerificationText;
        [PCWSTR] public string pszExpandedInformation;
        [PCWSTR] public string pszExpandedControlText;
        [PCWSTR] public string pszCollapsedControlText;
        public FooterIconUnion footerIconUnion;
        [PCWSTR] public string pszFooter;
        [PFTASKDIALOGCALLBACK] public PFTASKDIALOGCALLBACK pfCallback;
        [LONG_PTR] public IntPtr lpCallbackData;
        [UINT] public uint cxWidth;

        [StructLayout(LayoutKind.Explicit)]
        public struct MainIconUnion
        {
            [FieldOffset(0)]
            [HICON] public IntPtr hMainIcon;
            [FieldOffset(0)]
            [PCWSTR] public unsafe char* pszMainIcon;
        }
        [StructLayout(LayoutKind.Explicit)]
        public struct FooterIconUnion
        {
            [FieldOffset(0)]
            [HICON] public IntPtr hFooterIcon;  
            [FieldOffset(0)]
            [PCWSTR] public unsafe char* pszFooterIcon;
        }
    }
}