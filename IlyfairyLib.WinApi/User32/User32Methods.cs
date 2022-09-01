using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.Gdi32;
using IlyfairyLib.WinApi.WinNT;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
    public static class User32Methods
    {
        #region ActivateKeyboardLayout
        [DllImport("user32.dll")]
        [return: HKL]
        public static extern IntPtr ActivateKeyboardLayout([HKL, _In_] IntPtr hkl, [UINT, _In_] uint Flags);
        #endregion

        #region AddClipboardFormatListener
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AddClipboardFormatListener([HWND, _In_] IntPtr hwnd);
        #endregion

        #region AdjustWindowRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AdjustWindowRect([LPRECT, _Inout_] ref RECT lpRect, [DWORD, _In_] uint dwStyle, [BOOL, _In_] BOOL bMenu);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AdjustWindowRectEx([LPRECT, _Inout_] ref RECT lpRect, [DWORD, _In_] uint dwStyle, [BOOL, _In_] BOOL bMenu, [DWORD, _In_] uint dwExStyle);
        #endregion

        #region AdjustWindowRectExForDpi
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AdjustWindowRectExForDpi([LPRECT, _Inout_] ref RECT lpRect, [DWORD, _In_] uint dwStyle, [BOOL, _In_] BOOL bMenu, [DWORD, _In_] uint dwExStyle, [UINT, _In_] uint dpi);
        #endregion

        #region AllowSetForegroundWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AllowSetForegroundWindow([DWORD, _In_] uint dwProcessId);
        #endregion

        #region AnimateWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AnimateWindow([_In_] IntPtr hwnd, [DWORD, _In_] int time, [DWORD, _In_] AnimateWindowFlags flags);
        #endregion

        #region AnyPopup
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AnyPopup();
        #endregion

        #region AppendMenu
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL AppendMenuA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] MenuFlags uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCSTR, _In_opt_] byte[] lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: BOOL]
        public static extern unsafe BOOL AppendMenuA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] MenuFlags uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCSTR, _In_opt_] byte* lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL AppendMenuW([HMENU, _In_] IntPtr hMenu, [UINT, _In_] MenuFlags uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCWSTR, _In_opt_] string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern unsafe BOOL AppendMenuW([HMENU] IntPtr hMenu, [UINT, _In_] MenuFlags uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCWSTR, _In_opt_] char* lpNewItem);
        #endregion

        #region AreDpiAwarenessContextsEqual
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AreDpiAwarenessContextsEqual([DPI_AWARENESS_CONTEXT, _In_] IntPtr dpiContextA, [DPI_AWARENESS_CONTEXT, _In_] IntPtr dpiContextB);
        #endregion

        #region ArrangeIconicWindows
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint ArrangeIconicWindows([HWND, _In_] IntPtr hWnd);
        #endregion

        #region AttachThreadInput
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern BOOL AttachThreadInput([DWORD, _In_] uint idAttach, [DWORD, _In_] uint idAttachTo, [BOOL, _In_] BOOL fAttach);
        #endregion

        #region BeginDeferWindowPos
        [DllImport("user32.dll")]
        [return: HDWP]
        public static extern IntPtr BeginDeferWindowPos([_In_] int nNumWindows);
        #endregion

        #region BeginPaint
        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr BeginPaint([HWND, _In_] IntPtr hwnd, [LPPAINTSTRUCT, _Out_] out PAINTSTRUCT lpPaint);
        #endregion

        #region BlockInput
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL BlockInput([BOOL] BOOL fBlockIt);
        #endregion

        #region BringWindowToTop
        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL BringWindowToTop([In, HWND] IntPtr hWnd);
        #endregion

        #region BroadcastSystemMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int BroadcastSystemMessageA([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int BroadcastSystemMessageW([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int BroadcastSystemMessageExA([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [PBSMINFO, _Out_] out BSMInfo pbsmInfo);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int BroadcastSystemMessageExW([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [PBSMINFO, _Out_] out BSMInfo pbsmInfo);
        #endregion

        #region BuildReasonArray
        [DllImport("user32.dll")]
        public static extern unsafe BOOL BuildReasonArray(void* REASONDATA, BOOL arg2, BOOL arg3);
        #endregion

        #region CalculatePopupWindowPosition
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CalculatePopupWindowPosition([POINT, Ptr, CONST, _In_] in POINT anchorPoint, [SIZE, Ptr, CONST, _In_] in SIZE windowSize, [UINT, _In_] TrackPopupMenu flags, [RECT, Ptr, _In_opt_] ref RECT excludeRect, [RECT, Ptr, _Out_] out RECT popupWindowPosition);
        #endregion

        #region CallMsgFilter
        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL CallMsgFilterA([LPMSG, _In_] ref MSG lpMsg, [_In_] int nCode);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL CallMsgFilterW([LPMSG, _In_] ref MSG lpMsg, [_In_] int nCode);
        #endregion

        #region CallNextHookEx
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern IntPtr CallNextHookEx([HHOOK, _In_opt_] IntPtr hhk, [_In_] int nCode, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region CallWindowProc
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: LRESULT]
        public static extern IntPtr CallWindowProcA([WNDPROC, _In_] WndProc lpPrevWndFunc, [HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: LRESULT]
        public static extern IntPtr CallWindowProcW([WNDPROC, _In_] WndProc lpPrevWndFunc, [HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region CancelShutdown
        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern int CancelShutdown();
        #endregion

        #region CascadeWindows
        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort CascadeWindows([HWND, _In_opt_] IntPtr hwndParent, [UINT, _In_] uint wHow, [RECT, Ptr, CONST, _In_opt_] IntPtr lpRect, [UINT, _In_] uint cKids, [HWND, Ptr, CONST, _In_reads_opt_] IntPtr[] lpKids);
        #endregion

        #region ChangeClipboardChain
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ChangeClipboardChain([HWND, _In_] IntPtr hWndRemove, [HWND, _In_] IntPtr hWndNewNext);
        #endregion

        #region ChangeDisplaySettings
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: LONG]
        public static extern DISP_CHANGE ChangeDisplaySettingsA([DEVMODEA, Ptr, _In_opt_] ref DEVMODEA devMode, [DWORD, _In_] int flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: LONG]
        public static extern DISP_CHANGE ChangeDisplaySettingsW([DEVMODEW, Ptr, _In_opt_] ref DEVMODEW devMode, [DWORD, _In_] int flags);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: LONG]
        public static extern DISP_CHANGE ChangeDisplaySettingsExA([LPCSTR, _In_opt_] byte[] lpszDeviceName, [DEVMODEA, Ptr, _In_opt_] ref DEVMODEA lpDevMode, [HWND, _Reserved_] IntPtr hwnd, [DWORD, _In_] ChangeDisplaySettingsFlags dwflags, [LPVOID, _In_opt_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: LONG]
        public static extern unsafe DISP_CHANGE ChangeDisplaySettingsExA([LPCSTR, _In_opt_] byte* lpszDeviceName, [DEVMODEA, Ptr, _In_opt_] ref DEVMODEA lpDevMode, [HWND, _Reserved_] IntPtr hwnd, [DWORD, _In_] ChangeDisplaySettingsFlags dwflags, [LPVOID, _In_opt_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: LONG]
        public static extern DISP_CHANGE ChangeDisplaySettingsExW([LPCWSTR, _In_opt_] string lpszDeviceName, [DEVMODEW, Ptr, _In_opt_] ref DEVMODEW lpDevMode, [HWND, _Reserved_] IntPtr hwnd, [DWORD, _In_] ChangeDisplaySettingsFlags dwflags, [LPVOID, _In_opt_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: LONG]
        public static extern unsafe DISP_CHANGE ChangeDisplaySettingsExW([LPCWSTR, _In_opt_] char* lpszDeviceName, [DEVMODEW, Ptr, _In_opt_] ref DEVMODEW lpDevMode, [HWND, _Reserved_] IntPtr hwnd, [DWORD, _In_] ChangeDisplaySettingsFlags dwflags, [LPVOID, _In_opt_] IntPtr lParam);
        #endregion

        #region ChangeMenu
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL ChangeMenuA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint cmd, [LPCSTR, _In_opt_] byte[] lpszNewItem, [UINT, _In_] uint cmdInsert, [UINT, _In_] uint flags);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        [return: BOOL]
        public static extern unsafe BOOL ChangeMenuA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint cmd, [LPCSTR, _In_opt_] byte* lpszNewItem, [UINT, _In_] uint cmdInsert, [UINT, _In_] uint flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL ChangeMenuW([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint cmd, [LPCWSTR, _In_opt_] string lpszNewItem, [UINT, _In_] uint cmdInsert, [UINT, _In_] uint flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern unsafe BOOL ChangeMenuW([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint cmd, [LPCWSTR, _In_opt_] char* lpszNewItem, [UINT, _In_] uint cmdInsert, [UINT, _In_] uint flags);
        #endregion

        #region ChangeWindowMessageFilter
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ChangeWindowMessageFilter([UINT, _In_] uint message, [DWORD, _In_] uint dwFlag);

        [DllImport("user32.dll", ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL ChangeWindowMessageFilterEx([HWND, _In_] IntPtr hwnd, [UINT, _In_] uint message, [DWORD, _In_] uint action, [PCHANGEFILTERSTRUCT] ref ChangeFilterStruct pChangeFilterStruct);
        #endregion

        #region CharLower
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern unsafe IntPtr CharLowerA([LPSTR, _Inout_] byte* lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern unsafe IntPtr CharLowerA([LPSTR, _Inout_] byte[] lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharLowerW([LPWSTR, _Inout_] StringBuilder lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharLowerW([LPWSTR, _Inout_] char[] lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern unsafe IntPtr CharLowerW([LPWSTR, _Inout_] char* lpsz);
        #endregion

        #region CharLowerBuff
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint CharLowerBuffA([LPSTR, _Inout_updates_] byte[] lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern unsafe uint CharLowerBuffA([LPSTR, _Inout_updates_] byte* lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint CharLowerBuffW([LPWSTR, _Inout_updates_] StringBuilder lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint CharLowerBuffW([LPWSTR, _Inout_updates_] char[] lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern unsafe uint CharLowerBuffW([LPWSTR, _Inout_updates_] char* lpsz, [DWORD, _In_] uint cchLength);
        #endregion

        #region CharNext
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern unsafe IntPtr CharNextA([LPCSTR, _In_] byte* lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern IntPtr CharNextA([LPCSTR, _In_] byte[] lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharNextW([LPCWSTR, _In_] string lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharNextW([LPCWSTR, _In_] char[] lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern unsafe IntPtr CharNextW([LPCWSTR, _In_] char* lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern unsafe IntPtr CharNextExA([WORD, _In_] ushort CodePage, [LPCSTR, _In_] byte* lpCurrentChar, [DWORD, _In_] uint dwFlags);

        [DllImport("user32.dll")]
        [return: LPSTR]
        public static extern IntPtr CharNextExA([WORD, _In_] ushort CodePage, [LPCSTR, _In_] byte[] lpCurrentChar, [DWORD, _In_] uint dwFlags);
        #endregion

        #region CharPrev
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern IntPtr CharPrevA([LPCSTR, _In_] IntPtr lpszStart, [LPCSTR, _In_] IntPtr lpszCurrent);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharPrevW([LPCWSTR, _In_] IntPtr lpszStart, [LPCWSTR, _In_] IntPtr lpszCurrent);

        [DllImport("user32.dll")]
        [return: LPSTR]
        public static extern IntPtr CharPrevExA([WORD, _In_] ushort CodePage, [LPCSTR, _In_] IntPtr lpszStart, [LPCSTR, _In_] IntPtr lpszCurrent, [DWORD, _In_] uint dwFlags);
        #endregion

        #region CharToOem
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL CharToOemA([LPCSTR, _In_] byte[] lpszSrc, [LPSTR, _Out_writes_] byte[] lpszDst);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern unsafe BOOL CharToOemA([LPCSTR, _In_] byte* lpszSrc, [LPSTR, _Out_writes_] byte* lpszDst);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CharToOemW([LPCWSTR, _In_] StringBuilder lpszSrc, [LPSTR, _Out_writes_] StringBuilder lpszDst);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CharToOemW([LPCWSTR, _In_] string lpszSrc, [LPSTR, _Out_writes_] StringBuilder lpszDst);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern unsafe BOOL CharToOemW([LPCWSTR, _In_] char* lpszSrc, [LPSTR, _Out_writes_] char* lpszDst);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CharToOemW([LPCWSTR, _In_] char[] lpszSrc, [LPSTR, _Out_writes_] char[] lpszDst);
        #endregion

        #region CharToOemBuff
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL CharToOemBuffA([LPCSTR, _In_] byte[] lpszSrc, [LPSTR, _Out_writes_] byte[] lpszDst, [DWORD, _In_] uint cchDstLength);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern unsafe BOOL CharToOemBuffA([LPCSTR, _In_] byte* lpszSrc, [LPSTR, _Out_writes_] byte* lpszDst, [DWORD, _In_] uint cchDstLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CharToOemBuffW([LPCWSTR, In] StringBuilder lpszSrc, [LPSTR, _Out_writes_] StringBuilder lpszDst, [DWORD, _In_] uint cchDstLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CharToOemBuffW([LPCWSTR, _In_] string lpszSrc, [LPSTR, _Out_writes_] StringBuilder lpszDst, [DWORD, _In_] uint cchDstLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern unsafe BOOL CharToOemBuffW([LPCWSTR, _In_] char* lpszSrc, [LPSTR, _Out_writes_] char* lpszDst, [DWORD, _In_] uint cchDstLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CharToOemBuffW([LPCWSTR, _In_] char[] lpszSrc, [LPSTR, _Out_writes_] char[] lpszDst, [DWORD, _In_] uint cchDstLength);
        #endregion

        #region CharUpper
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern unsafe IntPtr CharUpperA([LPSTR, _Inout_] byte* lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LPSTR]
        public static extern unsafe IntPtr CharUpperA([LPSTR, _Inout_] byte[] lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharUpperW([LPWSTR, _Inout_] StringBuilder lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern IntPtr CharUpperW([LPWSTR, _Inout_] char[] lpsz);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LPWSTR]
        public static extern unsafe IntPtr CharUpperW([LPWSTR, _Inout_] char* lpsz);
        #endregion

        #region CharUpperBuff
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint CharUpperBuffA([LPSTR, _Inout_updates_] byte[] lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern unsafe uint CharUpperBuffA([LPSTR, _Inout_updates_] byte* lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint CharUpperBuffW([LPWSTR, _Inout_updates_] StringBuilder lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint CharUpperBuffW([LPWSTR, _Inout_updates_] char[] lpsz, [DWORD, _In_] uint cchLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern unsafe uint CharUpperBuffW([LPWSTR, _Inout_updates_] char* lpsz, [DWORD, _In_] uint cchLength);
        #endregion

        #region CheckDBCSEnabledExt
        [DllImport("user32.dll")]
        public static extern BOOL CheckDBCSEnabledExt();
        #endregion

        #region CheckDlgButton
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CheckDlgButton([HWND, _In_] IntPtr hDlg, [_In_] int nIDButton, [UINT, _In_] uint uCheck);
        #endregion

        #region CheckMenuItem
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint CheckMenuItem([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDCheckItem, [UINT, _In_] uint uCheck);
        #endregion

        #region CheckMenuRadioItem
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CheckMenuRadioItem([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint first, [UINT, _In_] uint last, [UINT, _In_] uint check, [UINT, _In_] uint flags);
        #endregion

        #region CheckRadioButton
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CheckRadioButton([HWND, _In_] IntPtr hDlg, [_In_] int nIDFirstButton, [_In_] int nIDLastButton, [_In_] int nIDCheckButton);
        #endregion

        #region ChildWindowFromPoint
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr ChildWindowFromPoint([HWND, _In_] IntPtr hWndParent, [POINT, _In_] POINT Point);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr ChildWindowFromPointEx([HWND, _In_] IntPtr hWndParent, [POINT, _In_] POINT Point, [UINT, _In_] uint flags);
        #endregion

        #region ClientToScreen
        [DllImport("user32.dll", ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL ClientToScreen([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);
        #endregion

        #region CliImmSetHotKey
        [DllImport("user32.dll")]
        public static extern BOOL CliImmSetHotKey(uint dwID, uint uModifiers, uint uVirtualKey, IntPtr hKl);
        #endregion

        #region ClipCursor
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ClipCursor([RECT, Ptr, CONST, _In_opt_] in RECT lpRect);
        #endregion

        #region CloseClipboard
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseClipboard();
        #endregion

        #region CloseDesktop
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseDesktop([HDESK, _In_] IntPtr hDesktop);
        #endregion

        #region CloseGestureInfoHandle
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseGestureInfoHandle([HGESTUREINFO, _In_] IntPtr hGestureInfo);
        #endregion

        #region CloseTouchInputHandle
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseTouchInputHandle([HTOUCHINPUT, _In_] IntPtr hTouchInput);
        #endregion

        #region CloseWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region CloseWindowStation
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseWindowStation([HWINSTA, _In_] IntPtr hWinSta);
        #endregion

        #region ConsoleControl
        [DllImport("user32.dll")]
        public static extern unsafe BOOL ConsoleControl(ConsoleControlType command, void* information, uint length);
        #endregion

        #region CopyAcceleratorTable
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern unsafe int CopyAcceleratorTableA([HACCEL, _In_] IntPtr hAccelSrc, [LPACCEL, _Out_writes_to_opt_] Accel[] lpAccelDst, [_In_] int cAccelEntries);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int CopyAcceleratorTableW([HACCEL, _In_] IntPtr hAccelSrc, [LPACCEL, _Out_writes_to_opt_] Accel[] lpAccelDst, [_In_] int cAccelEntries);
        #endregion

        #region CopyIcon
        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CopyIcon([HICON, _In_] IntPtr hIcon);
        #endregion

        #region CopyImage
        [DllImport("user32.dll", SetLastError = true)]
        [return: HANDLE]
        public static extern IntPtr CopyImage([HANDLE, _In_] IntPtr hImage, [UINT, _In_] uint uType, [_In_] int cxDesired, [_In_] int cyDesired, [UINT, _In_] uint fuFlags);
        #endregion

        #region CopyRect
        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL CopyRect([LPRECT, Out] out RECT lprcDst, [RECT, CONST, _In_] in RECT lprcSrc);
        #endregion

        #region CountClipboardFormats
        [DllImport("user32.dll")]
        public static extern int CountClipboardFormats();
        #endregion

        #region CreateAcceleratorTable
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HACCEL]
        public static extern IntPtr CreateAcceleratorTableA([LPACCEL, _In_reads_] Accel[] paccel, [_In_] int cAccel);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HACCEL]
        public static extern IntPtr CreateAcceleratorTableW([LPACCEL, _In_reads_] Accel[] paccel, [_In_] int cAccel);
        #endregion

        #region CreateCaret
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CreateCaret([HWND, In] IntPtr hWnd, [HBITMAP, _In_opt_] IntPtr hBitmap, [_In_] int nWidth, [_In_] int nHeight);
        #endregion

        #region CreateCursor
        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern IntPtr CreateCursor([HINSTANCE, _In_opt_] IntPtr hInst, [_In_] int xHotSpot, [_In_] int yHotSpot, [_In_] int nWidth, [_In_] int nHeight, [VOID, CONST, Ptr, _In_] byte[] pvANDPlane, [VOID, CONST, Ptr, _In_] byte[] pvXORPlane);
        #endregion

        #region CreateDesktop
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HDESK]
        public static extern IntPtr CreateDesktopA([LPCSTR, _In_] byte[] lpszDesktop, [LPCSTR, _Reserved_] byte[] lpszDevice, [DEVMODEA, Ptr, _Reserved_] ref DEVMODEA pDevmode, [DWORD, _In_] uint dwFlags, [ACCESS_MASK, _In_] uint dwDesiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] ref SECURITY_ATTRIBUTES lpsa);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDESK]
        public static extern IntPtr CreateDesktopW([LPCWSTR, _In_] string lpszDesktop, [LPCWSTR, _Reserved_] string lpszDevice, [DEVMODEW, Ptr, _Reserved_] ref DEVMODEW pDevmode, [DWORD, _In_] uint dwFlags, [ACCESS_MASK, _In_] uint dwDesiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] ref SECURITY_ATTRIBUTES lpsa);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDESK]
        public static extern IntPtr CreateDesktopW([LPCWSTR, _In_] char[] lpszDesktop, [LPCWSTR, _Reserved_] char[] lpszDevice, [DEVMODEW, Ptr, _Reserved_] ref DEVMODEW pDevmode, [DWORD, _In_] uint dwFlags, [ACCESS_MASK, _In_] uint dwDesiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] ref SECURITY_ATTRIBUTES lpsa);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HDESK]
        public static extern IntPtr CreateDesktopExA([LPCSTR, _In_] byte[] lpszDesktop, [LPCSTR, _Reserved_] byte[] lpszDevice, [DEVMODEA, Ptr, _Reserved_] ref DEVMODEA pDevmode, [DWORD, _In_] uint dwFlags, [ACCESS_MASK, _In_] uint dwDesiredAccess, [LPSECURITY_ATTRIBUTES, _Inout_] ref SECURITY_ATTRIBUTES lpsa, [ULONG, _In_] uint ulHeapSize, [PVOID, _Reserved_] IntPtr pvoid);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDESK]
        public static extern IntPtr CreateDesktopExW([LPCWSTR, _In_] string lpszDesktop, [LPCWSTR, _Reserved_] string lpszDevice, [DEVMODEW, Ptr, _Reserved_] ref DEVMODEW pDevmode, [DWORD, _In_] uint dwFlags, [ACCESS_MASK, _In_] uint dwDesiredAccess, [LPSECURITY_ATTRIBUTES, _Inout_] ref SECURITY_ATTRIBUTES lpsa, [ULONG, _In_] uint ulHeapSize, [PVOID, _Reserved_] IntPtr pvoid);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDESK]
        public static extern IntPtr CreateDesktopExW([LPCWSTR, _In_] char[] lpszDesktop, [LPCWSTR, _Reserved_] char[] lpszDevice, [DEVMODEW, Ptr, _Reserved_] ref DEVMODEW pDevmode, [DWORD, _In_] uint dwFlags, [ACCESS_MASK, _In_] uint dwDesiredAccess, [LPSECURITY_ATTRIBUTES, _Inout_] ref SECURITY_ATTRIBUTES lpsa, [ULONG, _In_] uint ulHeapSize, [PVOID, _Reserved_] IntPtr pvoid);
        #endregion

        #region CreateDialogIndirectParam
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr CreateDialogIndirectParamA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCDLGTEMPLATEA, _In_] ref DlgTemplate lpTemplate, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr CreateDialogIndirectParamW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCDLGTEMPLATEW, _In_] ref DlgTemplate lpTemplate, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);
        #endregion

        #region CreateDialogParam
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern void CreateDialogParamA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpTemplateName, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern void CreateDialogParamW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpTemplateName, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);
        #endregion

        #region CreateIcon
        [DllImport("user32.dll")]
        [return: HICON]
        public static extern unsafe IntPtr CreateIcon([HINSTANCE, _In_opt_] IntPtr piconinfo, [_In_] int nWidth, [_In_] int nHeight, [BYTE, _In_] byte cPlanes, [BYTE, _In_] byte cBitsPixel, [BYTE, Ptr, CONST, _In_] byte* lpbANDbits, [BYTE, Ptr, CONST, _In_] byte* lpbXORbits);
        #endregion

        #region CreateIconFromResource
        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CreateIconFromResource([PBYTE, _In_reads_bytes_] byte[] presbits, [DWORD, _In_] uint dwResSize, [BOOL, _In_] BOOL fIcon, [DWORD, _In_] uint dwVer);

        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CreateIconFromResourceEx([PBYTE, _In_reads_bytes_] byte[] presbits, [DWORD, _In_] uint dwResSize, [BOOL, _In_] BOOL fIcon, [DWORD, _In_] uint dwVer, [_In_] int cxDesired, [_In_] int cyDesired, [UINT, _In_] uint Flags);
        #endregion

        #region CreateIconIndirect
        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CreateIconIndirect([PICONINFO, _In_] ref IconInfo piconinfo);
        #endregion

        #region CreateMDIWindow
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HWND]
        public static extern IntPtr CreateMDIWindowA([LPCSTR, _In_] byte[] lpClassName, [LPCSTR, _In_] byte[] lpWindowName, [DWORD, _In_] uint dwStyle, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hwndParent, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HWND]
        public static extern IntPtr CreateMDIWindowW([LPCWSTR, _In_] string lpClassName, [LPCWSTR, _In_] string lpWindowName, [DWORD, _In_] uint dwStyle, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hwndParent, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region CreateMenu
        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr CreateMenu();
        #endregion

        #region CreatePopupMenu
        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr CreatePopupMenu();
        #endregion

        #region CreateSyntheticPointerDevice
        [DllImport("user32.dll")]
        [return: HSYNTHETICPOINTERDEVICE]
        public static extern IntPtr CreateSyntheticPointerDevice([POINTER_INPUT_TYPE, _In_] PointerInputType pointerType, [ULONG, _In_] uint maxCount, [POINTER_FEEDBACK_MODE, _In_] PointerFeedbackMode mode);
        #endregion

        #region CreateWindowEx
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        [return: HWND]
        public static extern IntPtr CreateWindowExA([DWORD, _In_] WindowStyleEx dwExStyle, [LPCSTR, _In_opt_] byte[] lpClassName, [LPCSTR, _In_opt_] byte[] lpWindowName, [DWORD, _In_] WindowStyle dwStyle, [_In_] int x, [_In_] int y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hWndParent, [HMENU, _In_opt_] IntPtr hMenu, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPVOID, _In_opt_] IntPtr lpParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: HWND]
        public static extern IntPtr CreateWindowExW([DWORD, _In_] WindowStyleEx dwExStyle, [LPCWSTR, _In_opt_] string regClassResult, [LPCWSTR, _In_opt_] string lpWindowName, [DWORD, _In_] WindowStyle dwStyle, [_In_] int x, [_In_] int y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hWndParent, [HMENU, _In_opt_] IntPtr hMenu, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPVOID, _In_opt_] IntPtr pvParam);
        #endregion

        #region CreateWindowInBand
        // NOTE: undocumented
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: HWND]
        public static extern IntPtr CreateWindowInBand([DWORD, _In_] WindowStyleEx dwExStyle, [LPCWSTR, _In_opt_] string regClassResult, [LPCWSTR, _In_opt_] string lpWindowName, [DWORD, _In_] WindowStyle dwStyle, [_In_] int x, [_In_] int y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hWndParent, [HMENU, _In_opt_] IntPtr hMenu, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPVOID, _In_opt_] IntPtr pvParam, [DWORD, _In_] int dwFlags = 0);

        // NOTE: undocumented
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: HWND]
        public static extern IntPtr CreateWindowInBandEx([DWORD, _In_] WindowStyleEx dwExStyle, [LPCWSTR, _In_opt_] string regClassResult, [LPCWSTR, _In_opt_] string lpWindowName, [DWORD, _In_] WindowStyle dwStyle, [_In_] int x, [_In_] int y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hWndParent, [HMENU, _In_opt_] IntPtr hMenu, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPVOID, _In_opt_] IntPtr pvParam, [DWORD, _In_] int dwFlags = 0, [_In_] int unk = 0);
        #endregion

        #region CreateWindowIndirect
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: HWND]
        public static extern IntPtr CreateWindowIndirect([_In_] ref WNDCREATESTRUCTW wnd); // NOTE: undocumented
        #endregion

        #region CreateWindowStation
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr CreateWindowStationA([LPCSTR, _In_opt_] string name, [DWORD, _In_] uint flags, [ACCESS_MASK, _In_] uint desiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] IntPtr securityAttrs);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateWindowStationW([LPCWSTR, _In_opt_] string name, [DWORD, _In_] uint flags, [ACCESS_MASK, _In_] uint desiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] IntPtr securityAttrs);
        #endregion

        #region DdeAbandonTransaction
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeAbandonTransaction([DWORD, _In_] uint idInst, [HCONV, _In_] IntPtr hConv, [DWORD, _In_] uint idTransaction);
        #endregion

        #region DdeAccessData
        [DllImport("user32.dll")]
        [return: LPBYTE]
        public static extern IntPtr DdeAccessData([HDDEDATA, _In_] IntPtr hData, [LPDWORD, _Out_opt_] out uint pcbDataSize);
        #endregion

        #region DdeAddData
        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeAddData([HDDEDATA, _In_] IntPtr hData, [LPBYTE, _In_reads_bytes_] byte[] pSrc, [DWORD, _In_] uint cb, [DWORD, _In_] uint cbOff);
        #endregion

        #region DdeClientTransaction
        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeClientTransaction([LPBYTE, _In_opt_] IntPtr pData, [DWORD, _In_] uint cbData, [HCONV, _In_] IntPtr hConv, [HSZ, _In_opt_] IntPtr hszItem, [UINT, _In_] uint wFmt, [UINT, _In_] uint wType, [DWORD, _In_] uint dwTimeout, [_Out_opt_, LPDWORD] ref uint pdwResult);
        #endregion

        #region DdeCmpStringHandles
        [DllImport("user32.dll")]
        public static extern int DdeCmpStringHandles([HSZ, _In_] IntPtr hsz1, [HSZ, _In_] IntPtr hsz2);
        #endregion

        #region DdeConnect
        [DllImport("user32.dll")]
        [return: HCONV]
        public static extern IntPtr DdeConnect([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hszService, [HSZ, _In_] IntPtr hszTopic, [PCONVCONTEXT, _In_opt_] IntPtr pCC);
        #endregion

        #region DdeConnectList
        [DllImport("user32.dll")]
        [return: HCONVLIST]
        public static extern IntPtr DdeConnectList([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hszService, [HSZ, _In_] IntPtr hszTopic, [HCONVLIST, _In_] IntPtr hConvList, [PCONVCONTEXT, _In_opt_] in ConvContext pCC);
        #endregion

        #region DdeCreateDataHandle
        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeCreateDataHandle([DWORD, _In_] uint idInst, [LPBYTE, _In_reads_bytes_opt_] IntPtr pSrc, [DWORD, _In_] uint cb, [DWORD, _In_] uint cbOff, [HSZ, _Inout_] IntPtr hszItem, [UINT, _In_] uint wFmt, [UINT, _In_] uint afCmd);
        #endregion

        #region DdeCreateStringHandle
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HSZ]
        public static extern IntPtr DdeCreateStringHandleA([DWORD, _In_] uint idInst, [LPCSTR, _In_] byte[] psz, [_In_] int iCodePage);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HSZ]
        public static extern IntPtr DdeCreateStringHandleW([DWORD, _In_] uint idInst, [LPCWSTR, _In_] string psz, [_In_] int iCodePage);
        #endregion

        #region DdeDisconnect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeDisconnect([HCONV, _In_] IntPtr hConv);
        #endregion

        #region DdeDisconnectList
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeDisconnectList([HCONVLIST, _In_] IntPtr hConvList);
        #endregion

        #region DdeEnableCallback
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeEnableCallback([DWORD, _In_] uint idInst, [HCONV, _In_] IntPtr hConv, [UINT, _In_] uint wCmd);
        #endregion

        #region DdeFreeDataHandle
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeFreeDataHandle([HDDEDATA, _In_] IntPtr hData);
        #endregion

        #region DdeFreeStringHandle
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeFreeStringHandle([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz);
        #endregion

        #region DdeGetData
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint DdeGetData([HDDEDATA, _In_] IntPtr hData, [LPBYTE, _Out_writes_bytes_opt_] byte[] pDst, [DWORD, _In_] uint cbMax, [DWORD, _In_] uint cbOff);
        #endregion

        #region DdeGetLastError
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint DdeGetLastError([DWORD, _In_] uint idInst);
        #endregion

        #region DdeImpersonateClient
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeImpersonateClient([HCONV, _In_] IntPtr hConv);
        #endregion

        #region DdeInitialize
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint DdeInitializeA([LPDWORD, _Inout_] ref uint pidInst, [PFNCALLBACK, _In_] PfnCallback pfnCallback, [DWORD, _In_] uint afCmd, [DWORD, _Reserved_] uint ulRes);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint DdeInitializeW([LPDWORD, _Inout_] ref uint pidInst, [PFNCALLBACK, _In_] PfnCallback pfnCallback, [DWORD, _In_] uint afCmd, [DWORD, _Reserved_] uint ulRes);
        #endregion

        #region DdeKeepStringHandle
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeKeepStringHandle([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz);
        #endregion

        #region DdeNameService
        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeNameService([DWORD, _In_] uint idInst, [HSZ, _In_opt_] IntPtr hsz1, [HSZ, _In_opt_] IntPtr hsz2, [UINT, _In_] uint afCmd);
        #endregion

        #region DdePostAdvise
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdePostAdvise([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hszTopic, [HSZ, _In_] IntPtr hszItem);
        #endregion

        #region DdeQueryConvInfo
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint DdeQueryConvInfo([HCONV, _In_] IntPtr hConv, [DWORD, _In_] uint idTransaction, [PCONVINFO, _Inout_] ref ConvInfo pConvInfo);
        #endregion

        #region DdeQueryNextServer
        [DllImport("user32.dll")]
        [return: HCONV]
        public static extern IntPtr DdeQueryNextServer([HCONVLIST, _In_] IntPtr hConvList, [HCONV, _In_] IntPtr hConvPrev);
        #endregion

        #region DdeQueryString
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint DdeQueryStringA([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz, [LPSTR, _Out_writes_opt_] byte[] psz, [DWORD, _In_] uint cchMax, [_In_] int iCodePage);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint DdeQueryStringW([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz, [LPWSTR, _Out_writes_opt_] StringBuilder psz, [DWORD, _In_] uint cchMax, [_In_] int iCodePage);
        #endregion

        #region DdeReconnect
        [DllImport("user32.dll")]
        [return: HCONV]
        public static extern IntPtr DdeReconnect([HCONV, _In_] IntPtr hConv);
        #endregion

        #region DdeSetQualityOfService
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeSetQualityOfService([HWND] IntPtr hwndClient, [SECURITY_QUALITY_OF_SERVICE, Ptr, CONST] in SECURITY_QUALITY_OF_SERVICE pqosNew, [PSECURITY_QUALITY_OF_SERVICE] out SECURITY_QUALITY_OF_SERVICE pqosPrev);
        #endregion

        #region DdeSetUserHandle
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeSetUserHandle([HCONV, _In_] IntPtr hConv, [DWORD, _In_] uint id, [DWORD_PTR, _In_] IntPtr hUser);
        #endregion

        #region DdeUnaccessData
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeUnaccessData([HDDEDATA, _In_] IntPtr hData);
        #endregion

        #region DdeUninitialize
        [DllImport("user32.dll", ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL DdeUninitialize([DWORD, _In_] uint idInst);
        #endregion

        #region DefDlgProc
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr DefDlgProcA([HWND, _In_] IntPtr hDlg, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr DefDlgProcW([HWND, _In_] IntPtr hDlg, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region DeferWindowPos
        [DllImport("user32.dll")]
        [return: HDWP]
        public static extern IntPtr DeferWindowPos([HDWP, _In_] IntPtr hWinPosInfo, [HWND, _In_] IntPtr hWnd, [HWND, _In_opt_] IntPtr hWndInsertAfter, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);
        #endregion

        #region DefFrameProc
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr DefFrameProcA([HWND, _In_] IntPtr hWnd, [HWND, _In_opt_] IntPtr hWndMDIClient, [UINT, _In_] uint uMsg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr DefFrameProcW([HWND, _In_] IntPtr hWnd, [HWND, _In_opt_] IntPtr hWndMDIClient, [UINT, _In_] uint uMsg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region DefMDIChildProc
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr DefMDIChildProcA([HWND, _In_] IntPtr hWnd, [UINT, _In_] IntPtr uMsg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr DefMDIChildProcW([HWND, _In_] IntPtr hWnd, [UINT, _In_] IntPtr uMsg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region DefRawInputProc
        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr DefRawInputProc([PRAWINPUT, Ptr, _In_reads_] RawInput[] paRawInput, [INT, _In_] int nInput, [UINT, _In_] uint cbSizeHeader);
        #endregion

        #region DefWindowProc
        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr DefWindowProcA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr DefWindowProcW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region DeleteMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DeleteMenu([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags);
        #endregion

        #region DeregisterShellHookWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DeregisterShellHookWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region DestroyAcceleratorTable
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyAcceleratorTable([HACCEL, _In_] IntPtr hAccel);
        #endregion

        #region DestroyCaret
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyCaret();
        #endregion

        #region DestroyCursor
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyCursor([HCURSOR, _In_] IntPtr hCursor);
        #endregion

        #region DestroyIcon
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyIcon([HICON, _In_] IntPtr hIcon);
        #endregion

        #region DestroyMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyMenu([HMENU, _In_] IntPtr hMenu);
        #endregion

        #region DestroySyntheticPointerDevice
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void DestroySyntheticPointerDevice([HSYNTHETICPOINTERDEVICE, _In_] IntPtr device);
        #endregion

        #region DestroyWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region DialogBoxIndirectParam
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: INT_PTR]
        public static extern IntPtr DialogBoxIndirectParamA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCDLGTEMPLATEA, _In_] in DlgTemplate hDialogTemplate, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: INT_PTR]
        public static extern IntPtr DialogBoxIndirectParamW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCDLGTEMPLATEW, _In_] in DlgTemplate hDialogTemplate, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);
        #endregion

        #region DialogBoxParam
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: INT_PTR]
        public static extern IntPtr DialogBoxParamA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpTemplateName, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: INT_PTR]
        public static extern IntPtr DialogBoxParamW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] string lpTemplateName, [HWND, _In_opt_] IntPtr hWndParent, [DLGPROC, _In_opt_] DLGProc lpDialogFunc, [LPARAM, _In_] IntPtr dwInitParam);
        #endregion

        #region DisableProcessWindowsGhosting
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void DisableProcessWindowsGhosting();
        #endregion

        #region DispatchMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr DispatchMessageA([MSG, Ptr, CONST, _In_] in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr DispatchMessageW([MSG, Ptr, CONST, _In_] in MSG lpMsg);
        #endregion

        #region DisplayConfigGetDeviceInfo
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int DisplayConfigGetDeviceInfo([DISPLAYCONFIG_DEVICE_INFO_HEADER, Ptr, _Inout_] ref DisplayConfigDeviceInfoHeader requestPacket);
        #endregion

        #region DisplayConfigSetDeviceInfo
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int DisplayConfigSetDeviceInfo([DISPLAYCONFIG_DEVICE_INFO_HEADER, Ptr, _In_] in DisplayConfigDeviceInfoHeader setPacket);
        #endregion

        #region DlgDirList
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int DlgDirListA([HWND, _In_] IntPtr hDlg, [LPSTR, _Inout_] byte[] lpPathSpec, [_In_] int nIDListBox, [_In_] int nIDStaticPath, [UINT, _In_] uint uFileType);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int DlgDirListW([HWND, _In_] IntPtr hDlg, [LPWSTR, _Inout_] StringBuilder lpPathSpec, [_In_] int nIDListBox, [_In_] int nIDStaticPath, [UINT, _In_] uint uFileType);
        #endregion

        #region DlgDirListComboBox
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern void DlgDirListComboBoxA([HWND, _In_] IntPtr hDlg, [LPSTR, _Inout_] byte[] lpPathSpec, [_In_] int nIDComboBox, [_In_] int nIDStaticPath, [UINT, _In_] uint uFiletype);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern void DlgDirListComboBoxW([HWND, _In_] IntPtr hDlg, [LPWSTR, _Inout_] StringBuilder lpPathSpec, [_In_] int nIDComboBox, [_In_] int nIDStaticPath, [UINT, _In_] uint uFiletype);
        #endregion

        #region DlgDirSelectComboBoxEx
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL DlgDirSelectComboBoxExA([HWND, _In_] IntPtr hwndDlg, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int cchOut, [_In_] int idComboBox);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL DlgDirSelectComboBoxExW([HWND, _In_] IntPtr hwndDlg, [LPWSTR, _Out_writes_] StringBuilder lpString, [_In_] int cchOut, [_In_] int idComboBox);
        #endregion

        #region DlgDirSelectEx
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL DlgDirSelectExA([HWND, _In_] IntPtr hwndDlg, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int chCount, [_In_] int idListBox);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL DlgDirSelectExW([HWND, _In_] IntPtr hwndDlg, [LPWSTR, _Out_writes_] StringBuilder lpString, [_In_] int chCount, [_In_] int idListBox);
        #endregion

        #region DragDetect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DragDetect([HWND, _In_] IntPtr hwnd, [POINT, _In_] POINT pt);
        #endregion

        #region DragObject
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint DragObject([HWND, _In_] IntPtr hwndParent, [HWND, _In_] IntPtr hwndFrom, [UINT, _In_] uint fmt, [ULONG_PTR, _In_] UIntPtr data, [HCURSOR, _In_opt_] IntPtr hcur);
        #endregion

        #region DrawAnimatedRects
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawAnimatedRects([HWND, _In_opt_] IntPtr hwnd, [_In_] int idAni, [RECT, Ptr, CONST, _In_] in RECT lprcFrom, [RECT, Ptr, CONST, _In_] in RECT lprcTo);
        #endregion

        #region DrawCaption
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: BOOL]
        public static extern BOOL DrawCaption([HWND, _In_] IntPtr hwnd, [HDC, _In_] IntPtr hdc, [LPRECT, _In_] ref RECT lprect, [_In_] DrawCaptionFlags flags);
        #endregion

        #region DrawCaptionTemp
        // NOTE: undocumented
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        [return: BOOL]
        public static extern BOOL DrawCaptionTempA([HWND, _In_] IntPtr hwnd, [HDC, _In_] IntPtr hdc, [LPRECT, _In_] ref RECT lprect, [HICON, _In_] IntPtr hFont, [HICON, _In_] IntPtr hIcon, [LPCSTR, _In_] byte[] lpszTitle, [UINT, _In_] DrawCaptionFlags flags);

        // NOTE: undocumented
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: BOOL]
        public static extern BOOL DrawCaptionTempW([HWND, _In_] IntPtr hwnd, [HDC, _In_] IntPtr hdc, [LPRECT, _In_] ref RECT lprect, [HICON, _In_] IntPtr hFont, [HICON, _In_] IntPtr hIcon, [LPCWSTR, _In_] string lpszTitle, [UINT, _In_] DrawCaptionFlags flags);
        #endregion

        #region DrawEdge
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawEdge([HDC, _In_] IntPtr hdc, [LPRECT, _Inout_] ref RECT qrc, [UINT, _In_] uint edge, [UINT, _In_] uint grfFlags);
        #endregion

        #region DrawFocusRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawFocusRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc);
        #endregion

        #region DrawFrameControl
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawFrameControl([HDC, _In_] IntPtr hdc, [LPRECT, _Inout_] ref RECT rect, [UINT, _In_] uint arg3, [UINT, _In_] uint arg4);
        #endregion

        #region DrawIcon
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawIcon([HDC, _In_] IntPtr hDC, [_In_] int X, [_In_] int Y, [HICON, _In_] IntPtr hIcon);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawIconEx([HDC, _In_] IntPtr hdc, [_In_] int xLeft, [_In_] int yTop, [HICON, _In_] IntPtr hIcon, [_In_] int cxWidth, [_In_] int cyWidth, [UINT, _In_] uint istepIfAniCur, [HBRUSH, _In_opt_] IntPtr hbrFlickerFreeDraw, [UINT, _In_] uint diFlags);
        #endregion

        #region DrawMenuBar
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawMenuBar([HWND, _In_] IntPtr hWnds);
        #endregion

        #region DrawState
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL DrawStateA([HDC, _In_] IntPtr hdc, [HBRUSH, _In_opt_] IntPtr hbrFore, [DRAWSTATEPROC, _In_opt_] DrawStateProc qfnCallBack, [LPARAM, _In_] IntPtr lData, [WPARAM, _In_] IntPtr wData, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL DrawStateW([HDC, _In_] IntPtr hdc, [HBRUSH, _In_opt_] IntPtr hbrFore, [DRAWSTATEPROC, _In_opt_] DrawStateProc qfnCallBack, [LPARAM, _In_] IntPtr lData, [WPARAM, _In_] IntPtr wData, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);
        #endregion

        #region DrawText
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int DrawTextW([HDC, _In_] IntPtr hdc, [LPCWSTR, _In_] string lpchText, [_In_] int cchText, [LPRECT, _Inout_] ref RECT lprc, [UINT, _In_] DrawTextFormat format);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int DrawTextA([HDC, _In_] IntPtr hdc, [LPCSTR, _In_] byte[] lpchText, [_In_] int cchText, [LPRECT, _Inout_] ref RECT lprc, [UINT, _In_] DrawTextFormat format);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int DrawTextExW([HDC, _In_] IntPtr hdc, [LPCWSTR, _In_] string lpchText, [_In_] int cchText, [LPRECT, _Inout_] ref RECT lprc, [UINT, _In_] DrawTextFormat format, [LPDRAWTEXTPARAMS, _In_opt_] ref DrawTextExtParams lpdtp);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int DrawTextExA([HDC, _In_] IntPtr hdc, [LPCSTR, _In_] byte[] lpchText, [_In_] int cchText, [LPRECT, _Inout_] ref RECT lprc, [UINT, _In_] DrawTextFormat format, [LPDRAWTEXTPARAMS, _In_opt_] ref DrawTextExtParams lpdtp);
        #endregion

        #region EditWndProc
        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: LRESULT]
        public static extern IntPtr EditWndProc([HWND] IntPtr hwnd, [UINT] uint msg, [WPARAM] IntPtr wParam, [LPARAM] IntPtr lParam);
        #endregion

        #region EmptyClipboard
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EmptyClipboard();
        #endregion

        #region EnableMenuItem
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableMenuItem([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDEnableItem, [UINT, _In_] uint uEnable);
        #endregion

        #region EnableMouseInPointer
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableMouseInPointer([BOOL, _In_] BOOL fEnable);
        #endregion

        #region EnableMouseInPointerForThread
        [DllImport("user32.dll", EntryPoint = "#2561")]
        [return: BOOL]
        public static extern BOOL EnableMouseInPointerForThread();
        #endregion

        #region EnableNonClientDpiScaling
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableNonClientDpiScaling([HWND, _In_] IntPtr hwnd);
        #endregion

        #region EnableScrollBar
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableScrollBar([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint wSBflags, [UINT, _In_] uint wArrows);
        #endregion

        #region EnableWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableWindow([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL bEnable);
        #endregion

        #region EndDeferWindowPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndDeferWindowPos([HDWP, _In_] IntPtr hWinPosInfo);
        #endregion

        #region EndDialog
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndDialog([HWND, _In_] IntPtr hDlg, [INT_PTR, _In_] IntPtr nResult);
        #endregion

        #region EndMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndMenu();
        #endregion

        #region ReleaseDC
        [DllImport("user32.dll")]
        public static extern int ReleaseDC([HWND, _In_opt_] IntPtr hWnd, [HDC, _In_] IntPtr hDC);

        #endregion

        #region EndPaint
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndPaint([HWND, _In_] IntPtr hwnd, [LPPAINTSTRUCT, Ptr, CONST, _In_] in PAINTSTRUCT lpPaint);
        #endregion

        #region EndTask
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndTask([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL fShutDown, [BOOL, _In_] BOOL fForce);
        #endregion

        #region EnumChildWindows
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumChildWindows([HWND, _In_opt_] IntPtr hWndParent, [WNDENUMPROC, _In_] WndEnumProc lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumClipboardFormats
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint EnumClipboardFormats([UINT, _In_] uint format);
        #endregion

        #region EnumDesktops
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDesktopsA([HWINSTA, _In_opt_] IntPtr hwinsta, [DESKTOPENUMPROCA, _In_] DesktopEnumProcA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDesktopsW([HWINSTA, _In_opt_] IntPtr hwinsta, [DESKTOPENUMPROCW, _In_] DesktopEnumProcA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumDesktopWindows
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDesktopWindows([HDESK, _In_opt_] IntPtr hDesktop, [WNDENUMPROC, _In_] WndEnumProc lpfn, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumDisplayDevices
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDisplayDevicesA([LPCSTR, _In_opt_] byte[] lpDevice, [DWORD, _In_] uint iDevNum, [PDISPLAY_DEVICEA, _Inout_] ref DisplayDeviceA lpDisplayDevice, [DWORD, _In_] uint dwFlags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDisplayDevicesW([LPCWSTR, _In_opt_] string lpDevice, [DWORD, _In_] uint iDevNum, [PDISPLAY_DEVICEW, _Inout_] ref DisplayDeviceA lpDisplayDevice, [DWORD, _In_] uint dwFlags);
        #endregion

        #region EnumDisplayMonitors
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDisplayMonitors([HDC, _In_opt_] IntPtr hdc, [LPCRECT, _In_opt_] in RECT lprcClip, [MONITORENUMPROC, _In_] MonitorEnumProc lpfnEnum, [LPARAM, _In_] IntPtr dwData);
        #endregion

        #region EnumDisplaySettings
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL EnumDisplaySettingsA([LPCSTR, _In_opt_] byte[] lpszDeviceName, [DWORD, _In_] uint iModeNum, [DEVMODEA, Ptr, _Inout_] ref DEVMODEA lpDevMode);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL EnumDisplaySettingsW([LPCWSTR, _In_opt_] string lpszDeviceName, [DWORD, _In_] uint iModeNum, [DEVMODEW, Ptr, _Inout_] ref DEVMODEW lpDevMode);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL EnumDisplaySettingsExA([LPCSTR, _In_opt_] byte[] lpszDeviceName, [DWORD, _In_] uint iModeNum, [DEVMODEA, _Inout_] ref DEVMODEA lpDevMode, [DWORD, _In_] uint dwFlags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL EnumDisplaySettingsExW([LPCWSTR, _In_opt_] string lpszDeviceName, [DWORD, _In_] uint iModeNum, [DEVMODEW, _Inout_] ref DEVMODEW lpDevMode, [DWORD, _In_] uint dwFlags);
        #endregion

        #region EnumProps
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int EnumPropsA([HWND, _In_] IntPtr hWnd, [PROPENUMPROCA, _In_] PropEnumProcA lpEnumFunc);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int EnumPropsW([HWND, _In_] IntPtr hWnd, [PROPENUMPROCW, _In_] PropEnumProcW lpEnumFunc);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int EnumPropsExA([HWND, _In_] IntPtr hWnd, [PROPENUMPROCEXA, _In_] PropEnumProcExA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int EnumPropsExW([HWND, _In_] IntPtr hWnd, [PROPENUMPROCEXW, _In_] PropEnumProcExW lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumThreadWindows
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumThreadWindows([DWORD, _In_] uint dwThreadId, [WNDENUMPROC, _In_] WndEnumProc lpfn, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumWindows
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumWindows([WNDENUMPROC, _In_] WndEnumProc lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumWindowStations
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL EnumWindowStationsA([WINSTAENUMPROCA, _In_] NameEnumProcA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL EnumWindowStationsW([WINSTAENUMPROCW, _In_] NameEnumProcW lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EqualRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EqualRect([RECT, Ptr, CONST, _In_] in RECT lprc1, [RECT, Ptr, CONST, _In_] in RECT lprc2);
        #endregion

        #region EvaluateProximityToPolygon
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EvaluateProximityToPolygon([UINT32] uint numVertices, [POINT, Ptr, _In_reads_, CONST] POINT[] controlPolygon, [TOUCH_HIT_TESTING_PROXIMITY_EVALUATION, Ptr, _Out_] out TouchHitTestingProximityEvaluation pProximityEval);
        #endregion

        #region EvaluateProximityToRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EvaluateProximityToRect([RECT, Ptr, CONST, _In_] in RECT controlBoundingBox, [TOUCH_HIT_TESTING_INPUT, Ptr, CONST, _In_] in TouchHitTestingInput pHitTestingInput, [TOUCH_HIT_TESTING_PROXIMITY_EVALUATION, Ptr, _Out_] out TouchHitTestingProximityEvaluation pProximityEval);
        #endregion

        #region ExcludeUpdateRgn
        [DllImport("user32.dll")]
        public static extern int ExcludeUpdateRgn([HDC, _In_] IntPtr hDC, [HWND, _In_] IntPtr hWnd);
        #endregion

        #region ExitWindowsEx
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ExitWindowsEx([UINT, _In_] uint uFlags, [DWORD, _In_] uint dwReason);
        #endregion

        #region FillRect
        [DllImport("user32.dll")]
        public static extern int FillRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc, [HBRUSH, _In_] IntPtr hbr);
        #endregion

        #region FindWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr FindWindowA([LPCSTR, _In_opt_] byte[] lpClassName, [LPCSTR, _In_opt_] byte[] lpWindowName);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr FindWindowW([LPCWSTR, _In_opt_] string lpClassName, [LPCWSTR, _In_opt_] string lpWindowName);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr FindWindowExA([HWND, _In_opt_] IntPtr hWndParent, [HWND, _In_opt_] IntPtr hWndChildAfter, [LPCSTR, _In_opt_] byte[] lpszClass, [LPCSTR, _In_opt_] byte[] lpszWindow);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr FindWindowExW([HWND, _In_opt_] IntPtr hWndParent, [HWND, _In_opt_] IntPtr hWndChildAfter, [LPCWSTR, _In_opt_] string lpszClass, [LPCWSTR, _In_opt_] string lpszWindow);
        #endregion

        #region FlashWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL FlashWindow([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL bInvert);
        #endregion

        #region FlashWindowEx
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL FlashWindowEx([PFLASHWINFO, _In_] in FlashWInfo pfwi);
        #endregion

        #region FrameRect
        [DllImport("user32.dll")]
        public static extern int FrameRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc, [HBRUSH, _In_] IntPtr hbr);
        #endregion

        #region FreeDDElParam
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL FreeDDElParam([UINT, _In_] uint msg, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region GetActiveWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetActiveWindow();
        #endregion

        #region GetAltTabInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetAltTabInfo([HWND, _In_opt_] IntPtr hwnd, [_In_] int iItem, [PALTTABINFO, _Inout_] ref ALTTABINFO pati, [LPSTR, _Out_writes_opt_] byte[] pszItemText, [UINT, _In_] uint cchItemText);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetAltTabInfoA([HWND, _In_opt_] IntPtr hwnd, [_In_] int iItem, [PALTTABINFO, _Inout_] ref ALTTABINFO pati, [LPSTR, _Out_writes_opt_] byte[] pszItemText, [UINT, _In_] uint cchItemText);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetAltTabInfoW([HWND, _In_opt_] IntPtr hwnd, [_In_] int iItem, [PALTTABINFO, _Inout_] ref ALTTABINFO pati, [LPWSTR, _Out_writes_opt_] StringBuilder pszItemText, [UINT, _In_] uint cchItemText);
        #endregion

        #region GetAncestor
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetAncestor([HWND, _In_] IntPtr hwnd, [UINT, _In_] uint gaFlags);
        #endregion

        #region GetAsyncKeyState
        [DllImport("user32.dll")]
        [return: SHORT]
        public static extern short GetAsyncKeyState([_In_] int vKey);
        #endregion

        #region GetAutoRotationState
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetAutoRotationState([PAR_STATE] out ArState pState);
        #endregion

        #region GetAwarenessFromDpiAwarenessContext
        [DllImport("user32.dll")]
        [return: DPI_AWARENESS]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr value);
        #endregion

        #region GetCapture
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetCapture();
        #endregion

        #region GetCaretBlinkTime
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetCaretBlinkTime();
        #endregion

        #region GetCaretPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCaretPos([LPPOINT, _Out_] out POINT lpPoint);
        #endregion

        #region GetCIMSSM
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCIMSSM([INPUT_MESSAGE_SOURCE, Ptr, _Out_] out InputMessageSource inputMessageSource);
        #endregion

        #region GetClassInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetClassInfoA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpClassName, [LPWNDCLASSA, _Out_] out WNDCLASSA lpWndClass);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetClassInfoW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpClassName, [LPWNDCLASSW, _Out_] out WNDCLASSW lpWndClass);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetClassInfoExA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpszClass, [LPWNDCLASSEXA, _Out_] out WNDCLASSEXA lpwcx);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetClassInfoExW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpszClass, [LPWNDCLASSEXW, _Out_] out WNDCLASSEXW lpwcx);
        #endregion

        #region GetClassLong
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint GetClassLongA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint GetClassLongW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);
        #endregion

        #region GetClassLongPtr
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: ULONG_PTR]
        public static extern uint GetClassLongPtrA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: ULONG_PTR]
        public static extern uint GetClassLongPtrW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);
        #endregion

        #region GetClassName
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetClassNameA([HWND, _In_] IntPtr hWnd, [LPSTR, _Out_writes_to_] byte[] lpClassName, [_In_] int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetClassNameW([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_to_] StringBuilder lpClassName, [_In_] int nMaxCount);
        #endregion

        #region GetClassWord
        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort GetClassWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);
        #endregion

        #region GetClientRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetClientRect([HWND, _In_] IntPtr hWnd, [LPRECT, _Out_] out RECT lpRect);
        #endregion

        #region GetClipboardData
        [DllImport("user32.dll")]
        [return: HANDLE]
        public static extern IntPtr GetClipboardData([UINT, _In_] uint uFormat);
        #endregion

        #region GetClipboardFormatName
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetClipboardFormatNameA([UINT, _In_] uint format, [LPSTR, _Out_writes_] byte[] lpszFormatName, [_In_] int cchMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetClipboardFormatNameW([UINT, _In_] uint format, [LPWSTR, _Out_writes_] StringBuilder lpszFormatName, [_In_] int cchMaxCount);
        #endregion

        #region GetClipboardOwner
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetClipboardOwner();
        #endregion

        #region GetClipboardSequenceNumber
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetClipboardSequenceNumber();
        #endregion

        #region GetClipboardViewer
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetClipboardViewer();
        #endregion

        #region GetClipCursor
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetClipCursor([LPRECT, _Out_] out RECT lpRect);
        #endregion

        #region GetComboBoxInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetComboBoxInfo([HWND, _In_] IntPtr hwndCombo, [PCOMBOBOXINFO, _Inout_] ref ComboBoxInfo pcbi);
        #endregion

        #region GetCurrentInputMessageSource
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCurrentInputMessageSource([INPUT_MESSAGE_SOURCE, Ptr, _Out_] out InputMessageSource inputMessageSource);
        #endregion

        #region GetCursor
        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern IntPtr GetCursor();
        #endregion

        #region GetCursorPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCursorPos([LPPOINT, _Out_] out POINT lpPoint);
        #endregion

        #region GetDC
        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr GetDC([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region GetDCEx
        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr GetDCEx([HWND, _In_opt_] IntPtr hWnd, [HRGN, _In_opt_] IntPtr hrgnClip, [DWORD, _In_] DCXFlags flags);
        #endregion

        #region GetDesktopWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetDesktopWindow();
        #endregion

        #region GetDialogBaseUnits
        [DllImport("user32.dll")]
        public static extern int GetDialogBaseUnits();
        #endregion

        #region GetDialogControlDpiChangeBehavior
        [DllImport("user32.dll")]
        [return: DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS]
        public static extern DialogControlDpiChangeBehaviors GetDialogControlDpiChangeBehavior([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetDialogDpiChangeBehavior
        [DllImport("user32.dll")]
        [return: DIALOG_DPI_CHANGE_BEHAVIORS]
        public static extern DialogControlDpiChangeBehaviors GetDialogDpiChangeBehavior([HWND, _In_] IntPtr hDlg);
        #endregion

        #region GetDisplayAutoRotationPreferences
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetDisplayAutoRotationPreferences([ORIENTATION_PREFERENCE, Ptr, _Out_] out OrientationPreference pOrientation);
        #endregion

        #region GetDisplayConfigBufferSizes
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int GetDisplayConfigBufferSizes([UINT32, _In_] uint flags, [UINT32, Ptr, _Out_] out uint numPathArrayElements, [UINT32, Ptr, _Out_] out uint numModeInfoArrayElements);
        #endregion

        #region GetDlgCtrlID
        [DllImport("user32.dll")]
        public static extern int GetDlgCtrlID([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetDlgItem
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetDlgItem([HWND, _In_opt_] IntPtr hDlg, [_In_] int nIDDlgItem);
        #endregion

        #region GetDlgItemInt
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDlgItemInt([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [BOOL, Ptr, _Out_opt_] out BOOL lpTranslated, [BOOL, _In_] BOOL bSigned);
        #endregion

        #region GetDlgItemText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint GetDlgItemTextA([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int cchMax);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint GetDlgItemTextW([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPWSTR, _Out_writes_] string lpString, [_In_] int cchMax);
        #endregion

        #region GetDoubleClickTime
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDoubleClickTime();
        #endregion

        #region GetDpiAwarenessContextForProcess
        [DllImport("user32.dll")]
        [return: DPI_AWARENESS_CONTEXT]
        public static extern IntPtr GetDpiAwarenessContextForProcess([HANDLE, _In_] IntPtr hProcess);
        #endregion

        #region GetDpiForSystem
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDpiForSystem();
        #endregion

        #region GetDpiForWindow
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDpiForWindow([HWND, _In_] IntPtr hwnd);
        #endregion

        #region GetDpiFromDpiAwarenessContext
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDpiFromDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr value);
        #endregion

        #region GetFocus
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetFocus();
        #endregion

        #region GetForegroundWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetForegroundWindow();
        #endregion

        #region GetGestureConfig
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetGestureConfig([HWND, _In_] IntPtr hwnd, [DWORD, _In_] uint dwReserved, [DWORD, _In_] uint dwFlags, [PUINT, _In_] in uint pcIDs, [PGESTURECONFIG, _Inout_updates_] ref GestureConfig pGestureConfig, [UINT, _In_] uint cbSize);
        #endregion

        #region GetGestureExtraArgs
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetGestureExtraArgs([HGESTUREINFO, _In_] IntPtr hGestureInfo, [UINT, _In_] uint cbExtraArgs, [PBYTE, _Out_writes_bytes_] byte[] pExtraArgs);
        #endregion

        #region GetGestureInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetGestureInfo([HGESTUREINFO, _In_] IntPtr hGestureInfo, [PGESTUREINFO, _Out_] out GESTUREINFO pGestureInfo);
        #endregion

        #region GetGuiResources
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetGuiResources([HANDLE, _In_] IntPtr hProcess, [DWORD, _In_] uint uiFlags);
        #endregion

        #region GetGUIThreadInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetGUIThreadInfo([DWORD, _In_] uint idThread, [PGUITHREADINFO, _Inout_] ref GUITHREADINFO pgui);
        #endregion

        #region GetIconInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetIconInfo([HICON, _In_] IntPtr hIcon, [PICONINFO, _Out_] out IconInfo piconinfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetIconInfoExA([HICON, _In_] IntPtr hicon, [PICONINFOEXA, _Inout_] ref IconInfoExA piconinfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetIconInfoExW([HICON, _In_] IntPtr hicon, [PICONINFOEXW, _Inout_] ref IconInfoExW piconinfo);
        #endregion

        #region GetInputState
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetInputState();
        #endregion

        #region GetKBCodePage
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetKBCodePage();
        #endregion

        #region GetKeyboardLayout
        [DllImport("user32.dll")]
        [return: HKL]
        public static extern IntPtr GetKeyboardLayout([DWORD, _In_] uint idThread);
        #endregion

        #region GetKeyboardLayoutList
        [DllImport("user32.dll")]
        public static extern int GetKeyboardLayoutList([_In_] int nBuff, [HKL, Ptr, _Out_writes_to_opt_] IntPtr lpList);
        #endregion

        #region GetKeyboardLayoutName
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetKeyboardLayoutNameA([LPSTR, _Out_writes_] byte[] pwszKLID);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetKeyboardLayoutNameW([LPWSTR, _Out_writes_] StringBuilder pwszKLID);
        #endregion

        #region GetKeyboardState
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetKeyboardState([PBYTE, _Out_writes_] byte[] lpKeyState);
        #endregion

        #region GetKeyboardType
        [DllImport("user32.dll")]
        public static extern int GetKeyboardType([_In_] int nTypeFlag);
        #endregion

        #region GetKeyNameText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetKeyNameTextA([LONG, _In_] int lParam, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int cchSize);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetKeyNameTextW([LONG, _In_] int lParam, [LPWSTR, _Out_writes_] StringBuilder lpString, [_In_] int cchSize);
        #endregion

        #region GetKeyState
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetKeyState([_In_] int nVirtKey);
        #endregion

        #region GetLastActivePopup
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetLastActivePopup([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetLastInputInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetLastInputInfo([PLASTINPUTINFO, _Out_] out LASTINPUTINFO plii);
        #endregion

        #region GetLayeredWindowAttributes
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetLayeredWindowAttributes([HWND, _In_] IntPtr hwnd, [COLORREF, Ptr, _Out_opt_] out uint pcrKey, [BYTE, Ptr, _Out_opt_] out byte pbAlpha, [DWORD, Ptr, _Out_opt_] out uint pdwFlags);
        #endregion

        #region GetListBoxInfo
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetListBoxInfo([HWND, _In_] IntPtr hwnd);
        #endregion

        #region GetMenu
        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr GetMenu([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetMenuBarInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetMenuBarInfo([HWND, _In_] IntPtr hwnd, [LONG, _In_] int idObject, [LONG, _In_] int idItem, [PMENUBARINFO, _Inout_] ref MENUBARINFO pmbi);
        #endregion

        #region GetMenuCheckMarkDimensions
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int GetMenuCheckMarkDimensions();
        #endregion

        #region GetMenuContextHelpId
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetMenuContextHelpId([HMENU, _In_] IntPtr hMenu);
        #endregion

        #region GetMenuDefaultItem
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetMenuDefaultItem([HMENU, _In_] IntPtr hMenu, [UINT, _In_] int fByPos, [UINT, _In_] uint gmdiFlags);
        #endregion

        #region GetMenuInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetMenuInfo([HMENU, _In_] IntPtr hMenu, [LPMENUINFO, _Inout_] ref MenuInfo menuInfo);
        #endregion

        #region GetMenuItemCount
        [DllImport("user32.dll")]
        public static extern int GetMenuItemCount([HMENU, _In_opt_] IntPtr hMenu);
        #endregion

        #region GetMenuItemID
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetMenuItemID([HMENU, _In_] IntPtr hMenu, [_In_] int nPos);
        #endregion

        #region GetMenuItemInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetMenuItemInfoA([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint item, [BOOL, _In_] BOOL fByPosition, [LPMENUITEMINFOA, _Inout_] ref MenuItemInfoA lpmii);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetMenuItemInfoW([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint item, [BOOL, _In_] BOOL fByPosition, [LPMENUITEMINFOW, _Inout_] ref MenuItemInfoW lpmii);
        #endregion

        #region GetMenuItemRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetMenuItemRect([HWND, _In_opt_] IntPtr hWnd, [HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uItem, [LPRECT, _Out_] out RECT lprcItem);
        #endregion

        #region GetMenuState
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetMenuState([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uId, [UINT, _In_] uint uFlags);
        #endregion

        #region GetMenuString
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetMenuStringA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDItem, [LPSTR, _Out_writes_opt_] byte[] lpString, [_In_] int cchMax, [UINT, _In_] uint flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetMenuStringW([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDItem, [LPWSTR, _Out_writes_opt_] StringBuilder lpString, [_In_] int cchMax, [UINT, _In_] uint flags);
        #endregion

        #region GetMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetMessageA([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetMessageW([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax);
        #endregion

        #region GetMessageExtraInfo
        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr GetMessageExtraInfo();
        #endregion

        #region GetMessagePos
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetMessagePos();
        #endregion

        #region GetMessageTime
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int GetMessageTime();
        #endregion

        #region GetMonitorInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetMonitorInfoA([HMONITOR, _In_] IntPtr hMonitor, [LPMONITORINFO, _Inout_] ref MonitorInfo lpmi);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetMonitorInfoW([HMONITOR, _In_] IntPtr hMonitor, [LPMONITORINFO, _Inout_] ref MonitorInfo lpmi);
        #endregion

        #region GetMouseMovePointsEx
        [DllImport("user32.dll")]
        public static extern int GetMouseMovePointsEx([UINT, _In_] uint cbSize, [LPMOUSEMOVEPOINT, _In_] in MOUSEMOVEPOINT lppt, [LPMOUSEMOVEPOINT, _Out_writes_] MOUSEMOVEPOINT[] lpptBuf, [_In_] int nBufPoints, [DWORD, _In_] uint resolution);
        #endregion

        #region GetNextDlgGroupItem
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetNextDlgGroupItem([HWND, _In_] IntPtr hDlg, [HWND, _In_opt_] IntPtr hCtl, [BOOL, _In_] BOOL bPrevious);
        #endregion

        #region GetNextDlgTabItem
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetNextDlgTabItem([HWND, _In_] IntPtr hDlg, [HWND, _In_opt_] IntPtr hCtl, [BOOL, _In_] BOOL bPrevious);
        #endregion

        #region GetOpenClipboardWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetOpenClipboardWindow();
        #endregion

        #region GetParent
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetParent([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetPhysicalCursorPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPhysicalCursorPos([LPPOINT, _Out_] out POINT lpPoint);
        #endregion

        #region GetPointerCursorId
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerCursorId([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Out_] out uint cursorId);
        #endregion

        #region GetPointerDeviceCursors
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDeviceCursors([HANDLE, _In_] IntPtr device, [UINT32, Ptr, _Inout_] ref uint cursorCount, [POINTER_DEVICE_CURSOR_INFO, Ptr, _Out_writes_opt_] PointerDeviceCursorInfo[] deviceCursors);
        #endregion

        #region GetPointerDeviceProperties
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDeviceProperties([HANDLE, _In_] IntPtr device, [UINT32, Ptr, _Inout_] ref uint propertyCount, [POINTER_DEVICE_PROPERTY, Ptr, _Out_writes_opt_] PointerDeviceProperty[] pointerProperties);
        #endregion

        #region GetPointerDeviceRects
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDeviceRects([HANDLE, _In_] IntPtr device, [RECT, Ptr, _Out_writes_] out RECT pointerDeviceRect, [RECT, Ptr, _Out_writes_] out RECT displayRect);
        #endregion

        #region GetPointerDevices
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDevices([UINT32, Ptr, _Inout_] uint deviceCount, [POINTER_DEVICE_INFO, Ptr, _Out_writes_opt_] PointerDeviceInfo[] pointerDevices);
        #endregion

        #region GetPointerDevices
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDevices([UINT32, Ptr, _Inout_] ref uint deviceCount, [POINTER_DEVICE_INFO, Ptr, _Out_writes_opt_] PointerDeviceInfo[] pointerDevices);
        #endregion

        #region GetPointerFrameInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameInfo([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_INFO, Ptr, _Out_writes_opt_] PointerInfo[] pointerInfo);
        #endregion

        #region GetPointerFrameInfoHistory
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_INFO, Ptr, _Out_writes_opt_] PointerInfo[] pointerInfo);
        #endregion

        #region GetPointerFramePenInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFramePenInfo([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_PEN_INFO, Ptr, _Out_writes_opt_] PointerPenInfo[] penInfo);
        #endregion

        #region GetPointerFramePenInfoHistory
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFramePenInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_PEN_INFO, Ptr, _Out_writes_opt_] PointerPenInfo[] penInfo);
        #endregion

        #region GetPointerFrameTouchInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameTouchInfo([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_TOUCH_INFO, Ptr, _Out_writes_opt_] PointerTouchInfo[] touchInfo);
        #endregion

        #region GetPointerFrameTouchInfoHistory
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameTouchInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_TOUCH_INFO, Ptr, _Out_writes_opt_] PointerTouchInfo[] touchInfo);
        #endregion

        #region GetPointerInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerInfo([UINT32, _In_] uint pointerId, [POINTER_INFO, Ptr, _Out_writes_] out PointerInfo pointerInfo);
        #endregion

        #region GetPointerInfoHistory
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [POINTER_INFO, Ptr, _Out_writes_opt_] PointerInfo[] pointerInfo);
        #endregion

        #region GetPointerInputTransform
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerInputTransform([UINT32, _In_] uint pointerId, [UINT32, _In_] uint historyCount, [INPUT_TRANSFORM, Ptr, _Out_writes_] InputTransform[] inputTransform);
        #endregion

        #region GetPointerPenInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerPenInfo([UINT32, _In_] uint pointerId, [POINTER_PEN_INFO, Ptr, _Out_writes_] out PointerPenInfo penInfo);
        #endregion

        #region GetPointerPenInfoHistory
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerPenInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [POINTER_PEN_INFO, Ptr, _Out_writes_opt_] PointerPenInfo[] penInfo);
        #endregion

        #region GetPointerTouchInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerTouchInfo([UINT32, _In_] uint pointerId, [POINTER_TOUCH_INFO, Ptr, _Out_writes_] out PointerTouchInfo touchInfo);
        #endregion

        #region GetPointerTouchInfoHistory
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerTouchInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [POINTER_TOUCH_INFO, Ptr, _Out_writes_opt_] PointerTouchInfo[] touchInfo);
        #endregion

        #region GetPointerType
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerType([UINT32, _In_] uint pointerId, [POINTER_INPUT_TYPE, Ptr, _Out_] out PointerInputType pointerType);
        #endregion

        #region GetPriorityClipboardFormat
        [DllImport("user32.dll")]
        public static extern int GetPriorityClipboardFormat([UINT, Ptr, _In_reads_] uint[] paFormatPriorityList, [_In_] int cFormats);
        #endregion

        #region GetProcessDefaultLayout
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetProcessDefaultLayout([DWORD, Ptr, _Out_] out uint pdwDefaultLayout);
        #endregion

        #region GetProcessWindowStation
        [DllImport("user32.dll")]
        [return: HWINSTA]
        public static extern IntPtr GetProcessWindowStation();
        #endregion

        #region GetPropA
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HANDLE]
        public static extern IntPtr GetPropA([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HANDLE]
        public static extern IntPtr GetPropW([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] string lpString);
        #endregion

        #region GetQueueStatus
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetQueueStatus([UINT, _In_] uint flags);
        #endregion

        #region GetRawInputBuffer
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetRawInputBuffer([PRAWINPUT, _Out_writes_bytes_opt_] RawInput[] pData, [PUINT, _Inout_] ref uint pcbSize, [UINT, _In_] uint cbSizeHeader);
        #endregion

        #region GetRawInputData
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetRawInputData([HRAWINPUT, _In_] IntPtr hRawInput, [UINT, _In_] uint uiCommand, [LPVOID, _Out_writes_bytes_to_opt_] byte[] pData, [PUINT, _Inout_] ref uint pcbSize, [UINT, _In_] uint cbSizeHeader);
        #endregion

        #region GetRawInputDeviceInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern unsafe uint GetRawInputDeviceInfoA([HANDLE, _In_opt_] IntPtr hDevice, [UINT, _In_] uint uiCommand, [LPVOID, _Inout_updates_bytes_to_opt_] void* pData, [PUINT, _Inout_] ref uint pcbSize);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern unsafe uint GetRawInputDeviceInfoW([HANDLE, _In_opt_] IntPtr hDevice, [UINT, _In_] uint uiCommand, [LPVOID, _Inout_updates_bytes_to_opt_] void* pData, [PUINT, _Inout_] ref uint pcbSize);
        #endregion

        #region GetRawInputDeviceList
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetRawInputDeviceList([PRAWINPUTDEVICELIST, _Out_writes_opt_] RAWINPUTDEVICELIST[] pRawInputDeviceList, [PUINT, _Inout_] ref uint puiNumDevices, [UINT, _In_] uint cbSize);
        #endregion

        #region GetRawPointerDeviceData
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetRawPointerDeviceData([UINT32, _In_] uint pointerId, [UINT32, _In_] uint historyCount, [UINT32, _In_] uint propertiesCount, [POINTER_DEVICE_PROPERTY, Ptr, _In_reads_] PointerDeviceProperty[] pProperties, [LONG, Ptr, _Out_writes_] int[] pValues);
        #endregion

        #region GetRegisteredRawInputDevices
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetRegisteredRawInputDevices([PRAWINPUTDEVICE, _Out_writes_opt_] RAWINPUTDEVICE[] pRawInputDevices, [PUINT, _Inout_] ref uint puiNumDevices, [UINT, _In_] uint cbSize);
        #endregion

        #region GetScrollBarInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetScrollBarInfo([HWND, _In_] IntPtr hwnd, [LONG, _In_] int idObject, [PSCROLLBARINFO, _Inout_] ref ScrollBarInfo psbi);
        #endregion

        #region GetScrollInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetScrollInfo([HWND, _In_] IntPtr hwnd, [_In_] int nBar, [LPSCROLLINFO, _Inout_] ref ScrollInfo lpsi);
        #endregion

        #region GetScrollPos
        [DllImport("user32.dll")]
        public static extern int GetScrollPos([HWND, _In_] IntPtr hWnd, [_In_] int nBar);
        #endregion

        #region GetScrollRange
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetScrollRange([HWND, _In_] IntPtr hWnd, [_In_] int nBar, [LPINT, _Out_] out int lpMinPos, [LPINT, _Out_] out int lpMaxPos);
        #endregion

        #region GetShellWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetShellWindow();
        #endregion

        #region GetSubMenu
        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr GetSubMenu([HMENU, _In_] IntPtr hMenu, [_In_] int nPos);
        #endregion

        #region GetSysColor
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetSysColor([_In_] int nIndex);
        #endregion

        #region GetSysColorBrush
        [DllImport("user32.dll")]
        [return: HBRUSH]
        public static extern uint GetSysColorBrush([_In_] int nIndex);
        #endregion

        #region GetSystemDpiForProcess
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetSystemDpiForProcess([HANDLE, _In_] IntPtr hProcess);
        #endregion

        #region GetSystemMenu
        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr GetSystemMenu([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL bRevert);
        #endregion

        #region GetSystemMetrics
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics([_In_] int nIndex);
        #endregion

        #region GetSystemMetricsForDpi
        [DllImport("user32.dll")]
        public static extern int GetSystemMetricsForDpi([_In_] int nIndex, [UINT, _In_] uint dpi);
        #endregion

        #region GetTabbedTextExtent
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint GetTabbedTextExtentA([HDC, _In_] IntPtr hdc, [LPCSTR, _In_reads_] byte[] lpString, [_In_] int chCount, [_In_] int nTabPositions, [INT, Ptr, CONST, _In_reads_opt_] int[] lpnTabStopPositions);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint GetTabbedTextExtentW([HDC, _In_] IntPtr hdc, [LPCWSTR, _In_reads_] string lpString, [_In_] int chCount, [_In_] int nTabPositions, [INT, Ptr, CONST, _In_reads_opt_] int[] lpnTabStopPositions);
        #endregion

        #region GetThreadDesktop
        [DllImport("user32.dll")]
        [return: HDESK]
        public static extern IntPtr GetThreadDesktop([DWORD, _In_] uint dwThreadId);
        #endregion

        #region GetThreadDpiAwarenessContext
        [DllImport("user32.dll")]
        [return: DPI_AWARENESS_CONTEXT]
        public static extern IntPtr GetThreadDpiAwarenessContext();
        #endregion

        #region GetThreadDpiHostingBehavior
        [DllImport("user32.dll")]
        [return: DPI_HOSTING_BEHAVIOR]
        public static extern DpiHostingBehavior GetThreadDpiHostingBehavior();
        #endregion

        #region GetTitleBarInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetTitleBarInfo([HWND, _In_] IntPtr hwnd, [PTITLEBARINFO, _Inout_] ref TitleBarInfo pti);
        #endregion

        #region GetTopWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetTopWindow([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region GetTouchInputInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetTouchInputInfo([HTOUCHINPUT, _In_] IntPtr hTouchInput, [UINT, _In_] uint cInputs, [PTOUCHINPUT, _Out_writes_] TouchInput[] pInputs, [_In_] int cbSize);
        #endregion

        #region GetUnpredictedMessagePos
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetUnpredictedMessagePos();
        #endregion

        #region GetUpdatedClipboardFormats
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetUpdatedClipboardFormats([PUINT, _Out_writes_] int[] lpuiFormats, [UINT, _In_] uint cFormats, [PUINT, _Out_] out uint pcFormatsOut);
        #endregion

        #region GetUpdateRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetUpdateRect([HWND, _In_] IntPtr hWnd, [LPRECT, _Out_opt_] out RECT lpRect, [BOOL, _In_] BOOL bErase);
        #endregion

        #region GetUpdateRgn
        [DllImport("user32.dll")]
        public static extern int GetUpdateRgn([HWND, _In_] IntPtr hWnd, [HRGN, _In_] IntPtr hRgn, [BOOL, _In_] BOOL bErase);
        #endregion

        #region GetUserObjectInformation
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetUserObjectInformationA([HANDLE, _In_] IntPtr hObj, [_In_] int nIndex, [PVOID, _Out_writes_bytes_opt_] byte[] pvInfo, [DWORD, _In_] uint nLength, [LPDWORD, _Out_opt_] out uint lpnLengthNeeded);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetUserObjectInformationW([HANDLE, _In_] IntPtr hObj, [_In_] int nIndex, [PVOID, _Out_writes_bytes_opt_] byte[] pvInfo, [DWORD, _In_] uint nLength, [LPDWORD, _Out_opt_] out uint lpnLengthNeeded);
        #endregion

        #region GetUserObjectSecurity
        [DllImport("user32.dll")]
        [return: BOOL]
        public static unsafe extern BOOL GetUserObjectSecurity([HANDLE, _In_] IntPtr hObj, [PSECURITY_INFORMATION, _In_] void* pSIRequested, [PSECURITY_DESCRIPTOR, _Out_writes_bytes_opt_] SECURITY_DESCRIPTOR[] pSID, [DWORD, _In_] uint nLength, [LPDWORD, _Out_] out uint lpnLengthNeeded);
        #endregion

        #region GetWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetWindow([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint uCmd);
        #endregion

        #region GetWindowBand
        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL GetWindowBand([HWND] IntPtr hWnd, [DWORD] ref uint pdwBand);
        #endregion

        #region GetWindowContextHelpId
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetWindowContextHelpId([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetWindowDC
        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr GetWindowDC([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region GetWindowDisplayAffinity
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowDisplayAffinity([HWND, _In_] IntPtr hWnd, [DWORD, Ptr, _Out_] out uint pdwAffinity);
        #endregion

        #region GetWindowDpiAwarenessContext
        [DllImport("user32.dll")]
        [return: DPI_AWARENESS_CONTEXT]
        public static extern IntPtr GetWindowDpiAwarenessContext([HWND, _In_] IntPtr hwnd);
        #endregion

        #region GetWindowDpiHostingBehavior
        [DllImport("user32.dll")]
        [return: DPI_HOSTING_BEHAVIOR]
        public static extern IntPtr GetWindowDpiHostingBehavior([HWND, _In_] IntPtr hwnd);
        #endregion

        #region GetWindowFeedbackSetting
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowFeedbackSetting([HWND, _In_] IntPtr hwnd, [FEEDBACK_TYPE, _In_] FeedbackType feedback, [DWORD, _In_] uint dwFlags, [UINT32, Ptr, _Inout_] ref uint pSize, [VOID, Ptr, _Out_writes_bytes_opt_] byte[] config);
        #endregion

        #region GetWindowInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowInfo([HWND, _In_] IntPtr hWnd, [PWINDOWINFO, _Inout_] ref WindowInfo pwi);
        #endregion

        #region GetWindowLong
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LONG]
        public static extern int GetWindowLongA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LONG]
        public static extern int GetWindowLongW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);
        #endregion

        #region GetWindowLongPtr
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LONG_PTR]
        public static extern IntPtr GetWindowLongPtrA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LONG_PTR]
        public static extern IntPtr GetWindowLongPtrW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);
        #endregion

        #region GetWindowModuleFileName
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint GetWindowModuleFileName([HWND, _In_] IntPtr hwnd, [LPSTR, _Out_writes_to_] byte[] pszFileName, [UINT, _In_] uint cchFileNameMax);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint GetWindowModuleFileNameA([HWND, _In_] IntPtr hwnd, [LPSTR, _Out_writes_to_] byte[] pszFileName, [UINT, _In_] uint cchFileNameMax);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint GetWindowModuleFileNameW([HWND, _In_] IntPtr hwnd, [LPSTR, _Out_writes_to_] StringBuilder pszFileName, [UINT, _In_] uint cchFileNameMax);
        #endregion

        #region GetWindowPlacement
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowPlacement([HWND, _In_] IntPtr hWnd, [WINDOWPLACEMENT, Ptr, _Inout_] ref WindowPlacement lpwndpl);
        #endregion

        #region GetWindowRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowRect([HWND, _In_] IntPtr hWnd, [LPRECT, _Out_] out RECT lpRect);
        #endregion

        #region GetWindowRgn
        [DllImport("user32.dll")]
        public static extern int GetWindowRgn([HWND, _In_] IntPtr hWnd, [HRGN, _In_] IntPtr hRgn);
        #endregion

        #region GetWindowRgnBox
        [DllImport("user32.dll")]
        public static extern int GetWindowRgnBox([HWND, _In_] IntPtr hWnd, [LPRECT, _Out_] out RECT lprc);
        #endregion

        #region GetWindowText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetWindowTextA([HWND, _In_] IntPtr hWnd, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextW([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_] StringBuilder lpString, [_In_] int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextW([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_] char[] lpString, [_In_] int nMaxCount);
        #endregion

        #region GetWindowTextLength
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetWindowTextLengthA([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextLengthW([HWND, _In_] IntPtr hWnd);
        #endregion

        #region GetWindowThreadProcessId
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetWindowThreadProcessId([HWND, _In_] IntPtr hWnd, [LPDWORD, _Out_opt_] out uint lpdwProcessId);
        #endregion

        #region GetWindowWord
        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort GetWindowWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);
        #endregion

        #region GrayString
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GrayStringA([HDC, _In_] IntPtr hDC, [HBRUSH, _In_opt_] IntPtr hBrush, [GRAYSTRINGPROC, _In_opt_] GrayStringProc lpOutputFunc, [LPARAM, _In_] IntPtr lpData, [_In_] int nCount, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GrayStringW([HDC, _In_] IntPtr hDC, [HBRUSH, _In_opt_] IntPtr hBrush, [GRAYSTRINGPROC, _In_opt_] GrayStringProc lpOutputFunc, [LPARAM, _In_] IntPtr lpData, [_In_] int nCount, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight);
        #endregion

        #region HideCaret
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL HideCaret([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region HiliteMenuItem
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL HiliteMenuItem([HWND, _In_] IntPtr hWnd, [HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDHiliteItem, [UINT, _In_] uint uHilite);
        #endregion

        #region ImpersonateDdeClientWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ImpersonateDdeClientWindow([HWND] IntPtr hWndClient, [HWND] IntPtr hWndServer);
        #endregion

        #region InflateRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InflateRect([LPRECT, _Inout_] ref RECT lprc, [_In_] int dx, [_In_] int dy);
        #endregion

        #region InheritWindowMonitor
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InheritWindowMonitor([HWND, _In_] IntPtr hwnd, [HWND, _In_opt_] IntPtr hwndInherit);
        #endregion

        #region InitializeTouchInjection
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InitializeTouchInjection([UINT32, _In_] uint maxCount, [DWORD, _In_] uint dwMode);
        #endregion

        #region InjectSyntheticPointerInput
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InjectSyntheticPointerInput([HSYNTHETICPOINTERDEVICE, _In_] IntPtr device, [POINTER_TYPE_INFO, Ptr, _In_reads_, CONST] PointerTypeInfo[] pointerInfo, [UINT32, _In_] uint count);
        #endregion

        #region InjectTouchInput
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InjectTouchInput([UINT32, _In_] uint count, [POINTER_TOUCH_INFO, Ptr, _In_reads_, CONST] PointerTouchInfo[] contacts);
        #endregion

        #region InSendMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InSendMessage();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InSendMessage([LPVOID, _Reserved_] IntPtr lpReserved);
        #endregion

        #region InsertMenu
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL InsertMenuA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCSTR, _In_opt_] byte[] lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL InsertMenuW([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCWSTR, _In_opt_] string lpNewItem);
        #endregion

        #region InsertMenuItem
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InsertMenuItemA([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint item, [BOOL, _In_] BOOL fByPosition, [LPCMENUITEMINFOA, _In_] in MenuItemInfoA lpmi);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InsertMenuItemW([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint item, [BOOL, _In_] BOOL fByPosition, [LPCMENUITEMINFOW, _In_] in MenuItemInfoW lpmi);
        #endregion

        #region InternalGetWindowText
        [DllImport("user32.dll")]
        public static extern int InternalGetWindowText([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_to_] StringBuilder pString, [_In_] int cchMaxCount);
        #endregion

        #region IntersectRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IntersectRect([LPRECT, _Out_] out RECT lprcDst, [RECT, Ptr, _In_, CONST] in RECT lprcSrc1, [RECT, Ptr, _In_, CONST] in RECT lprcSrc2);
        #endregion

        #region InvalidateRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InvalidateRect([HWND, _In_opt_] IntPtr hWnd, [RECT, Ptr, _In_opt_, CONST] in RECT lpRect, [BOOL, _In_] BOOL bErase);
        #endregion

        #region InvalidateRgn
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InvalidateRgn([HWND, _In_] IntPtr hWnd, [HRGN, _In_opt_] IntPtr hRgn, [BOOL, _In_] BOOL bErase);
        #endregion

        #region InvertRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InvertRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc);
        #endregion

        #region IsCharAlpha
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL IsCharAlphaA([CHAR, _In_] byte ch);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL IsCharAlphaW([WCHAR, _In_] char ch);
        #endregion

        #region IsCharAlphaNumeric
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL IsCharAlphaNumericA([CHAR, _In_] byte ch);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL IsCharAlphaNumericW([WCHAR, _In_] char ch);
        #endregion

        #region IsCharLower
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL IsCharLowerA([CHAR, _In_] byte ch);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL IsCharLowerW([WCHAR, _In_] char ch);
        #endregion

        #region IsCharUpper
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL IsCharUpperA([CHAR, _In_] byte ch);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL IsCharUpperW([WCHAR, _In_] char ch);
        #endregion

        #region IsChild
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsChild([HWND, _In_] IntPtr hWndParent, [HWND, _In_] IntPtr hWnd);
        #endregion

        #region IsClipboardFormatAvailable
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsClipboardFormatAvailable([UINT, _In_] uint format);
        #endregion

        #region IsDialogMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL IsDialogMessage([HWND, _In_] IntPtr hDlg, [LPMSG, _In_] in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL IsDialogMessageA([HWND, _In_] IntPtr hDlg, [LPMSG, _In_] in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL IsDialogMessageW([HWND, _In_] IntPtr hDlg, [LPMSG, _In_] in MSG lpMsg);
        #endregion

        #region IsDlgButtonChecked
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint IsDlgButtonChecked([HWND, _In_] IntPtr hDlg, [_In_] int nIDButton);
        #endregion

        #region IsGUIThread
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsGUIThread([BOOL, _In_] BOOL bConvert);
        #endregion

        #region IsHungAppWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsHungAppWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region IsIconic
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsIconic([HWND, _In_] IntPtr hWnd);
        #endregion

        #region IsImmersiveProcess
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsImmersiveProcess([HANDLE, _In_] IntPtr hProcess);
        #endregion

        #region IsMenu
        [DllImport("user32.dll")]
        [return: BOOL]

        public static extern BOOL IsMenu([HMENU, _In_] IntPtr hMenu);
        #endregion

        #region IsMouseInPointerEnabled
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsMouseInPointerEnabled();
        #endregion

        #region IsServerSideWindow
        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL IsServerSideWindow([HWND] IntPtr hWnd);
        #endregion

        #region IsThreadDesktopComposited
        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL IsThreadDesktopComposited();
        #endregion

        #region IsWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindow([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region IsWindowEnabled
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindowEnabled([HWND, _In_] IntPtr hWnd);
        #endregion

        #region IsWindowUnicode
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindowUnicode([HWND, _In_] IntPtr hWnd);
        #endregion

        #region IsWindowVisible
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindowVisible([HWND, _In_] IntPtr hWnd);
        #endregion

        #region IsWinEventHookInstalled
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWinEventHookInstalled([DWORD, _In_] uint @event);
        #endregion

        #region IsWow64Message
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWow64Message();
        #endregion

        #region IsZoomed
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsZoomed([HWND, _In_] IntPtr hWnd);
        #endregion

        #region keybd_event
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void keybd_event([BYTE, _In_] KeyEvent bVk, [BYTE, _In_] byte bScan, [DWORD, _In_] uint dwFlags, [_In_, ULONG_PTR] IntPtr dwExtraInfo);
        #endregion

        #region KillTimer
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL KillTimer([HWND, _In_opt_] IntPtr hWnd, [UINT_PTR, _In_] IntPtr uIDEvent);
        #endregion

        #region LoadAccelerators
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadAcceleratorsA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpTableName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadAcceleratorsW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpTableName);
        #endregion

        #region LoadBitmap
        [DllImport("user32.dll")]
        [return: HBITMAP]
        public static extern IntPtr LoadBitmapA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpBitmapName);

        [DllImport("user32.dll")]
        [return: HBITMAP]
        public static extern IntPtr LoadBitmapW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] string lpBitmapName);
        #endregion

        #region LoadCursor
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HCURSOR]
        public static extern IntPtr LoadCursorA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HCURSOR]
        public static extern IntPtr LoadCursorA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] CursorID lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HCURSOR]
        public static extern IntPtr LoadCursorW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HCURSOR]
        public static extern IntPtr LoadCursorW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] CursorID lpCursorName);
        #endregion

        #region LoadCursorFromFile
        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern void LoadCursorFromFileA([LPCSTR, _In_] byte[] lpFileName);

        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern void LoadCursorFromFileW([LPCWSTR, _In_] string lpFileName);
        #endregion

        #region LoadIcon
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HICON]
        public static extern IntPtr LoadIconA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpIconName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HICON]
        public static extern IntPtr LoadIconW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpIconName);
        #endregion

        #region LoadImage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HANDLE]
        public static extern IntPtr LoadImageA([HINSTANCE, _In_opt_] IntPtr hInst, [LPCSTR, _In_] byte[] name, [UINT, _In_] uint type, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint fuLoad);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HANDLE]
        public static extern IntPtr LoadImageW([HINSTANCE, _In_opt_] IntPtr hInst, [LPCWSTR, _In_] string name, [UINT, _In_] uint type, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint fuLoad);
        #endregion

        #region LoadKeyboardLayout
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HKL]
        public static extern IntPtr LoadKeyboardLayoutA([LPCSTR, _In_] byte[] pwszKLID, [UINT, _In_] uint Flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HKL]
        public static extern IntPtr LoadKeyboardLayoutW([LPCWSTR, _In_] string pwszKLID, [UINT, _In_] uint Flags);
        #endregion

        #region LoadMenu
        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr LoadMenuA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpMenuName);

        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr LoadMenuW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCWSTR, _In_] string lpMenuName);
        #endregion

        #region LoadString
        [DllImport("user32.dll")]
        public static extern int LoadStringA([HINSTANCE, _In_opt_] IntPtr hInstance, [UINT, _In_] uint uID, [LPSTR, _Out_writes_to_] byte[] lpBuffer, [_In_] int cchBufferMax);

        [DllImport("user32.dll")]
        public static extern int LoadStringW([HINSTANCE, _In_opt_] IntPtr hInstance, [UINT, _In_] uint uID, [LPWSTR, _Out_writes_to_] StringBuilder lpBuffer, [_In_] int cchBufferMax);
        #endregion

        #region LockSetForegroundWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL LockSetForegroundWindow([UINT, _In_] uint uLockCode);
        #endregion

        #region LockWindowUpdate
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL LockWindowUpdate([HWND, _In_opt_] IntPtr hWndLock);
        #endregion

        #region LockWorkStation
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL LockWorkStation();
        #endregion

        #region LogicalToPhysicalPoint
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL LogicalToPhysicalPoint([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);
        #endregion

        #region LogicalToPhysicalPointForPerMonitorDPI
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL LogicalToPhysicalPointForPerMonitorDPI([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);
        #endregion

        #region LookupIconIdFromDirectory
        [DllImport("user32.dll")]
        public static extern int LookupIconIdFromDirectory([PBYTE, _In_reads_bytes_] byte[] presbits, [BOOL, _In_] BOOL fIcon);

        [DllImport("user32.dll")]
        public static extern int LookupIconIdFromDirectoryEx([PBYTE, _In_reads_bytes_] byte[] presbits, [BOOL, _In_] BOOL fIcon, [_In_] int cxDesired, [_In_] int cyDesired, [UINT, _In_] uint Flags);
        #endregion

        #region MapDialogRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL MapDialogRect([HWND, _In_] IntPtr hDlg, [LPRECT, _Inout_] ref RECT lpRect);
        #endregion

        #region MapVirtualKey
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint MapVirtualKeyA([UINT, _In_] uint uCode, [UINT, _In_] uint uMapType);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint MapVirtualKeyW([UINT, _In_] uint uCode, [UINT, _In_] uint uMapType);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint MapVirtualKeyExA([UINT, _In_] uint uCode, [UINT, _In_] uint uMapType, [HKL, _In_opt_] IntPtr dwhkl);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint MapVirtualKeyExW([UINT, _In_] uint uCode, [UINT, _In_] uint uMapType, [HKL, _In_opt_] IntPtr dwhkl);
        #endregion

        #region MapWindowPoints
        [DllImport("user32.dll")]
        public static extern int MapWindowPoints([HWND, _In_opt_] IntPtr hWndFrom, [HWND, _In_opt_] IntPtr hWndTo, [LPPOINT, _Inout_updates_] POINT[] lpPoints, [UINT, _In_] uint cPoints);
        #endregion

        #region MenuItemFromPoint
        [DllImport("user32.dll")]
        public static extern int MenuItemFromPoint([HWND, _In_opt_] IntPtr hWnd, [HMENU, _In_] IntPtr hMenu, [POINT, _In_] POINT ptScreen);
        #endregion

        #region MessageBeep
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL MessageBeep([UINT, _In_] MessageBoxFlags uType);
        #endregion

        #region MessageBox
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern DialogBoxCommandIDs MessageBoxA([HWND, _In_opt_] IntPtr hWnd, [LPCSTR, _In_opt_] byte[] lpText, [LPCWSTR, _In_opt_] byte[] lpCaption, [UINT, _In_] MessageBoxFlags uType);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern DialogBoxCommandIDs MessageBoxW([HWND, _In_opt_] IntPtr hWnd, [LPCWSTR, _In_opt_] string lpText, [LPCWSTR, _In_opt_] string lpCaption, [UINT, _In_] MessageBoxFlags uType);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern DialogBoxCommandIDs MessageBoxExA([HWND, _In_opt_] IntPtr hWnd, [LPCSTR, _In_opt_] byte[] lpText, [LPCSTR, _In_opt_] byte[] lpCaption, [UINT, _In_] uint uType, [WORD, _In_] ushort wLanguageId);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern DialogBoxCommandIDs MessageBoxExW([HWND, _In_opt_] IntPtr hWnd, [LPCWSTR, _In_opt_] string lpText, [LPCWSTR, _In_opt_] string lpCaption, [UINT, _In_] uint uType, [WORD, _In_] ushort wLanguageId);
        #endregion

        #region MessageBoxIndirect
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int MessageBoxIndirectA([MSGBOXPARAMSA, Ptr, _In_, CONST] in MsgBoxParamsA lpmbp);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBoxIndirectW([MSGBOXPARAMSW, Ptr, _In_, CONST] in MsgBoxParamsW lpmbp);
        #endregion

        #region MessageBoxTimeout
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern DialogBoxCommandIDs MessageBoxTimeoutA([HWND, IN] IntPtr hWnd, [LPCSTR, IN] byte[] lpText, [LPCSTR, IN] byte[] lpCaption, [UINT, IN] MessageBoxFlags uType, [WORD, IN] ushort wLanguageId, [DWORD, IN] uint dwTimeout);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern DialogBoxCommandIDs MessageBoxTimeoutW([HWND, IN] IntPtr hWnd, [LPCWSTR, IN] string lpText, [LPCWSTR, IN] string lpCaption, [UINT, IN] MessageBoxFlags uType, [WORD, IN] ushort wLanguageId, [DWORD, IN] uint dwTimeout);
        #endregion

        #region ModifyMenu
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL ModifyMenuA([HMENU, _In_] IntPtr hMnu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCSTR, _In_opt_] byte[] lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL ModifyMenuW([HMENU, _In_] IntPtr hMnu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCWSTR, _In_opt_] string lpNewItem);
        #endregion

        #region MonitorFromPoint
        [DllImport("user32.dll")]
        [return: HMONITOR]
        public static extern IntPtr MonitorFromPoint([POINT, _In_] POINT pt, [DWORD, _In_] uint dwFlags);
        #endregion

        #region MonitorFromRect
        [DllImport("user32.dll")]
        [return: HMONITOR]
        public static extern IntPtr MonitorFromRect([LPCRECT, _In_] in RECT lprc, [DWORD, _In_] uint dwFlags);
        #endregion

        #region MonitorFromWindow
        [DllImport("user32.dll")]
        [return: HMONITOR]
        public static extern IntPtr MonitorFromWindow([HWND, _In_] IntPtr hwnd, [DWORD, _In_] uint dwFlags);
        #endregion

        #region mouse_event
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void mouse_event([DWORD, _In_] MouseEvent dwFlags, [DWORD, _In_] int dx, [DWORD, _In_] int dy, [DWORD, _In_] uint dwData, [ULONG_PTR, _In_] UIntPtr dwExtraInfo);
        #endregion

        #region MoveWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL MoveWindow([HWND, _In_] IntPtr hWnd, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight, [BOOL, _In_] BOOL bRepaint);
        #endregion

        #region MsgWaitForMultipleObjects
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint MsgWaitForMultipleObjects([DWORD, _In_] uint nCount, [HANDLE, Ptr, CONST, _In_reads_opt_] IntPtr[] pHandles, [BOOL, _In_] BOOL fWaitAll, [DWORD, _In_] uint dwMilliseconds, [DWORD, _In_] uint dwWakeMask);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint MsgWaitForMultipleObjectsEx([DWORD, _In_] uint nCount, [HANDLE, Ptr, CONST, _In_reads_opt_] IntPtr[] pHandles, [DWORD, _In_] uint dwMilliseconds, [DWORD, _In_] uint dwWakeMask, [DWORD, _In_] uint dwFlags);
        #endregion

        #region MyRegion
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HMENU]
        public static extern unsafe IntPtr LoadMenuIndirectA([MENUTEMPLATEA, Ptr, _In_, CONST] void* lpMenuTemplate);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HMENU]
        public static extern unsafe IntPtr LoadMenuIndirectW([MENUTEMPLATEW, Ptr, _In_, CONST] void* lpMenuTemplate);
        #endregion

        #region NotifyWinEvent
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void NotifyWinEvent([DWORD, _In_] uint @event, [HWND, _In_] IntPtr hwnd, [LONG, _In_] int idObject, [LONG, _In_] int idChild);
        #endregion

        #region OemKeyScan
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint OemKeyScan([WORD, _In_] ushort wOemChar);
        #endregion

        #region OemToChar
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL OemToCharA([LPCSTR, _In_] byte[] pSrc, [LPSTR, _Out_writes_] byte[] pDst);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL OemToCharW([LPCSTR, _In_] string pSrc, [LPWSTR, _Out_writes_] StringBuilder pDst);
        #endregion

        #region OemToCharBuff
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL OemToCharBuffA([LPCSTR, _In_] byte[] lpszSrc, [LPSTR, _Out_writes_] byte[] lpszDst, [DWORD, _In_] uint cchDstLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL OemToCharBuffW([LPCSTR, _In_] byte[] lpszSrc, [LPWSTR, _Out_writes_] StringBuilder lpszDst, [DWORD, _In_] uint cchDstLength);
        #endregion

        #region OffsetRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL OffsetRect([LPRECT, _Inout_] ref RECT lprc, [_In_] int dx, [_In_] int dy);
        #endregion

        #region OpenClipboard
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL OpenClipboard([HWND, _In_opt_] IntPtr hWndNewOwner);
        #endregion

        #region OpenDesktop
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HDESK]
        public static extern IntPtr OpenDesktopA([LPCSTR, _In_] byte[] lpszDesktop, [DWORD, _In_] uint dwFlags, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDESK]
        public static extern IntPtr OpenDesktopW([LPCWSTR, _In_] string lpszDesktop, [DWORD, _In_] uint dwFlags, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);
        #endregion

        #region OpenIcon
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL OpenIcon([HWND, _In_] IntPtr hWnd);
        #endregion

        #region OpenInputDesktop
        [DllImport("user32.dll")]
        [return: HDESK]
        public static extern IntPtr OpenInputDesktop([DWORD, _In_] uint dwFlags, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);
        #endregion

        #region OpenWindowStation
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HWINSTA]
        public static extern IntPtr OpenWindowStationA([LPCSTR, _In_] byte[] lpszWinSta, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HWINSTA]
        public static extern IntPtr OpenWindowStationW([LPCWSTR, _In_] string lpszWinSta, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);
        #endregion

        #region PackDDElParam
        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr PackDDElParam([UINT, _In_] uint msg, [UINT_PTR, _In_] UIntPtr uiLo, [UINT_PTR, _In_] UIntPtr uiHi);
        #endregion

        #region PackTouchHitTestingProximityEvaluation
        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr PackTouchHitTestingProximityEvaluation([TOUCH_HIT_TESTING_INPUT, Ptr, CONST, _In_] in TouchHitTestingInput pHitTestingInput, [TOUCH_HIT_TESTING_PROXIMITY_EVALUATION, Ptr, CONST, _In_] in TouchHitTestingProximityEvaluation pProximityEval);
        #endregion

        #region PaintDesktop
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PaintDesktop([HDC, _In_] IntPtr hdc);
        #endregion

        #region GetCursorInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCursorInfo([PCURSORINFO, _Inout_] ref CursorInfo pci);
        #endregion

        #region PeekMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PeekMessageA([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax, [UINT, _In_] uint wRemoveMsg);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PeekMessageW([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax, [UINT, _In_] uint wRemoveMsg);
        #endregion

        #region PhysicalToLogicalPoint
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PhysicalToLogicalPoint([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);
        #endregion

        #region PhysicalToLogicalPointForPerMonitorDPI
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PhysicalToLogicalPointForPerMonitorDPI([HWND, _In_opt_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);
        #endregion

        #region PostMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL PostMessageA([HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL PostMessageW([HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region PostQuitMessage
        [DllImport("user32.dll")]
        public static extern void PostQuitMessage([_In_] int nExitCode);
        #endregion

        #region PostThreadMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL PostThreadMessageA([DWORD, _In_] uint idThread, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL PostThreadMessageW([DWORD, _In_] uint idThread, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region PrintWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PrintWindow([HWND, _In_] IntPtr hwnd, [HDC, _In_] IntPtr hdcBlt, [UINT, _In_] uint nFlags);
        #endregion

        #region PrivateExtractIcons
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint PrivateExtractIconsA([LPCSTR, _In_reads_] byte[] szFileName, [_In_] int nIconIndex, [_In_] int cxIcon, [_In_] int cyIcon, [HICON, Ptr, _Out_writes_opt_] IntPtr phicon, [UINT, Ptr, _Out_writes_opt_] uint piconid, [UINT, _In_] uint nIcons, [UINT, _In_] uint flags);


        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint PrivateExtractIconsW([LPCWSTR, _In_reads_] string szFileName, [_In_] int nIconIndex, [_In_] int cxIcon, [_In_] int cyIcon, [HICON, Ptr, _Out_writes_opt_] IntPtr phicon, [UINT, Ptr, _Out_writes_opt_] uint piconid, [UINT, _In_] uint nIcons, [UINT, _In_] uint flags);
        #endregion

        #region PtInRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PtInRect([RECT, Ptr, _In_, CONST] in RECT lprc, [POINT, _In_] POINT pt);
        #endregion

        #region QueryDisplayConfig
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int QueryDisplayConfig([UINT32, _In_] uint flags, [UINT32, Ptr, _Inout_] ref uint numPathArrayElements, [DISPLAYCONFIG_PATH_INFO, Ptr, _Out_writes_to_] DISPLAYCONFIG_PATH_INFO[] pathArray, [UINT32, Ptr, _Inout_] ref uint numModeInfoArrayElements, [DISPLAYCONFIG_MODE_INFO, Ptr, _Out_writes_to_] DISPLAYCONFIG_MODE_INFO[] modeInfoArray, [DISPLAYCONFIG_TOPOLOGY_ID, Ptr] out DISPLAYCONFIG_TOPOLOGY_ID currentTopologyId);
        #endregion

        #region QuerySendMessage
        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL QuerySendMessage([MSG, Ptr] ref MSG pMsg);
        #endregion

        #region RealChildWindowFromPoint
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr RealChildWindowFromPoint([HWND, _In_] IntPtr hwndParent, [POINT, _In_] POINT ptParentClientCoords);
        #endregion

        #region RealGetWindowClass
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint RealGetWindowClass([HWND, _In_] IntPtr hwnd, [LPSTR, _Out_writes_to_] byte[] ptszClassName, [UINT, _In_] uint cchClassNameMax);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint RealGetWindowClassA([HWND, _In_] IntPtr hwnd, [LPWSTR, _Out_writes_to_] StringBuilder ptszClassName, [UINT, _In_] uint cchClassNameMax);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint RealGetWindowClassW([HWND, _In_] IntPtr hwnd, [LPSTR, _Out_writes_to_] byte[] ptszClassName, [UINT, _In_] uint cchClassNameMax);
        #endregion

        #region RedrawWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RedrawWindow([HWND, _In_opt_] IntPtr hWnd, [RECT, Ptr, CONST, _In_opt_] in RECT lprcUpdate, [HRGN, _In_opt_] IntPtr hrgnUpdate, [UINT, _In_] uint flags);
        #endregion

        #region RegisterClass
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: ATOM]
        public static extern ushort RegisterClassA([WNDCLASSA, Ptr, CONST, _In_] ref WNDCLASSA lpWndClass);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: ATOM]
        public static extern ushort RegisterClassW([WNDCLASSW, Ptr, CONST, _In_] ref WNDCLASSW lpWndClass);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: ATOM]
        public static extern ushort RegisterClassExA([WNDCLASSEXA, Ptr, CONST, _In_] ref WNDCLASSA lpWndClass);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: ATOM]
        public static extern ushort RegisterClassExW([WNDCLASSEXW, Ptr, CONST, _In_] ref WNDCLASSW lpWndClass);
        #endregion

        #region RegisterClipboardFormat
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint RegisterClipboardFormatA([LPCSTR, _In_] byte[] lpszFormat);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint RegisterClipboardFormatW([LPCWSTR, _In_] string lpszFormat);
        #endregion

        #region RegisterDeviceNotification
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HDEVNOTIFY]
        public static extern unsafe IntPtr RegisterDeviceNotificationA([HANDLE, _In_] IntPtr hRecipient, [LPVOID, _In_] void* NotificationFilter, [DWORD, _In_] uint Flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDEVNOTIFY]
        public static extern unsafe IntPtr RegisterDeviceNotificationW([HANDLE, _In_] IntPtr hRecipient, [LPVOID, _In_] void* NotificationFilter, [DWORD, _In_] uint Flags);
        #endregion

        #region RegisterHotKey
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterHotKey([HWND, _In_opt_] IntPtr hWnd, [_In_] int id, [UINT, _In_] ModifierKeys fsModifiers, [UINT, _In_] VirtualKeys vk);
        #endregion

        #region RegisterPointerDeviceNotifications
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterPointerDeviceNotifications([HWND, _In_] IntPtr window, [BOOL, _In_] BOOL notifyRange);
        #endregion

        #region RegisterPointerInputTarget
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterPointerInputTarget([HWND, _In_] IntPtr hwnd, [POINTER_INPUT_TYPE, _In_] PointerInputType pointerType);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterPointerInputTargetEx([HWND, _In_] IntPtr hwnd, [POINTER_INPUT_TYPE, _In_] PointerInputType pointerType, [BOOL, _In_] BOOL fObserve);
        #endregion

        #region RegisterPowerSettingNotification
        [DllImport("user32.dll")]
        [return: HPOWERNOTIFY]
        public static extern IntPtr RegisterPowerSettingNotification([HANDLE, IN] IntPtr hRecipient, [LPCGUID, IN] in GUID PowerSettingGuid, [DWORD, IN] uint Flags);
        #endregion

        #region RegisterRawInputDevices
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterRawInputDevices([PCRAWINPUTDEVICE, _In_reads_] RAWINPUTDEVICE[] pRawInputDevices, [UINT, _In_] uint uiNumDevices, [UINT, _In_] uint cbSize);
        #endregion

        #region RegisterShellHookWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr RegisterShellHookWindow([HWND, _In_] IntPtr hwnd);
        #endregion

        #region RegisterSuspendResumeNotification
        [DllImport("user32.dll")]
        [return: HPOWERNOTIFY]
        public static extern IntPtr RegisterSuspendResumeNotification([HANDLE, IN] IntPtr hRecipient, [DWORD, IN] uint Flags);
        #endregion

        #region RegisterSystemThread
        [DllImport("user32.dll")] // NOTE: undocumented
        public static extern void RegisterSystemThread([DWORD] uint flags, [DWORD] uint reserved);
        #endregion

        #region RegisterTouchHitTestingWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterTouchHitTestingWindow([HWND, _In_] IntPtr hWnd, [ULONG, _In_] uint value);
        #endregion

        #region RegisterTouchWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterTouchWindow([HWND, _In_] IntPtr hwnd, [ULONG, _In_] uint ulFlags);
        #endregion

        #region RegisterWindowMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern uint RegisterWindowMessageA([LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern uint RegisterWindowMessageW([LPCWSTR, _In_] string lpString);
        #endregion

        #region ReleaseCapture
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ReleaseCapture();
        #endregion

        #region RemoveClipboardFormatListener
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RemoveClipboardFormatListener([HWND, _In_] IntPtr hwnd);
        #endregion

        #region RemoveMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RemoveMenu([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags);
        #endregion

        #region RemoveProp
        [DllImport("user32.dll")]
        [return: HANDLE]
        public static extern IntPtr RemovePropA([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll")]
        [return: HANDLE]
        public static extern IntPtr RemovePropW([HWND, _In_] IntPtr hWnd, [LPCWSTR, _In_] byte[] lpString);
        #endregion

        #region ReplyMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ReplyMessage([LRESULT, _In_] IntPtr lResult);
        #endregion

        #region ReuseDDElParam
        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr ReuseDDElParam([LPARAM] IntPtr lParam, [UINT] uint msgIn, [UINT] uint msgOut, [UINT_PTR] UIntPtr uiLo, [UINT_PTR] UIntPtr uiHi);
        #endregion

        #region ScreenToClient
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ScreenToClient([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);
        #endregion

        #region ScrollDC
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ScrollDC([HDC, _In_] IntPtr hDC, [_In_] int dx, [_In_] int dy, [RECT, Ptr, CONST, _In_opt_] in RECT lprcScroll, [RECT, Ptr, CONST, _In_opt_] in RECT lprcClip, [HRGN, _In_opt_] IntPtr hrgnUpdate, [LPRECT, _Out_opt_] out RECT lprcUpdate);
        #endregion

        #region ScrollWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ScrollWindow([HWND, _In_] IntPtr hWnd, [_In_] int XAmount, [_In_] int YAmount, [RECT, Ptr, CONST, _In_opt_] in RECT lpRect, [RECT, Ptr, CONST, _In_opt_] in RECT lpClipRect);

        [DllImport("user32.dll")]
        public static extern int ScrollWindowEx([HWND, _In_] IntPtr hWnd, [_In_] int dx, [_In_] int dy, [RECT, Ptr, CONST, _In_opt_] in RECT prcScroll, [RECT, Ptr, CONST, _In_opt_] in RECT prcClip, [HRGN, _In_opt_] IntPtr hrgnUpdate, [LPRECT, _Out_opt_] out RECT prcUpdate, [UINT, _In_] uint flags);
        #endregion

        #region SendDlgItemMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr SendDlgItemMessageA([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr SendDlgItemMessageW([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region SendInput
        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint SendInput([UINT, _In_] uint nInputs, [LPINPUT, _In_reads_] Input[] pInputs, [_In_] int cbSize);
        #endregion

        #region SendMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr SendMessageA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _Pre_maybenull_, _Post_valid_] IntPtr wParam, [LPARAM, _Pre_maybenull_, _Post_valid_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr SendMessageW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _Pre_maybenull_, _Post_valid_] IntPtr wParam, [LPARAM, _Pre_maybenull_, _Post_valid_] IntPtr lParam);
        #endregion

        #region SendMessageCallback
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SendMessageCallbackA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [SENDASYNCPROC, _In_] SendAsyncProc lpResultCallBack, [ULONG_PTR, _In_] UIntPtr dwData);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SendMessageCallbackW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [SENDASYNCPROC, _In_] SendAsyncProc lpResultCallBack, [ULONG_PTR, _In_] UIntPtr dwData);
        #endregion

        #region SendMessageTimeout
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr SendMessageTimeoutA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [UINT, _In_] uint fuFlags, [UINT, _In_] uint uTimeout, [PDWORD_PTR, _Out_opt_] out IntPtr lpdwResult);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessageTimeoutW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [UINT, _In_] uint fuFlags, [UINT, _In_] uint uTimeout, [PDWORD_PTR, _Out_opt_] out IntPtr lpdwResult);
        #endregion

        #region SendNotifyMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SendNotifyMessageA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SendNotifyMessageW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region SetActiveWindow
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetActiveWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region SetCapture
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetCapture([HWND, _In_] IntPtr hWnd);
        #endregion

        #region SetCaretBlinkTime
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetCaretBlinkTime([UINT, _In_] uint uMSeconds);
        #endregion

        #region SetCaretPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetCaretPos([_In_] int X, [_In_] int Y);
        #endregion

        #region SetClassLong
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern uint SetClassLongA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG, _In_] int dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern uint SetClassLongW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG, _In_] int dwNewLong);
        #endregion

        #region SetClassLongPtr
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: ULONG_PTR]
        public static extern UIntPtr SetClassLongPtrA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG_PTR, _In_] IntPtr dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: ULONG_PTR]
        public static extern UIntPtr SetClassLongPtrW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG_PTR, _In_] IntPtr dwNewLong);
        #endregion

        #region SetClassWord
        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort SetClassWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [WORD, _In_] ushort wNewWord);
        #endregion

        #region SetClipboardViewer
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetClipboardViewer([HWND, _In_] IntPtr hWndNewViewer);
        #endregion

        #region SetCoalescableTimer
        [DllImport("user32.dll")]
        [return: UINT_PTR]
        public static extern UIntPtr SetCoalescableTimer([HWND, _In_opt_] IntPtr hWnd, [UINT_PTR, _In_] UIntPtr nIDEvent, [UINT, _In_] uint uElapse, [TIMERPROC, _In_opt_] TimerProc lpTimerFunc, [ULONG, _In_] uint uToleranceDelay);
        #endregion

        #region SetCursor
        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern IntPtr SetCursor([HCURSOR, _In_opt_] IntPtr hCursor);
        #endregion

        #region SetCursorPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetCursorPos([_In_] int X, [_In_] int Y);
        #endregion

        #region SetDebugErrorLevel
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void SetDebugErrorLevel([DWORD, _In_] uint dwLevel);
        #endregion

        #region SetDialogControlDpiChangeBehavior
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDialogControlDpiChangeBehavior([HWND, _In_] IntPtr hWnd, [DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS, _In_] DialogControlDpiChangeBehaviors mask, [DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS, _In_] DialogControlDpiChangeBehaviors values);
        #endregion

        #region SetDialogDpiChangeBehavior
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDialogDpiChangeBehavior([HWND, _In_] IntPtr hDlg, [DIALOG_DPI_CHANGE_BEHAVIORS, _In_] DialogDpiChangeBehaviors mask, [DIALOG_DPI_CHANGE_BEHAVIORS, _In_] DialogDpiChangeBehaviors values);
        #endregion

        #region SetDisplayAutoRotationPreferences
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDisplayAutoRotationPreferences([ORIENTATION_PREFERENCE, _In_] OrientationPreference orientation);
        #endregion

        #region SetDisplayConfig
        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int SetDisplayConfig([UINT32, _In_] uint numPathArrayElements, [DISPLAYCONFIG_PATH_INFO, Ptr, _In_reads_opt_] DISPLAYCONFIG_PATH_INFO pathArray, [UINT32, _In_] uint numModeInfoArrayElements, [DISPLAYCONFIG_MODE_INFO, Ptr, _In_reads_opt_] DISPLAYCONFIG_MODE_INFO modeInfoArray, [UINT32, _In_] uint flags);
        #endregion

        #region SetDlgItemInt
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDlgItemInt([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [UINT, _In_] uint uValue, [BOOL, _In_] BOOL bSigned);
        #endregion

        #region SetDlgItemText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SetDlgItemTextA([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SetDlgItemTextW([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPCWSTR, _In_] string lpString);
        #endregion

        #region SetDoubleClickTime
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDoubleClickTime([UINT, _In_] uint arg1);
        #endregion

        #region SetFocus
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetFocus([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region SetForegroundWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetForegroundWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region SetGestureConfig
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetGestureConfig([HWND, _In_] IntPtr hwnd, [DWORD, _In_] uint dwReserved, [UINT, _In_] uint cIDs, [PGESTURECONFIG, _In_reads_] GestureConfig[] pGestureConfig, [UINT, _In_] uint cbSize);
        #endregion

        #region SetKeyboardState
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetKeyboardState([PBYTE, _In_reads_] byte[] lpKeyState);
        #endregion

        #region SetLastErrorEx
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void SetLastErrorEx([DWORD, _In_] uint dwErrCode, [DWORD, _In_] uint dwType);
        #endregion

        #region SetLayeredWindowAttributes
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetLayeredWindowAttributes([HWND, _In_] IntPtr hwnd, [COLORREF, _In_] uint crKey, [BYTE, _In_] byte bAlpha, [DWORD, _In_] uint dwFlags);
        #endregion

        #region SetMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenu([HWND, _In_] IntPtr hWnd, [HMENU, _In_opt_] IntPtr hMenu);
        #endregion

        #region SetMenuContextHelpId
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenuContextHelpId([HMENU, _In_] IntPtr hMenu, [DWORD, _In_] uint arg2);
        #endregion

        #region SetMenuDefaultItem
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenuDefaultItem([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uItem, [UINT, _In_] uint fByPos);
        #endregion

        #region SetMenuInfo
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenuInfo([HMENU, _In_] IntPtr hMenu, [LPCMENUINFO, _In_] in MenuInfo menuInfo);
        #endregion

        #region SetMenuItemBitmaps
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenuItemBitmaps([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [HBITMAP, _In_opt_] IntPtr hBitmapUnchecked, [HBITMAP, _In_opt_] IntPtr hBitmapChecked);
        #endregion

        #region SetMenuItemInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SetMenuItemInfoA([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint item, [BOOL, _In_] BOOL fByPositon, [LPCMENUITEMINFOA, _In_] in MenuItemInfoA lpmii);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SetMenuItemInfoW([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint item, [BOOL, _In_] BOOL fByPositon, [LPCMENUITEMINFOW, _In_] in MenuItemInfoW lpmii);
        #endregion

        #region SetMessageExtraInfo
        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr SetMessageExtraInfo([LPARAM, _In_] IntPtr lParam);
        #endregion

        #region SetMessageQueue
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMessageQueue([_In_] int cMessagesMax);
        #endregion

        #region SetParent
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetParent([HWND, _In_] IntPtr hWndChild, [HWND, _In_opt_] IntPtr hWndNewParent);
        #endregion

        #region SetPhysicalCursorPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetPhysicalCursorPos([_In_] int X, [_In_] int Y);
        #endregion

        #region SetProcessDefaultLayout
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetProcessDefaultLayout([DWORD, _In_] uint dwDefaultLayout);
        #endregion

        #region SetProcessDPIAware
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetProcessDPIAware();
        #endregion

        #region SetProcessDpiAwarenessContext
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetProcessDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr value);
        #endregion

        #region SetProcessRestrictionExemption
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetProcessRestrictionExemption([BOOL, _In_] BOOL fEnableExemption);
        #endregion

        #region SetProcessWindowStation
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetProcessWindowStation([HWINSTA, _In_] IntPtr hWinSta);
        #endregion

        #region SetProgmanWindow
        [DllImport("user32.dll")]
        public static extern BOOL SetProgmanWindow([HWND] IntPtr hwnd);
        #endregion

        #region SetProp
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetPropA([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] byte[] lpString, [HANDLE, _In_opt_] IntPtr hData);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetPropW([HWND, _In_] IntPtr hWnd, [LPCWSTR, _In_] string lpString, [HANDLE, _In_opt_] IntPtr hData);
        #endregion

        #region SetRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetRect([LPRECT, _Out_] out RECT lprc, [_In_] int xLeft, [_In_] int yTop, [_In_] int xRight, [_In_] int yBottom);
        #endregion

        #region SetRectEmpty
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetRectEmpty([LPRECT, _Out_] out RECT lprc);
        #endregion

        #region SetScrollInfo
        [DllImport("user32.dll")]
        public static extern int SetScrollInfo([HWND, _In_] IntPtr hwnd, [_In_] int nBar, [LPCSCROLLINFO, _In_] in ScrollInfo lpsi, [BOOL, _In_] BOOL redraw);
        #endregion

        #region SetScrollPos
        [DllImport("user32.dll")]
        public static extern int SetScrollPos([HWND, _In_] IntPtr hWnd, [_In_] int nBar, [_In_] int nPos, [BOOL, _In_] BOOL bRedraw);
        #endregion

        #region SetScrollRange
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetScrollRange([HWND, _In_] IntPtr hWnd, [_In_] int nBar, [_In_] int nMinPos, [_In_] int nMaxPos, [BOOL, _In_] BOOL bRedraw);
        #endregion

        #region SetShellWindow
        [DllImport("user32.dll")]
        public static extern BOOL SetShellWindow([HWND] IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern BOOL SetShellWindowEx([HWND] IntPtr hwnd, [HWND] IntPtr hwnd2);
        #endregion

        #region SetSysColors
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetSysColors([_In_] int cElements, [INT, Ptr, CONST, _In_reads_] int[] lpaElements, [COLORREF, Ptr, CONST, _In_reads_] uint[] lpaRgbValues);
        #endregion

        #region SetSystemCursor
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetSystemCursor([HCURSOR, _In_] IntPtr hcur, [DWORD, _In_] uint id);
        #endregion

        #region SetThreadDesktop
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetThreadDesktop([HDESK, _In_] IntPtr hDesktop);
        #endregion

        #region SetThreadDpiAwarenessContext
        [DllImport("user32.dll")]
        [return: DPI_AWARENESS_CONTEXT]
        public static extern IntPtr SetThreadDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr dpiContext);
        #endregion

        #region SetThreadDpiHostingBehavior
        [DllImport("user32.dll")]
        [return: DPI_HOSTING_BEHAVIOR]
        public static extern DpiHostingBehavior SetThreadDpiHostingBehavior([DPI_HOSTING_BEHAVIOR, _In_] DpiHostingBehavior value);
        #endregion

        #region SetTimer
        [DllImport("user32.dll")]
        [return: UINT_PTR]
        public static extern UIntPtr SetTimer([HWND, _In_opt_] IntPtr hWnd, [UINT_PTR, _In_] uint nIDEvent, [UINT, _In_] uint uElapse, [TIMERPROC, _In_opt_] TimerProc lpTimerFunc);
        #endregion

        #region SetUserObjectInformation
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SetUserObjectInformationA([HANDLE, _In_] IntPtr hObj, [_In_] int nIndex, [PVOID, _In_reads_bytes_] byte[] pvInfo, [DWORD, _In_] uint nLength);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SetUserObjectInformationW([HANDLE, _In_] IntPtr hObj, [_In_] int nIndex, [PVOID, _In_reads_bytes_] byte[] pvInfo, [DWORD, _In_] uint nLength);
        #endregion

        #region SetUserObjectSecurity
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern unsafe BOOL SetUserObjectSecurity([HANDLE, _In_] IntPtr hObj, [PSECURITY_INFORMATION, _In_] void* pSIRequested, [PSECURITY_DESCRIPTOR, _In_] SECURITY_DESCRIPTOR* pSID);
        #endregion

        #region SetWindowBand
        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL SetWindowBand([HWND] IntPtr hWnd, [HWND] IntPtr hwndInsertAfter, [DWORD] uint dwBand);
        #endregion

        #region SetWindowContextHelpId
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowContextHelpId([HWND, _In_] IntPtr hWnd, [DWORD, _In_] uint arg2);
        #endregion

        #region SetWindowDisplayAffinity
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowDisplayAffinity([HWND, _In_] IntPtr hWnd, [DWORD, _In_] uint dwAffinity);
        #endregion

        #region SetWindowFeedbackSetting
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowFeedbackSetting([HWND, _In_] IntPtr hwnd, [FEEDBACK_TYPE, _In_] FeedbackType feedback, [DWORD, _In_] uint dwFlags, [UINT32, _In_] uint size, [VOID, Ptr, CONST, _In_reads_bytes_opt_] byte[] configuration);
        #endregion

        #region SetWindowLong
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LONG]
        public static extern int SetWindowLongA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG, _In_] int dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LONG]
        public static extern int SetWindowLongW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG, _In_] int dwNewLong);
        #endregion

        #region SetWindowLongPtr
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LONG_PTR]
        public static extern IntPtr SetWindowLongPtrA([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG_PTR, _In_] IntPtr dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LONG_PTR]
        public static extern IntPtr SetWindowLongPtrW([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [LONG_PTR, _In_] IntPtr dwNewLong);
        #endregion

        #region SetWindowPlacement
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowPlacement([HWND, _In_] IntPtr hWnd, [WINDOWPLACEMENT, Ptr, CONST, _In_] in WindowPlacement lpwndpl);
        #endregion

        #region SetWindowPos
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowPos([HWND, _In_] IntPtr hWnd, [HWND, _In_opt_] IntPtr hWndInsertAfter, [_In_] int X, [_In_] int Y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);
        #endregion

        #region SetWindowRgn
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn([HWND, _In_] IntPtr hWnd, [HRGN, _In_opt_] IntPtr hRgn, [BOOL, _In_] BOOL bRedraw);
        #endregion

        #region SetWindowsHook
        [DllImport("user32.dll")]
        [return: HHOOK]
        public static extern IntPtr SetWindowsHookA([_In_] int nFilterType, [HOOKPROC, _In_] HookProc pfnFilterProc);

        [DllImport("user32.dll")]
        [return: HHOOK]
        public static extern IntPtr SetWindowsHookW([_In_] int nFilterType, [HOOKPROC, _In_] HookProc pfnFilterProc);

        [DllImport("user32.dll")]
        [return: HHOOK]
        public static extern IntPtr SetWindowsHookExA([_In_] HookType idHook, [HOOKPROC, _In_] HookProc lpfn, [HINSTANCE, _In_opt_] IntPtr hmod, [DWORD, _In_] uint dwThreadId);

        [DllImport("user32.dll")]
        [return: HHOOK]
        public static extern IntPtr SetWindowsHookExW([_In_] HookType idHook, [HOOKPROC, _In_] HookProc lpfn, [HINSTANCE, _In_opt_] IntPtr hmod, [DWORD, _In_] uint dwThreadId);

        [DllImport("user32.dll")]
        [return: HHOOK]
        public static extern IntPtr SetWindowsHookExAW(HookType idHook, [HOOKPROC, _In_] HookProc lpfn, [HINSTANCE, _In_opt_] IntPtr hmod, [DWORD, _In_] uint dwThreadId);
        #endregion

        #region SetWindowText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SetWindowTextA([HWND, _In_] IntPtr hWnd, [LPSTR, _In_opt_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SetWindowTextW([HWND, _In_] IntPtr hWnd, [LPWSTR, _In_opt_] string lpString);
        #endregion

        #region SetWindowWord
        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort SetWindowWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [WORD, _In_] ushort wNewWord);
        #endregion

        #region SetWinEventHook
        [DllImport("user32.dll")]
        [return: HWINEVENTHOOK]
        public static extern IntPtr SetWinEventHook([DWORD, _In_] uint eventMin, [DWORD, _In_] uint eventMax, [HMODULE, _In_opt_] IntPtr hmodWinEventProc, [WINEVENTPROC, _In_] WinEventProc pfnWinEventProc, [DWORD, _In_] uint idProcess, [DWORD, _In_] uint idThread, [DWORD, _In_] uint dwFlags);
        #endregion

        #region ShowCaret
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowCaret([HWND, _In_opt_] IntPtr hWnd);
        #endregion

        #region ShowCursor
        [DllImport("user32.dll")]
        public static extern int ShowCursor([BOOL, _In_] BOOL bShow);
        #endregion

        #region ShowOwnedPopups
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowOwnedPopups([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL fShow);
        #endregion

        #region ShowScrollBar
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowScrollBar([HWND, _In_] IntPtr hWnd, [_In_] int wBar, [BOOL, _In_] BOOL bShow);
        #endregion

        #region ShowWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowWindow([HWND, _In_] IntPtr hWnd, [_In_] int nCmdShow);
        #endregion

        #region ShowWindowAsync
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowWindowAsync([HWND, _In_] IntPtr hWnd, [_In_] int nCmdShow);
        #endregion

        #region ShutdownBlockReasonCreate
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShutdownBlockReasonCreate([HWND, _In_] IntPtr hWnd, [LPCWSTR, _In_] string pwszReason);
        #endregion

        #region ShutdownBlockReasonDestroy
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShutdownBlockReasonDestroy([HWND, _In_] IntPtr hWnd);
        #endregion

        #region ShutdownBlockReasonQuery
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShutdownBlockReasonQuery([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_opt_] StringBuilder pwszBuff, [DWORD, Ptr, _Inout_] ref uint pcchBuff);
        #endregion

        #region SkipPointerFrameMessages
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SkipPointerFrameMessages([UINT32, _In_] uint pointerId);
        #endregion

        #region SoundSentry
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SoundSentry();
        #endregion

        #region SubtractRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SubtractRect([LPRECT, _Out_] out RECT lprcDst, [RECT, Ptr, CONST, _In_] in RECT lprcSrc1, [RECT, Ptr, CONST, _In_] in RECT lprcSrc2);
        #endregion

        #region SwapMouseButton
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SwapMouseButton([BOOL, _In_] BOOL fSwap);
        #endregion

        #region SwitchDesktop
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SwitchDesktop([HDESK, _In_] IntPtr hDesktop);
        #endregion

        #region SwitchToThisWindow
        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void SwitchToThisWindow([HWND, _In_] IntPtr hwnd, [BOOL, _In_] BOOL fUnknown);
        #endregion

        #region SystemParametersInfo
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern unsafe BOOL SystemParametersInfoA([UINT, _In_] uint uiAction, [UINT, _In_] uint uiParam, [PVOID, _Post_valid_, _Pre_maybenull_] void* pvParam, [UINT, _In_] uint fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern unsafe BOOL SystemParametersInfoW([UINT, _In_] uint uiAction, [UINT, _In_] uint uiParam, [PVOID, _Post_valid_, _Pre_maybenull_] void* pvParam, [UINT, _In_] uint fWinIni);
        #endregion

        #region SystemParametersInfoForDpi
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern unsafe BOOL SystemParametersInfoForDpi([UINT, _In_] uint uiAction, [UINT, _In_] uint uiParam, [PVOID, _Post_valid_, _Pre_maybenull_] void* pvParam, [UINT, _In_] uint fWinIni, [UINT, _In_] uint dpi);
        #endregion

        #region TabbedTextOut
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LONG]
        public static extern int TabbedTextOutA([HDC, _In_] IntPtr hdc, [_In_] int x, [_In_] int y, [LPCSTR, _In_reads_] byte[] lpString, [_In_] int chCount, [_In_] int nTabPositions, [INT, Ptr, CONST, _In_reads_opt_] int[] lpnTabStopPositions, [_In_] int nTabOrigin);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LONG]
        public static extern int TabbedTextOutW([HDC, _In_] IntPtr hdc, [_In_] int x, [_In_] int y, [LPCWSTR, _In_reads_] string lpString, [_In_] int chCount, [_In_] int nTabPositions, [INT, Ptr, CONST, _In_reads_opt_] int[] lpnTabStopPositions, [_In_] int nTabOrigin);
        #endregion

        #region TileWindows
        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort TileWindows([HWND, _In_opt_] IntPtr hwndParent, [UINT, _In_] uint wHow, [RECT, Ptr, CONST, _In_opt_] in RECT lpRect, [UINT, _In_] uint cKids, [HWND, Ptr, CONST, _In_reads_opt_] IntPtr lpKids);
        #endregion

        #region ToAscii
        [DllImport("user32.dll")]
        public static extern int ToAscii([UINT, _In_,] uint uVirtKey, [UINT, _In_,] uint uScanCode, [BYTE, Ptr, CONST, _In_reads_opt_] byte[] lpKeyState, [LPWORD, _Out_] ushort[] lpChar, [UINT, _In_] uint uFlags);
        [DllImport("user32.dll")]
        public static extern int ToAsciiEx([UINT, _In_] uint uVirtKey, [UINT, _In_] uint uScanCode, [BYTE, Ptr, CONST, _In_reads_opt_] byte[] lpKeyState, [LPWORD, _Out_] out ushort lpChar, [UINT, _In_] uint uFlags, [HKL, _In_opt_] IntPtr dwhkl);
        #endregion

        #region ToUnicodeEx
        [DllImport("user32.dll")]
        public static extern int ToUnicode([UINT, _In_,] uint wVirtKey, [UINT, _In_,] uint wScanCode, [BYTE, Ptr, CONST, LPWSTR] byte[] lpKeyState, [LPWSTR, _Out_writes_] StringBuilder pwszBuff, [_In_] int cchBuff, [UINT, _In_] uint wFlags);

        [DllImport("user32.dll")]
        public static extern int ToUnicodeEx([UINT, _In_] uint wVirtKey, [UINT, _In_] uint wScanCode, [BYTE, Ptr, CONST, _In_reads_bytes_] byte[] lpKeyState, [LPWSTR, _Out_writes_] StringBuilder pwszBuff, [_In_] int cchBuff, [UINT, _In_] uint wFlags, [HKL, _In_opt_] IntPtr dwhkl);
        #endregion

        #region TrackMouseEvent
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TrackMouseEvent([LPTRACKMOUSEEVENT, _Inout_] ref TrackMouseEventStruct lpEventTrack);
        #endregion

        #region TrackPopupMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TrackPopupMenu([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uFlags, [_In_] int x, [_In_] int y, [_Reserved_] int nReserved, [HWND, _In_] IntPtr hWnd, [RECT, Ptr, _Reserved_, CONST] in RECT prcRect);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TrackPopupMenuEx([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uFlags, [_In_] int x, [_In_] int y, [HWND, _In_] IntPtr hwnd, [LPTPMPARAMS, _In_opt_] in TPMParams lptpm);
        #endregion

        #region TranslateAccelerator
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int TranslateAccelerator([HWND, _In_] IntPtr hWnd, [HACCEL, _In_] IntPtr hAccTable, [LPMSG, _In_] in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int TranslateAcceleratorA([HWND, _In_] IntPtr hWnd, [HACCEL, _In_] IntPtr hAccTable, [LPMSG, _In_] in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int TranslateAcceleratorW([HWND, _In_] IntPtr hWnd, [HACCEL, _In_] IntPtr hAccTable, [LPMSG, _In_] in MSG lpMsg);
        #endregion

        #region TranslateMDISysAccel
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TranslateMDISysAccel([HWND, _In_] IntPtr hWndClient, [LPMSG, _In_] in MSG lpMsg);
        #endregion

        #region TranslateMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TranslateMessage([MSG, Ptr, CONST, _In_] in MSG lpMsg);

        [DllImport("user32.dll")] // NOTE: undocumented
        [return: BOOL]
        public static extern void TranslateMessageEx([CONST, MSG, Ptr] in MSG lpMsg, [DWORD] uint unk);
        #endregion

        #region UnhookWindowsHook
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnhookWindowsHook([_In_] int nCode, [HOOKPROC, _In_] HookProc pfnFilterProc);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnhookWindowsHookEx([HHOOK, _In_] IntPtr hhk);
        #endregion

        #region UnhookWinEvent
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnhookWinEvent([HWINEVENTHOOK, _In_] IntPtr hWinEventHook);
        #endregion

        #region UnionRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnionRect([LPRECT, _Out_] out RECT lprcDst, [RECT, _In_, CONST, Ptr] in RECT lprcSrc1, [RECT, _In_, CONST] in RECT lprcSrc2);
        #endregion

        #region UnloadKeyboardLayout
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnloadKeyboardLayout([HKL, _In_] IntPtr hkl);
        #endregion

        #region UnpackDDElParam
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnpackDDElParam([UINT, _In_] uint msg, [LPARAM, _In_] IntPtr lParam, [PUINT_PTR, _Out_] out UIntPtr puiLo, [PUINT_PTR, _Out_] out UIntPtr puiHi);
        #endregion

        #region UnregisterClass
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL UnregisterClassA([LPCSTR, _In_] byte[] lpClassName, [HINSTANCE, _In_opt_] IntPtr hInstance);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL UnregisterClassW([LPCWSTR, _In_] string lpClassName, [HINSTANCE, _In_opt_] IntPtr hInstance);
        #endregion

        #region UnregisterDeviceNotification
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnregisterDeviceNotification([HDEVNOTIFY, _In_] IntPtr Handle);
        #endregion

        #region UnregisterHotKey
        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL UnregisterHotKey([HWND, _In_opt_] IntPtr hWnd, [_In_] int id);
        #endregion

        #region UnregisterPointerInputTarget
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnregisterPointerInputTarget([HWND, _In_] IntPtr hwnd, [POINTER_INPUT_TYPE, _In_] in PointerInputType pointerType);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnregisterPointerInputTargetEx([HWND, _In_] IntPtr hwnd, [POINTER_INPUT_TYPE, _In_] in PointerInputType pointerType);
        #endregion

        #region UnregisterPowerSettingNotification
        [DllImport(@"user32.dll")]
        [return: BOOL]
        public static extern BOOL UnregisterPowerSettingNotification([HPOWERNOTIFY, IN] IntPtr Handle);
        #endregion

        #region UnregisterSuspendResumeNotification
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnregisterSuspendResumeNotification([HPOWERNOTIFY, IN] IntPtr Handle);
        #endregion

        #region UnregisterTouchWindow
        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL UnregisterTouchWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region UpdateLayeredWindow
        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL UpdateLayeredWindow([HWND, _In_] IntPtr hwnd, [HDC, _In_opt_] IntPtr hdcDst, [POINT, Ptr, _In_opt_] in POINT pptDst, [SIZE, Ptr, _In_opt_] in SIZE psize, [HDC, _In_opt_] IntPtr hdcSrc, [POINT, Ptr, _In_opt_] in POINT pptSrc, [COLORREF, _In_] uint crKey, [BLENDFUNCTION, _In_opt_] in BlendFunction pblend, [DWORD, _In_] uint dwFlags);
        #endregion

        #region UpdateLayeredWindowIndirect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UpdateLayeredWindowIndirect([HWND, _In_] IntPtr hWnd, [UPDATELAYEREDWINDOWINFO, Ptr, CONST, _In_] in UPDATELAYEREDWINDOWINFO pULWInfo);
        #endregion

        #region UpdateWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UpdateWindow([HWND, _In_] IntPtr hWnd);
        #endregion

        #region UserHandleGrantAccess
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UserHandleGrantAccess([HANDLE, _In_] IntPtr hUserHandle, [HANDLE, _In_] IntPtr hJob, [BOOL, _In_] BOOL bGrant);
        #endregion

        #region ValidateRect
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ValidateRect([HWND, _In_opt_] IntPtr hWnd, [RECT, Ptr, CONST, _In_opt_] in RECT lpRect);
        #endregion

        #region ValidateRgn
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ValidateRgn([HWND, _In_] IntPtr hWnd, [HRGN, _In_opt_] IntPtr hRgn);
        #endregion

        #region VkKeyScan
        [DllImport("user32.dll")]
        [return: SHORT]
        public static extern short VkKeyScanA([CHAR, _In_] byte ch);

        [DllImport("user32.dll")]
        [return: SHORT]
        public static extern short VkKeyScanW([WCHAR, _In_] char ch);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: SHORT]
        public static extern short VkKeyScanExA([CHAR, _In_] byte ch, [HKL, _In_] IntPtr dwhkl);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: SHORT]
        public static extern short VkKeyScanExW([WCHAR, _In_] char ch, [HKL, _In_] IntPtr dwhkl);
        #endregion

        #region WaitForInputIdle
        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint WaitForInputIdle([HANDLE, _In_] IntPtr hProcess, [DWORD, _In_] uint dwMillisecon);
        #endregion

        #region WaitMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL WaitMessage();
        #endregion

        #region WindowFromDC
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr WindowFromDC([HDC, _In_] IntPtr hDC);
        #endregion

        #region WindowFromPhysicalPoint
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr WindowFromPhysicalPoint([_In_] POINT Point);
        #endregion

        #region WinHelp
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL WinHelpA([HWND, _In_opt_] IntPtr hWndMain, [LPCSTR, _In_opt_] byte[] lpszHelp, [UINT, _In_] uint uCommand, [ULONG_PTR, _In_] UIntPtr dwData);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL WinHelpW([HWND, _In_opt_] IntPtr hWndMain, [LPCWSTR, _In_opt_] byte[] lpszHelp, [UINT, _In_] uint uCommand, [ULONG_PTR, _In_] UIntPtr dwData);
        #endregion

        #region wsprintf
        // NOTE: System.BadImageFormatException:“Index not found. (0x80131124)”
        [DllImport("user32.dll", EntryPoint = "wsprintfA", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        [Obsolete("System.BadImageFormatException:“Index not found. (0x80131124)”")]
        public static extern int wsprintfA([LPWSTR, _Out_] byte[] str, [LPCWSTR, _Printf_format_string_, _In_] byte[] format_string, __arglist);

        // NOTE: System.BadImageFormatException:“Index not found. (0x80131124)”
        [DllImport("user32.dll", EntryPoint = "wsprintfW", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        [Obsolete("System.BadImageFormatException:“Index not found. (0x80131124)”")]
        public static extern int wsprintfW([LPWSTR, _Out_] char[] str, [LPCWSTR, _Printf_format_string_, _In_] string format_string, __arglist);
        #endregion

    }

}
