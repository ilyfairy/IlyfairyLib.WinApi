using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Comctl32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [TASKDIALOG_BUTTON]
    public unsafe struct TASKDIALOG_BUTTON
    {
        public int nButtonID;
        [PCWSTR] public char* pszButtonText;
    }
}