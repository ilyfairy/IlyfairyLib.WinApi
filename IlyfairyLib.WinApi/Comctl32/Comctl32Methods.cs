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


    [PFTASKDIALOGCALLBACK]
    [return: HRESULT]
    public delegate IntPtr PFTASKDIALOGCALLBACK([HWND, _In_] IntPtr hwnd, [UINT, _In_] uint msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [LONG_PTR, _In_] IntPtr lpRefData);
}