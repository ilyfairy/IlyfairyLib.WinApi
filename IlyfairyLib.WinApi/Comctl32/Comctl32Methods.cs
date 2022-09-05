using IlyfairyLib.WinApi.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.Comctl32
{
    public static class Comctl32Methods
    {
        [DllImport("Comctl32.dll", CharSet = CharSet.Unicode)]
        [return: HRESULT]
        public static extern IntPtr TaskDialogIndirect(
            [TASKDIALOGCONFIG, Ptr, CONST, _In_] in TASKDIALOGCONFIG pTaskConfig,
            [Ptr, _Out_opt_] out int pnButton,
            [Ptr, _Out_opt_] out int pnRadioButton,
            [BOOL, Ptr, _Out_opt_] out BOOL pfVerificationFlagChecked);

        [DllImport("Comctl32.dll", CharSet = CharSet.Unicode)]
        [return: HRESULT]
        public static extern IntPtr TaskDialogIndirect(
            [TASKDIALOGCONFIG, Ptr, CONST, _In_] in TASKDIALOGCONFIG pTaskConfig,
            [Ptr, _Out_opt_] out int pnButton,
            [Ptr, _Out_opt_] IntPtr pnRadioButton,
            [BOOL, Ptr, _Out_opt_] IntPtr pfVerificationFlagChecked);
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [TASKDIALOG_BUTTON]
    public unsafe struct TASKDIALOG_BUTTON
    {
        public int nButtonID;
        [PCWSTR] public char* pszButtonText;
    }

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

    public enum TASKDIALOG_FLAGS
    {
        TDF_ENABLE_HYPERLINKS = 0x0001,
        TDF_USE_HICON_MAIN = 0x0002,
        TDF_USE_HICON_FOOTER = 0x0004,
        TDF_ALLOW_DIALOG_CANCELLATION = 0x0008,
        TDF_USE_COMMAND_LINKS = 0x0010,
        TDF_USE_COMMAND_LINKS_NO_ICON = 0x0020,
        TDF_EXPAND_FOOTER_AREA = 0x0040,
        TDF_EXPANDED_BY_DEFAULT = 0x0080,
        TDF_VERIFICATION_FLAG_CHECKED = 0x0100,
        TDF_SHOW_PROGRESS_BAR = 0x0200,
        TDF_SHOW_MARQUEE_PROGRESS_BAR = 0x0400,
        TDF_CALLBACK_TIMER = 0x0800,
        TDF_POSITION_RELATIVE_TO_WINDOW = 0x1000,
        TDF_RTL_LAYOUT = 0x2000,
        TDF_NO_DEFAULT_RADIO_BUTTON = 0x4000,
        TDF_CAN_BE_MINIMIZED = 0x8000,
        TDF_SIZE_TO_CONTENT = 0x01000000
    }

    public enum TASKDIALOG_COMMON_BUTTON_FLAGS
    {
        TDCBF_OK_BUTTON = 0x0001,
        TDCBF_YES_BUTTON = 0x0002,
        TDCBF_NO_BUTTON = 0x0004,
        TDCBF_CANCEL_BUTTON = 0x0008,
        TDCBF_RETRY_BUTTON = 0x0010,
        TDCBF_CLOSE_BUTTON = 0x0020
    }

    [TASKDIALOG_NOTIFICATIONS]
    public enum TASKDIALOG_NOTIFICATIONS
    {
        TDN_CREATED = 0,
        TDN_NAVIGATED = 1,
        TDN_BUTTON_CLICKED = 2,
        TDN_HYPERLINK_CLICKED = 3,
        TDN_TIMER = 4,
        TDN_DESTROYED = 5,
        TDN_RADIO_BUTTON_CLICKED = 6,
        TDN_DIALOG_CONSTRUCTED = 7,
        TDN_VERIFICATION_CLICKED = 8,
        TDN_HELP = 9,
        TDN_EXPANDO_BUTTON_CLICKED = 10
    }



    [PFTASKDIALOGCALLBACK]
    [return: HRESULT]
    public delegate IntPtr PFTASKDIALOGCALLBACK([HWND, _In_] IntPtr hwnd, [UINT, _In_] uint msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [LONG_PTR, _In_] IntPtr lpRefData);
}

//namespace IlyfairyLib.WinApi.Comctl32
//{
//    public static class Comctl32Methods
//    {
//        [DllImport("Comctl32.dll", CharSet = CharSet.Unicode)]
//        [return: HRESULT]
//        public static extern IntPtr TaskDialogIndirect(
//        [In] ref TASKDIALOGCONFIG pTaskConfig,
//            [Out] out int pnButton,
//            [Out] out int pnRadioButton,
//            [Out] out bool pfVerificationFlagChecked);
//    }

//    [Flags]
//    public enum TASKDIALOG_FLAGS : uint
//    {
//        TDF_ENABLE_HYPERLINKS = 0x0001,
//        TDF_USE_HICON_MAIN = 0x0002,
//        TDF_USE_HICON_FOOTER = 0x0004,
//        TDF_ALLOW_DIALOG_CANCELLATION = 0x0008,
//        TDF_USE_COMMAND_LINKS = 0x0010,
//        TDF_USE_COMMAND_LINKS_NO_ICON = 0x0020,
//        TDF_EXPAND_FOOTER_AREA = 0x0040,
//        TDF_EXPANDED_BY_DEFAULT = 0x0080,
//        TDF_VERIFICATION_FLAG_CHECKED = 0x0100,
//        TDF_SHOW_PROGRESS_BAR = 0x0200,
//        TDF_SHOW_MARQUEE_PROGRESS_BAR = 0x0400,
//        TDF_CALLBACK_TIMER = 0x0800,
//        TDF_POSITION_RELATIVE_TO_WINDOW = 0x1000,
//        TDF_RTL_LAYOUT = 0x2000,
//        TDF_NO_DEFAULT_RADIO_BUTTON = 0x4000,
//        TDF_CAN_BE_MINIMIZED = 0x8000
//    }

//    [Flags]
//    public enum TASKDIALOG_COMMON_BUTTON_FLAGS : uint
//    {
//        TDCBF_OK_BUTTON = 0x0001,
//        TDCBF_YES_BUTTON = 0x0002,
//        TDCBF_NO_BUTTON = 0x0004,
//        TDCBF_CANCEL_BUTTON = 0x0008,
//        TDCBF_RETRY_BUTTON = 0x0010,
//        TDCBF_CLOSE_BUTTON = 0x0020,
//    }

//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
//    public struct TASKDIALOGCONFIG
//    {
//        public uint cbSize;
//        public IntPtr hwndParent;
//        public IntPtr hInstance;
//        public TASKDIALOG_FLAGS dwFlags;
//        public TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszWindowTitle;

//        public IntPtr MainIcon;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszMainInstruction;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszContent;

//        public uint cButtons;

//        public IntPtr pButtons;

//        public int nDefaultButton;
//        public uint cRadioButtons;
//        public IntPtr pRadioButtons;
//        public int nDefaultRadioButton;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        private string pszVerificationText;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszExpandedInformation;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszExpandedControlText;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszCollapsedControlText;

//        public IntPtr FooterIcon;

//        [MarshalAs(UnmanagedType.LPWStr)]
//        public string pszFooter;

//        public TaskDialogCallback pfCallback;
//        public IntPtr lpCallbackData;
//        public uint cxWidth;
//    }

//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
//    public struct TASKDIALOG_BUTTON_RAW
//    {
//        public int nButtonID;

//        public IntPtr pszButtonText;
//    }

//    public delegate int TaskDialogCallback([In] IntPtr hwnd, [In] uint msg, [In] UIntPtr wParam, [In] IntPtr lParam, [In] IntPtr refData);

//}