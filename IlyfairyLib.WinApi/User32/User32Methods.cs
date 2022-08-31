using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
    public static partial class User32Methods
    {

        [DllImport("user32.dll")]
        [return: HKL]
        public static extern IntPtr ActivateKeyboardLayout([HKL, _In_] IntPtr hkl, [UINT, _In_] uint Flags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AddClipboardFormatListener([HWND, _In_] IntPtr hwnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AdjustWindowRect([LPRECT, _Inout_] ref RECT lpRect, [DWORD, _In_] uint dwStyle, [BOOL, _In_] BOOL bMenu);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AdjustWindowRectEx([LPRECT, _Inout_] ref RECT lpRect, [DWORD, _In_] uint dwStyle, [BOOL, _In_] BOOL bMenu, [DWORD, _In_] uint dwExStyle);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AdjustWindowRectExForDpi([LPRECT, _Inout_] ref RECT lpRect, [DWORD, _In_] uint dwStyle, [BOOL, _In_] BOOL bMenu, [DWORD, _In_] uint dwExStyle, [UINT, _In_] uint dpi);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AllowSetForegroundWindow([DWORD, _In_] uint dwProcessId);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AnimateWindow([_In_] IntPtr hwnd, [DWORD, _In_] int time, [DWORD, _In_] AnimateWindowFlags flags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AnyPopup();

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AreDpiAwarenessContextsEqual([DPI_AWARENESS_CONTEXT, _In_] IntPtr dpiContextA, [DPI_AWARENESS_CONTEXT, _In_] IntPtr dpiContextB);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint ArrangeIconicWindows([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern BOOL AttachThreadInput([DWORD, _In_] uint idAttach, [DWORD, _In_] uint idAttachTo, [BOOL, _In_] BOOL fAttach);

        [DllImport("user32.dll")]
        [return: HDWP]
        public static extern IntPtr BeginDeferWindowPos([_In_] int nNumWindows);

        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr BeginPaint([HWND, _In_] IntPtr hwnd, [LPPAINTSTRUCT, _Out_] out PAINTSTRUCT lpPaint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL BlockInput([BOOL] BOOL fBlockIt);

        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL BringWindowToTop([In, HWND] IntPtr hWnd);

        #region BroadcastSystemMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int BroadcastSystemMessageA([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int BroadcastSystemMessageW([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int BroadcastSystemMessageExA([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [PBSMINFO, _Out_] out BsmInfo pbsmInfo);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int BroadcastSystemMessageExW([DWORD, _In_] uint flags, [LPDWORD, _Inout_opt_] ref uint lpInfo, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam, [PBSMINFO, _Out_] out BsmInfo pbsmInfo);
        #endregion

        [DllImport("user32.dll")]
        public static extern unsafe BOOL BuildReasonArray(void* REASONDATA, BOOL arg2, BOOL arg3);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CalculatePopupWindowPosition([POINT, Ptr, CONST, _In_] in POINT anchorPoint, [SIZE, Ptr, CONST, _In_] in SIZE windowSize, [UINT, _In_] TrackPopupMenu flags, [RECT, Ptr, _In_opt_] ref RECT excludeRect, [RECT, Ptr, _Out_] out RECT popupWindowPosition);

        #region CallMsgFilter
        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL CallMsgFilterA([LPMSG, _In_] ref MSG lpMsg, [_In_] int nCode);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL CallMsgFilterW([LPMSG, _In_] ref MSG lpMsg, [_In_] int nCode);

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

        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern int CancelShutdown();

        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort CascadeWindows([HWND, _In_opt_] IntPtr hwndParent, [UINT, _In_] uint wHow, [RECT, Ptr, CONST, _In_opt_] IntPtr lpRect, [UINT, _In_] uint cKids, [HWND, Ptr, CONST, _In_reads_opt_] IntPtr[] lpKids);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ChangeClipboardChain([HWND, _In_] IntPtr hWndRemove, [HWND, _In_] IntPtr hWndNewNext);

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

        [DllImport("user32.dll")]
        public static extern BOOL CheckDBCSEnabledExt();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CheckDlgButton([HWND, _In_] IntPtr hDlg, [_In_] int nIDButton, [UINT, _In_] uint uCheck);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint CheckMenuItem([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDCheckItem, [UINT, _In_] uint uCheck);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CheckMenuRadioItem([HMENU, _In_] IntPtr hmenu, [UINT, _In_] uint first, [UINT, _In_] uint last, [UINT, _In_] uint check, [UINT, _In_] uint flags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CheckRadioButton([HWND, _In_] IntPtr hDlg, [_In_] int nIDFirstButton, [_In_] int nIDLastButton, [_In_] int nIDCheckButton);

        #region ChildWindowFromPoint
        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr ChildWindowFromPoint([HWND, _In_] IntPtr hWndParent, [POINT, _In_] POINT Point);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr ChildWindowFromPointEx([HWND, _In_] IntPtr hWndParent, [POINT, _In_] POINT Point, [UINT, _In_] uint flags);
        #endregion

        [DllImport("user32.dll")]
        public static extern BOOL CliImmSetHotKey(uint dwID, uint uModifiers, uint uVirtualKey, IntPtr hKl);

        [DllImport("user32.dll", ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL ClientToScreen([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ClipCursor([RECT, Ptr, CONST, _In_opt_] in RECT lpRect);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseClipboard();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseDesktop([HDESK, _In_] IntPtr hDesktop);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseGestureInfoHandle([HGESTUREINFO, _In_] IntPtr hGestureInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseTouchInputHandle([HTOUCHINPUT, _In_] IntPtr hTouchInput);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CloseWindowStation([HWINSTA, _In_] IntPtr hWinSta);

        [DllImport("user32.dll")]
        public static extern unsafe BOOL ConsoleControl(ConsoleControlType command, void* information, uint length);

        #region CopyAcceleratorTable
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern unsafe int CopyAcceleratorTableA([HACCEL, _In_] IntPtr hAccelSrc, [LPACCEL, _Out_writes_to_opt_] Accel[] lpAccelDst, [_In_] int cAccelEntries);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int CopyAcceleratorTableW([HACCEL, _In_] IntPtr hAccelSrc, [LPACCEL, _Out_writes_to_opt_] Accel[] lpAccelDst, [_In_] int cAccelEntries);
        #endregion

        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CopyIcon([HICON, _In_] IntPtr hIcon);

        [DllImport("user32.dll", SetLastError = true)]
        [return: HANDLE]
        public static extern IntPtr CopyImage([HANDLE, _In_] IntPtr hImage, [UINT, _In_] uint uType, [_In_] int cxDesired, [_In_] int cyDesired, [UINT, _In_] uint fuFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL CopyRect([LPRECT, Out] out RECT lprcDst, [RECT, CONST, _In_] in RECT lprcSrc);

        [DllImport("user32.dll")]
        public static extern int CountClipboardFormats();

        #region CreateAcceleratorTable
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HACCEL]
        public static extern IntPtr CreateAcceleratorTableA([LPACCEL, _In_reads_] Accel[] paccel, [_In_] int cAccel);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HACCEL]
        public static extern IntPtr CreateAcceleratorTableW([LPACCEL, _In_reads_] Accel[] paccel, [_In_] int cAccel);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL CreateCaret([HWND, In] IntPtr hWnd, [HBITMAP, _In_opt_] IntPtr hBitmap, [_In_] int nWidth, [_In_] int nHeight);

        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern IntPtr CreateCursor([HINSTANCE, _In_opt_] IntPtr hInst, [_In_] int xHotSpot, [_In_] int yHotSpot, [_In_] int nWidth, [_In_] int nHeight, [VOID, CONST, Ptr, _In_] byte[] pvANDPlane, [VOID, CONST, Ptr, _In_] byte[] pvXORPlane);

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

        [DllImport("user32.dll")]
        [return: HICON]
        public static extern unsafe IntPtr CreateIcon([HINSTANCE, _In_opt_] IntPtr piconinfo, [_In_] int nWidth, [_In_] int nHeight, [BYTE, _In_] byte cPlanes, [BYTE, _In_] byte cBitsPixel, [BYTE, Ptr, CONST, _In_] byte* lpbANDbits, [BYTE, Ptr, CONST, _In_] byte* lpbXORbits);

        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CreateIconIndirect([PICONINFO, _In_] ref IconInfo piconinfo);


        #region CreateIconFromResource
        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CreateIconFromResource([PBYTE, _In_reads_bytes_] byte[] presbits, [DWORD, _In_] uint dwResSize, [BOOL, _In_] BOOL fIcon, [DWORD, _In_] uint dwVer);

        [DllImport("user32.dll")]
        [return: HICON]
        public static extern IntPtr CreateIconFromResourceEx([PBYTE, _In_reads_bytes_] byte[] presbits, [DWORD, _In_] uint dwResSize, [BOOL, _In_] BOOL fIcon, [DWORD, _In_] uint dwVer, [_In_] int cxDesired, [_In_] int cyDesired, [UINT, _In_] uint Flags);
        #endregion

        #region CreateMDIWindow
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HWND]
        public static extern IntPtr CreateMDIWindowA([LPCSTR, _In_] byte[] lpClassName, [LPCSTR, _In_] byte[] lpWindowName, [DWORD, _In_] uint dwStyle, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hwndParent, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HWND]
        public static extern IntPtr CreateMDIWindowW([LPCWSTR, _In_] string lpClassName, [LPCWSTR, _In_] string lpWindowName, [DWORD, _In_] uint dwStyle, [_In_] int X, [_In_] int Y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hwndParent, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPARAM, _In_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr CreateMenu();

        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr CreatePopupMenu();

        #region CreateWindowEx
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        [return: HWND]
        public static extern IntPtr CreateWindowExA([DWORD, _In_] WindowStyleEx dwExStyle, [LPCSTR, _In_opt_] byte[] lpClassName, [LPCSTR, _In_opt_] byte[] lpWindowName, [DWORD, _In_] WindowStyle dwStyle, [_In_] int x, [_In_] int y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hWndParent, [HMENU, _In_opt_] IntPtr hMenu, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPVOID, _In_opt_] IntPtr lpParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: HWND]
        public static extern IntPtr CreateWindowExW([DWORD, _In_] WindowStyleEx dwExStyle, [LPCWSTR, _In_opt_] string regClassResult, [LPCWSTR, _In_opt_] string lpWindowName, [DWORD, _In_] WindowStyle dwStyle, [_In_] int x, [_In_] int y, [_In_] int nWidth, [_In_] int nHeight, [HWND, _In_opt_] IntPtr hWndParent, [HMENU, _In_opt_] IntPtr hMenu, [HINSTANCE, _In_opt_] IntPtr hInstance, [LPVOID, _In_opt_] IntPtr pvParam);
        #endregion

        #region CreateWindowStation
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr CreateWindowStationA([LPCSTR, _In_opt_] string name, [DWORD, _In_] uint flags, [ACCESS_MASK, _In_] uint desiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] IntPtr securityAttrs);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateWindowStationW([LPCWSTR, _In_opt_] string name, [DWORD, _In_] uint flags, [ACCESS_MASK, _In_] uint desiredAccess, [LPSECURITY_ATTRIBUTES, _In_opt_] IntPtr securityAttrs);
        #endregion

        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeClientTransaction([LPBYTE, _In_opt_] IntPtr pData, [DWORD, _In_] uint cbData, [HCONV, _In_] IntPtr hConv, [HSZ, _In_opt_] IntPtr hszItem, [UINT, _In_] uint wFmt, [UINT, _In_] uint wType, [DWORD, _In_] uint dwTimeout, [_Out_opt_, LPDWORD] ref uint pdwResult);

        [DllImport("user32.dll")]
        [return: HCONV]
        public static extern IntPtr DdeConnect([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hszService, [HSZ, _In_] IntPtr hszTopic, [PCONVCONTEXT, _In_opt_] IntPtr pCC);

        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeCreateDataHandle([DWORD, _In_] uint idInst, [LPBYTE, _In_reads_bytes_opt_] IntPtr pSrc, [DWORD, _In_] uint cb, [DWORD, _In_] uint cbOff, [HSZ, _Inout_] IntPtr hszItem, [UINT, _In_] uint wFmt, [UINT, _In_] uint afCmd);

        #region DdeCreateStringHandle
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HSZ]
        public static extern IntPtr DdeCreateStringHandleA([DWORD, _In_] uint idInst, [LPCSTR, _In_] byte[] psz, [_In_] int iCodePage);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HSZ]
        public static extern IntPtr DdeCreateStringHandleW([DWORD, _In_] uint idInst, [LPCWSTR, _In_] string psz, [_In_] int iCodePage);
        #endregion

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint DdeGetData([HDDEDATA, _In_] IntPtr hData, [LPBYTE, _Out_writes_bytes_opt_] byte[] pDst, [DWORD, _In_] uint cbMax, [DWORD, _In_] uint cbOff);

        #region DdeInitialize
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint DdeInitializeA([LPDWORD, _Inout_] ref uint pidInst, [PFNCALLBACK, _In_] PfnCallback pfnCallback, [DWORD, _In_] uint afCmd, [DWORD, _Reserved_] uint ulRes);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint DdeInitializeW([LPDWORD, _Inout_] ref uint pidInst, [PFNCALLBACK, _In_] PfnCallback pfnCallback, [DWORD, _In_] uint afCmd, [DWORD, _Reserved_] uint ulRes);
        #endregion

        [DllImport("user32.dll")]
        [return: HCONV]
        public static extern IntPtr DdeReconnect([HCONV, _In_] IntPtr hConv);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeSetUserHandle([HCONV, _In_] IntPtr hConv, [DWORD, _In_] uint id, [DWORD_PTR, _In_] IntPtr hUser);

        [DllImport("user32.dll", ExactSpelling = true)]
        [return: BOOL]
        public static extern BOOL DdeUninitialize([DWORD, _In_] uint idInst);

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

        #region DefWindowProc
        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr DefWindowProcA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr DefWindowProcW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowWindow([HWND, _In_] IntPtr hWnd, [_In_] int nCmdShow);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowWindowAsync([HWND, _In_] IntPtr hWnd, [_In_] int nCmdShow);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UpdateWindow([HWND, _In_] IntPtr hWnd);

        #region Message
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern DialogBoxCommandIDs MessageBoxA([HWND, _In_opt_] IntPtr hWnd, [LPCSTR, _In_opt_] byte[] lpText, [LPCWSTR, _In_opt_] byte[] lpCaption, [UINT, _In_] MessageBoxFlags uType);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern DialogBoxCommandIDs MessageBoxW([HWND, _In_opt_] IntPtr hWnd, [LPCWSTR, _In_opt_] string lpText, [LPCWSTR, _In_opt_] string lpCaption, [UINT, _In_] MessageBoxFlags uType);
        #endregion

        #region GetMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetMessageA([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetMessageW([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax);
        #endregion

        #region TranslateMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TranslateMessage([MSG, Ptr, CONST, _In_] in MSG lpMsg);

        [DllImport("user32.dll")] // NOTE: undocumented
        [return: BOOL]
        public static extern void TranslateMessageEx([CONST, MSG, Ptr] in MSG lpMsg, [DWORD] uint unk);
        #endregion

        #region DispatchMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr DispatchMessageA([MSG, Ptr, CONST, _In_] in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr DispatchMessageW([MSG, Ptr, CONST, _In_] in MSG lpMsg);
        #endregion

        [DllImport("user32.dll")]
        public static extern void PostQuitMessage([_In_] int nExitCode);

        #region GetWindowText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetWindowTextA([HWND, _In_] IntPtr hWnd, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextW([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_] StringBuilder lpString, [_In_] int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextW([HWND, _In_] IntPtr hWnd, [LPWSTR, _Out_writes_] char[] lpString, [_In_] int nMaxCount);
        #endregion

        #region SetWindowText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SetWindowTextA([HWND, _In_] IntPtr hWnd, [LPSTR, _In_opt_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SetWindowTextW([HWND, _In_] IntPtr hWnd, [LPWSTR, _In_opt_] string lpString);
        #endregion

        #region GetWindowTextLength
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetWindowTextLengthA([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextLengthW([HWND, _In_] IntPtr hWnd);
        #endregion

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetWindowThreadProcessId([HWND, _In_] IntPtr hWnd, [LPDWORD, _Out_opt_] out uint lpdwProcessId);

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

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint SendInput([UINT, _In_] uint nInputs, [LPINPUT, _In_reads_] Input[] pInputs, [_In_] int cbSize);

        #region SendMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr SendMessageA([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _Pre_maybenull_, _Post_valid_] IntPtr wParam, [LPARAM, _Pre_maybenull_, _Post_valid_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr SendMessageW([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _Pre_maybenull_, _Post_valid_] IntPtr wParam, [LPARAM, _Pre_maybenull_, _Post_valid_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        [return: DPI_AWARENESS]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr value);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumWindows([WNDENUMPROC, _In_] WndEnumProc lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void mouse_event([DWORD, _In_] MouseEvent dwFlags, [DWORD, _In_] int dx, [DWORD, _In_] int dy, [DWORD, _In_] uint dwData, [ULONG_PTR, _In_] UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void keybd_event([BYTE, _In_] KeyEvent bVk, [BYTE, _In_] byte bScan, [DWORD, _In_] uint dwFlags, [_In_, ULONG_PTR] IntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL WaitMessage();

        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort SetWindowWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [WORD, _In_] ushort wNewWord);

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

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetFocus();

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetKBCodePage();

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetKeyState([_In_] int nVirtKey);

        [DllImport("user32.dll")]
        [return: SHORT]
        public static extern short GetAsyncKeyState([_In_] int vKey);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetKeyboardState([PBYTE, _Out_writes_] byte[] lpKeyState);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetKeyboardState([PBYTE, _In_reads_] byte[] lpKeyState);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetFocus([HWND, _In_opt_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetForegroundWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetCursorPos([_In_] int X, [_In_] int Y);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC([HWND, _In_opt_] IntPtr hWnd, [HDC, _In_] IntPtr hDC);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndPaint([HWND, _In_] IntPtr hwnd, [LPPAINTSTRUCT, Ptr, CONST, _In_] in PAINTSTRUCT lpPaint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenu([HWND, _In_] IntPtr hWnd, [HMENU, _In_opt_] IntPtr hMenu);

        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr GetMenu([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenuInfo([HMENU, _In_] IntPtr hMenu, [LPCMENUINFO, _In_] in MenuInfo menuInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetMenuInfo([HMENU, _In_] IntPtr hMenu, [LPMENUINFO, _Inout_] ref MenuInfo menuInfo);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr GetDC([HWND, _In_opt_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr GetDCEx([HWND, _In_opt_] IntPtr hWnd, [HRGN, _In_opt_] IntPtr hrgnClip, [DWORD, _In_] DCXFlags flags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCursorPos([LPPOINT, _Out_] out POINT lpPoint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PCURSORINFO([PCURSORINFO, _Inout_] ref CursorInfo pci);

        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern IntPtr GetCursor();

        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: LRESULT]
        public static extern IntPtr EditWndProc([HWND] IntPtr hwnd, [UINT] uint msg, [WPARAM] IntPtr wParam, [LPARAM] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EmptyClipboard();

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetWindow([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint uCmd);

        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL GetWindowBand([HWND] IntPtr hWnd, [DWORD] ref uint pdwBand);

        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL SetWindowBand([HWND] IntPtr hWnd, [HWND] IntPtr hwndInsertAfter, [DWORD] uint dwBand);

        [DllImport("user32.dll")]
        [return: UINT_PTR]
        public static extern UIntPtr SetTimer([HWND, _In_opt_] IntPtr hWnd, [UINT_PTR, _In_] uint nIDEvent, [UINT, _In_] uint uElapse, [TIMERPROC, _In_opt_] TimerProc lpTimerFunc);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL KillTimer([HWND, _In_opt_] IntPtr hWnd, [UINT_PTR, _In_] IntPtr uIDEvent);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnionRect([LPRECT, _Out_] out RECT lprcDst, [RECT, _In_, CONST, Ptr] in RECT lprcSrc1, [RECT, _In_, CONST] in RECT lprcSrc2);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: HWND]
        public static extern IntPtr CreateWindowIndirect([_In_] ref WNDCREATESTRUCTW wnd); // NOTE: undocumented

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

        #region LoadBitmap
        [DllImport("user32.dll")]
        [return: HBITMAP]
        public static extern IntPtr LoadBitmapA([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] byte[] lpBitmapName);

        [DllImport("user32.dll")]
        [return: HBITMAP]
        public static extern IntPtr LoadBitmapW([HINSTANCE, _In_opt_] IntPtr hInstance, [LPCSTR, _In_] string lpBitmapName);
        #endregion

        #region LoadCursorFromFile
        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern void LoadCursorFromFileA([LPCSTR, _In_] byte[] lpFileName);

        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern void LoadCursorFromFileW([LPCWSTR, _In_] string lpFileName);
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

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: BOOL]
        public static extern BOOL DrawCaption([HWND, _In_] IntPtr hwnd, [HDC, _In_] IntPtr hdc, [LPRECT, _In_] ref RECT lprect, [_In_] DrawCaptionFlags flags);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerInfo([UINT32, _In_] uint pointerId, [POINTER_INFO, Ptr, _Out_writes_] out PointerInfo pointerInfo);

        #region GetPropA
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HANDLE]
        public static extern IntPtr GetPropA([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HANDLE]
        public static extern IntPtr GetPropW([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] string lpString);
        #endregion

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetParent([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetSysColor([_In_] int nIndex);

        [DllImport("user32.dll")]
        [return: HBRUSH]
        public static extern uint GetSysColorBrush([_In_] int nIndex);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetTopWindow([HWND, _In_opt_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint WaitForInputIdle([HANDLE, _In_] IntPtr hProcess, [DWORD, _In_] uint dwMillisecon);

        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL UnregisterHotKey([HWND, _In_opt_] IntPtr hWnd, [_In_] int id);

        [DllImport(@"user32.dll")]
        [return: BOOL]
        public static extern BOOL UnregisterPowerSettingNotification([HPOWERNOTIFY, IN] IntPtr Handle);

        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL UnregisterTouchWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr WindowFromDC([HDC, _In_] IntPtr hDC);

        [DllImport("user32.dll", SetLastError = true)]
        [return: BOOL]
        public static extern BOOL UpdateLayeredWindow([HWND, _In_] IntPtr hwnd, [HDC, _In_opt_] IntPtr hdcDst, [POINT, Ptr, _In_opt_] in POINT pptDst, [SIZE, Ptr, _In_opt_] in SIZE psize, [HDC, _In_opt_] IntPtr hdcSrc, [POINT, Ptr, _In_opt_] in POINT pptSrc, [COLORREF, _In_] uint crKey, [BLENDFUNCTION, _In_opt_] in BlendFunction pblend, [DWORD, _In_] uint dwFlags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawEdge([HDC, _In_] IntPtr hdc, [LPRECT, _Inout_] ref RECT qrc, [UINT, _In_] uint edge, [UINT, _In_] uint grfFlags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawFocusRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawFrameControl([HDC, _In_] IntPtr hdc, [LPRECT, _Inout_] ref RECT rect, [UINT, _In_] uint arg3, [UINT, _In_] uint arg4);

        #region DrawIcon
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawIcon([HDC, _In_] IntPtr hDC, [_In_] int X, [_In_] int Y, [HICON, _In_] IntPtr hIcon);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawIconEx([HDC, _In_] IntPtr hdc, [_In_] int xLeft, [_In_] int yTop, [HICON, _In_] IntPtr hIcon, [_In_] int cxWidth, [_In_] int cyWidth, [UINT, _In_] uint istepIfAniCur, [HBRUSH, _In_opt_] IntPtr hbrFlickerFreeDraw, [UINT, _In_] uint diFlags);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawMenuBar([HWND, _In_] IntPtr hWnds);

        #region DrawState
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL DrawStateA([HDC, _In_] IntPtr hdc, [HBRUSH, _In_opt_] IntPtr hbrFore, [DRAWSTATEPROC, _In_opt_] DrawStateProc qfnCallBack, [LPARAM, _In_] IntPtr lData, [WPARAM, _In_] IntPtr wData, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL DrawStateW([HDC, _In_] IntPtr hdc, [HBRUSH, _In_opt_] IntPtr hbrFore, [DRAWSTATEPROC, _In_opt_] DrawStateProc qfnCallBack, [LPARAM, _In_] IntPtr lData, [WPARAM, _In_] IntPtr wData, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndMenu();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndDialog([HWND, _In_] IntPtr hDlg, [INT_PTR, _In_] IntPtr nResult);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableWindow([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL bEnable);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndDeferWindowPos([HDWP, _In_] IntPtr hWinPosInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EndTask([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL fShutDown, [BOOL, _In_] BOOL fForce);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumChildWindows([HWND, _In_opt_] IntPtr hWndParent, [WNDENUMPROC, _In_] WndEnumProc lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint EnumClipboardFormats([UINT, _In_] uint format);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDesktopWindows([HDESK, _In_opt_] IntPtr hDesktop, [WNDENUMPROC, _In_] WndEnumProc lpfn, [LPARAM, _In_] IntPtr lParam);

        #region EnumDesktops
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDesktopsA([HWINSTA, _In_opt_] IntPtr hwinsta, [DESKTOPENUMPROCA, _In_] DesktopEnumProcA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDesktopsW([HWINSTA, _In_opt_] IntPtr hwinsta, [DESKTOPENUMPROCW, _In_] DesktopEnumProcA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        #region EnumDisplayDevices
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDisplayDevicesA([LPCSTR, _In_opt_] byte[] lpDevice, [DWORD, _In_] uint iDevNum, [PDISPLAY_DEVICEA, _Inout_] ref DisplayDeviceA lpDisplayDevice, [DWORD, _In_] uint dwFlags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDisplayDevicesW([LPCWSTR, _In_opt_] string lpDevice, [DWORD, _In_] uint iDevNum, [PDISPLAY_DEVICEW, _Inout_] ref DisplayDeviceA lpDisplayDevice, [DWORD, _In_] uint dwFlags);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EqualRect([RECT, Ptr, CONST, _In_] in RECT lprc1, [RECT, Ptr, CONST, _In_] in RECT lprc2);

        [DllImport("user32.dll")]
        public static extern int FillRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc, [HBRUSH, _In_] IntPtr hbr);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ExitWindowsEx([UINT, _In_] uint uFlags, [DWORD, _In_] uint dwReason);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SwapMouseButton([BOOL, _In_] BOOL fSwap);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetMessagePos();

        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWow64Message();

        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr SetMessageExtraInfo([LPARAM, _In_] IntPtr lParam);

        #region PeekMessage
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PeekMessageA([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax, [UINT, _In_] uint wRemoveMsg);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PeekMessageW([LPMSG, _Out_] out MSG lpMsg, [HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint wMsgFilterMin, [UINT, _In_] uint wMsgFilterMax, [UINT, _In_] uint wRemoveMsg);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PaintDesktop([HDC, _In_] IntPtr hdc);

        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr PackTouchHitTestingProximityEvaluation([TOUCH_HIT_TESTING_INPUT, Ptr, CONST, _In_] in TouchHitTestingInput pHitTestingInput, [TOUCH_HIT_TESTING_PROXIMITY_EVALUATION, Ptr, CONST, _In_] in TouchHitTestingProximityEvaluation pProximityEval);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL OffsetRect([LPRECT, _Inout_] ref RECT lprc, [_In_] int dx, [_In_] int dy);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL OpenClipboard([HWND, _In_opt_] IntPtr hWndNewOwner);

        #region OpenDesktop
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HDESK]
        public static extern IntPtr OpenDesktopA([LPCSTR, _In_] byte[] lpszDesktop, [DWORD, _In_] uint dwFlags, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HDESK]
        public static extern IntPtr OpenDesktopW([LPCWSTR, _In_] string lpszDesktop, [DWORD, _In_] uint dwFlags, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL OpenIcon([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: HDESK]
        public static extern IntPtr OpenInputDesktop([DWORD, _In_] uint dwFlags, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);

        #region OpenWindowStation
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: HWINSTA]
        public static extern IntPtr OpenWindowStationA([LPCSTR, _In_] byte[] lpszWinSta, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: HWINSTA]
        public static extern IntPtr OpenWindowStationW([LPCWSTR, _In_] string lpszWinSta, [BOOL, _In_] BOOL fInherit, [ACCESS_MASK, _In_] uint dwDesiredAccess);
        #endregion

        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr PackDDElParam([UINT, _In_] uint msg, [UINT_PTR, _In_] UIntPtr uiLo, [UINT_PTR, _In_] UIntPtr uiHi);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnpackDDElParam([UINT, _In_] uint msg, [LPARAM, _In_] IntPtr lParam, [PUINT_PTR, _Out_] out UIntPtr puiLo, [PUINT_PTR, _Out_] out UIntPtr puiHi);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL FreeDDElParam([UINT, _In_] uint msg, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll")]
        [return: LPARAM]
        public static extern IntPtr ReuseDDElParam([LPARAM] IntPtr lParam, [UINT] uint msgIn, [UINT] uint msgOut, [UINT_PTR] UIntPtr uiLo, [UINT_PTR] UIntPtr uiHi);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RemoveMenu([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags);

        #region RemoveProp
        [DllImport("user32.dll")]
        [return: HANDLE]
        public static extern IntPtr RemovePropA([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll")]
        [return: HANDLE]
        public static extern IntPtr RemovePropW([HWND, _In_] IntPtr hWnd, [LPCWSTR, _In_] byte[] lpString);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ScrollDC([HDC, _In_] IntPtr hDC, [_In_] int dx, [_In_] int dy, [RECT, Ptr, CONST, _In_opt_] in RECT lprcScroll, [RECT, Ptr, CONST, _In_opt_] in RECT lprcClip, [HRGN, _In_opt_] IntPtr hrgnUpdate, [LPRECT, _Out_opt_] out RECT lprcUpdate);

        #region ScrollWindow
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ScrollWindow([HWND, _In_] IntPtr hWnd, [_In_] int XAmount, [_In_] int YAmount, [RECT, Ptr, CONST, _In_opt_] in RECT lpRect, [RECT, Ptr, CONST, _In_opt_] in RECT lpClipRect);

        [DllImport("user32.dll")]
        public static extern int ScrollWindowEx([HWND, _In_] IntPtr hWnd, [_In_] int dx, [_In_] int dy, [RECT, Ptr, CONST, _In_opt_] in RECT prcScroll, [RECT, Ptr, CONST, _In_opt_] in RECT prcClip, [HRGN, _In_opt_] IntPtr hrgnUpdate, [LPRECT, _Out_opt_] out RECT prcUpdate, [UINT, _In_] uint flags);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ScreenToClient([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetParent([HWND, _In_] IntPtr hWndChild, [HWND, _In_opt_] IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetRect([LPRECT, _Out_] out RECT lprc, [_In_] int xLeft, [_In_] int yTop, [_In_] int xRight, [_In_] int yBottom);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetRectEmpty([LPRECT, _Out_] out RECT lprc);

        #region SetProp
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetPropA([HWND, _In_] IntPtr hWnd, [LPCSTR, _In_] byte[] lpString, [HANDLE, _In_opt_] IntPtr hData);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetPropW([HWND, _In_] IntPtr hWnd, [LPCWSTR, _In_] string lpString, [HANDLE, _In_opt_] IntPtr hData);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetSysColors([_In_] int cElements, [INT, Ptr, CONST, _In_reads_] int[] lpaElements, [COLORREF, Ptr, CONST, _In_reads_] uint[] lpaRgbValues);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetSystemCursor([HCURSOR, _In_] IntPtr hcur, [DWORD, _In_] uint id);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetThreadDesktop([HDESK, _In_] IntPtr hDesktop);

        [DllImport("user32.dll")]
        [return: DPI_AWARENESS_CONTEXT]
        public static extern IntPtr SetThreadDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr dpiContext);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetInputState();

        [DllImport("user32.dll")]
        [return: HDC]
        public static extern IntPtr GetWindowDC([HWND, _In_opt_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort GetWindowWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InflateRect([LPRECT, _Inout_] ref RECT lprc, [_In_] int dx, [_In_] int dy);

        [DllImport("user32.dll")]
        [return: HSYNTHETICPOINTERDEVICE]
        public static extern IntPtr CreateSyntheticPointerDevice([POINTER_INPUT_TYPE, _In_] PointerInputType pointerType, [ULONG, _In_] uint maxCount, [POINTER_FEEDBACK_MODE, _In_] PointerFeedbackMode mode);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DeleteMenu([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyCaret();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyCursor([HCURSOR, _In_] IntPtr hCursor);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DeregisterShellHookWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyIcon([HICON, _In_] IntPtr hIcon);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyMenu([HMENU, _In_] IntPtr hMenu);

        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void DestroySyntheticPointerDevice([HSYNTHETICPOINTERDEVICE, _In_] IntPtr device);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int GetKeyboardType([_In_] int nTypeFlag);

        [DllImport("user32.dll")]
        public static extern int GetMenuItemCount([HMENU, _In_opt_] IntPtr hMenu);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetMenuItemID([HMENU, _In_] IntPtr hMenu, [_In_] int nPos);

        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int GetMessageTime();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerType([UINT32, _In_] uint pointerId, [POINTER_INPUT_TYPE, Ptr, _Out_] out PointerInputType pointerType);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetQueueStatus([UINT, _In_] uint flags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeAbandonTransaction([DWORD, _In_] uint idInst, [HCONV, _In_] IntPtr hConv, [DWORD, _In_] uint idTransaction);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetRawInputBuffer([PRAWINPUT, _Out_writes_bytes_opt_] RawInput[] pData, [PUINT, _Inout_] ref uint pcbSize, [UINT, _In_] uint cbSizeHeader);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetRawInputData([HRAWINPUT, _In_] IntPtr hRawInput, [UINT, _In_] uint uiCommand, [LPVOID, _Out_writes_bytes_to_opt_] byte[] pData, [PUINT, _Inout_] ref uint pcbSize, [UINT, _In_] uint cbSizeHeader);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32.dll")]
        [return: HMENU]
        public static extern IntPtr GetSubMenu([HMENU, _In_] IntPtr hMenu, [_In_] int nPos);

        [DllImport("user32.dll")]
        [return: HDESK]
        public static extern IntPtr GetThreadDesktop([DWORD, _In_] uint dwThreadId);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowDisplayAffinity([HWND, _In_] IntPtr hWnd, [DWORD, Ptr, _Out_] out uint pdwAffinity);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowDisplayAffinity([HWND, _In_] IntPtr hWnd, [DWORD, _In_] uint dwAffinity);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowFeedbackSetting([HWND, _In_] IntPtr hwnd, [FEEDBACK_TYPE, _In_] FeedbackType feedback, [DWORD, _In_] uint dwFlags, [UINT32, Ptr, _Inout_] ref uint pSize, [VOID, Ptr, _Out_writes_bytes_opt_] byte[] config);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowFeedbackSetting([HWND, _In_] IntPtr hwnd, [FEEDBACK_TYPE, _In_] FeedbackType feedback, [DWORD, _In_] uint dwFlags, [UINT32, _In_] uint size, [VOID, Ptr, CONST, _In_reads_bytes_opt_] byte[] configuration);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetWindowInfo([HWND, _In_] IntPtr hWnd, [PWINDOWINFO, _Inout_] ref WindowInfo pwi);

        [DllImport("user32.dll")]
        [return: LPBYTE]
        public static extern IntPtr DdeAccessData([HDDEDATA, _In_] IntPtr hData, [LPDWORD, _Out_opt_] out uint pcbDataSize);

        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeAddData([HDDEDATA, _In_] IntPtr hData, [LPBYTE, _In_reads_bytes_] byte[] pSrc, [DWORD, _In_] uint cb, [DWORD, _In_] uint cbOff);

        [DllImport("user32.dll")]
        public static extern int DdeCmpStringHandles([HSZ, _In_] IntPtr hsz1, [HSZ, _In_] IntPtr hsz2);

        [DllImport("user32.dll")]
        [return: HCONVLIST]
        public static extern IntPtr DdeConnectList([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hszService, [HSZ, _In_] IntPtr hszTopic, [HCONVLIST, _In_] IntPtr hConvList, [PCONVCONTEXT, _In_opt_] in ConvContext pCC);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeDisconnect([HCONV, _In_] IntPtr hConv);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeDisconnectList([HCONVLIST, _In_] IntPtr hConvList);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetGUIThreadInfo([DWORD, _In_] uint idThread, [PGUITHREADINFO, _Inout_] ref GUITHREADINFO pgui);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetGestureConfig([HWND, _In_] IntPtr hwnd, [DWORD, _In_] uint dwReserved, [DWORD, _In_] uint dwFlags, [PUINT, _In_] in uint pcIDs, [PGESTURECONFIG, _Inout_updates_] ref GestureConfig pGestureConfig, [UINT, _In_] uint cbSize);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr WindowFromPhysicalPoint([_In_] POINT Point);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnhookWinEvent([HWINEVENTHOOK, _In_] IntPtr hWinEventHook);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnhookWindowsHook([_In_] int nCode, [HOOKPROC, _In_] HookProc pfnFilterProc);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL UnhookWindowsHookEx([HHOOK, _In_] IntPtr hhk);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableMenuItem([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uIDEnableItem, [UINT, _In_] uint uEnable);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableMouseInPointer([BOOL, _In_] BOOL fEnable);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsMouseInPointerEnabled();

        [DllImport("user32.dll", EntryPoint = "#2561")]
        [return: BOOL]
        public static extern BOOL EnableMouseInPointerForThread();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterTouchHitTestingWindow([HWND, _In_] IntPtr hWnd, [ULONG, _In_] uint value);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EvaluateProximityToRect([RECT, Ptr, CONST, _In_] in RECT controlBoundingBox, [TOUCH_HIT_TESTING_INPUT, Ptr, CONST, _In_] in TouchHitTestingInput pHitTestingInput, [TOUCH_HIT_TESTING_PROXIMITY_EVALUATION, Ptr, _Out_] out TouchHitTestingProximityEvaluation pProximityEval);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EvaluateProximityToPolygon([UINT32] uint numVertices, [POINT, Ptr, _In_reads_, CONST] POINT[] controlPolygon, [TOUCH_HIT_TESTING_PROXIMITY_EVALUATION, Ptr, _Out_] out TouchHitTestingProximityEvaluation pProximityEval);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL FlashWindow([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL bInvert);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DestroyAcceleratorTable([HACCEL, _In_] IntPtr hAccel);

        [DllImport("user32.dll")]
        [return: HDWP]
        public static extern IntPtr DeferWindowPos([HDWP, _In_] IntPtr hWinPosInfo, [HWND, _In_] IntPtr hWnd, [HWND, _In_opt_] IntPtr hWndInsertAfter, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeUnaccessData([HDDEDATA, _In_] IntPtr hData);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeSetQualityOfService([HWND] IntPtr hwndClient, [SECURITY_QUALITY_OF_SERVICE, Ptr, CONST] in SECURITY_QUALITY_OF_SERVICE pqosNew, [PSECURITY_QUALITY_OF_SERVICE] out SECURITY_QUALITY_OF_SERVICE pqosPrev);

        #region DdeQueryString
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint DdeQueryStringA([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz, [LPSTR, _Out_writes_opt_] byte[] psz, [DWORD, _In_] uint cchMax, [_In_] int iCodePage);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint DdeQueryStringW([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz, [LPWSTR, _Out_writes_opt_] StringBuilder psz, [DWORD, _In_] uint cchMax, [_In_] int iCodePage);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeEnableCallback([DWORD, _In_] uint idInst, [HCONV, _In_] IntPtr hConv, [UINT, _In_] uint wCmd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeFreeDataHandle([HDDEDATA, _In_] IntPtr hData);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeFreeStringHandle([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint DdeGetLastError([DWORD, _In_] uint idInst);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeImpersonateClient([HCONV, _In_] IntPtr hConv);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdeKeepStringHandle([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hsz);

        [DllImport("user32.dll")]
        [return: HDDEDATA]
        public static extern IntPtr DdeNameService([DWORD, _In_] uint idInst, [HSZ, _In_opt_] IntPtr hsz1, [HSZ, _In_opt_] IntPtr hsz2, [UINT, _In_] uint afCmd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DdePostAdvise([DWORD, _In_] uint idInst, [HSZ, _In_] IntPtr hszTopic, [HSZ, _In_] IntPtr hszItem);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint DdeQueryConvInfo([HCONV, _In_] IntPtr hConv, [DWORD, _In_] uint idTransaction, [PCONVINFO, _Inout_] ref ConvInfo pConvInfo);

        [DllImport("user32.dll")]
        [return: HCONV]
        public static extern IntPtr DdeQueryNextServer([HCONVLIST, _In_] IntPtr hConvList, [HCONV, _In_] IntPtr hConvPrev);

        #region WinHelp
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL WinHelpA([HWND, _In_opt_] IntPtr hWndMain, [LPCSTR, _In_opt_] byte[] lpszHelp, [UINT, _In_] uint uCommand, [ULONG_PTR, _In_] UIntPtr dwData);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL WinHelpW([HWND, _In_opt_] IntPtr hWndMain, [LPCWSTR, _In_opt_] byte[] lpszHelp, [UINT, _In_] uint uCommand, [ULONG_PTR, _In_] UIntPtr dwData);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SwitchDesktop([HDESK, _In_] IntPtr hDesktop);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SoundSentry();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowCaret([HWND, _In_opt_] IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ShowCursor([BOOL, _In_] BOOL bShow);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ShowOwnedPopups([HWND, _In_] IntPtr hWnd, [BOOL, _In_] BOOL fShow);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowPlacement([HWND, _In_] IntPtr hWnd, [WINDOWPLACEMENT, Ptr, CONST, _In_] in WindowPlacement lpwndpl);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetWindowPos([HWND, _In_] IntPtr hWnd, [HWND, _In_opt_] IntPtr hWndInsertAfter, [_In_] int X, [_In_] int Y, [_In_] int cx, [_In_] int cy, [UINT, _In_] uint uFlags);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn([HWND, _In_] IntPtr hWnd, [HRGN, _In_opt_] IntPtr hRgn, [BOOL, _In_] BOOL bRedraw);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMessageQueue([_In_] int cMessagesMax);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetMenuContextHelpId([HMENU, _In_] IntPtr hMenu, [DWORD, _In_] uint arg2);

        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void SetLastErrorEx([DWORD, _In_] uint dwErrCode, [DWORD, _In_] uint dwType);

        [DllImport("user32.dll")]
        [return: HCURSOR]
        public static extern IntPtr SetCursor([HCURSOR, _In_opt_] IntPtr hCursor);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetCaretPos([_In_] int X, [_In_] int Y);

        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort SetClassWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex, [WORD, _In_] ushort wNewWord);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetClipboardViewer([HWND, _In_] IntPtr hWndNewViewer);

        [DllImport("user32.dll")]
        [return: UINT_PTR]
        public static extern UIntPtr SetCoalescableTimer([HWND, _In_opt_] IntPtr hWnd, [UINT_PTR, _In_] UIntPtr nIDEvent, [UINT, _In_] uint uElapse, [TIMERPROC, _In_opt_] TimerProc lpTimerFunc, [ULONG, _In_] uint uToleranceDelay);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetCapture([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetCaretBlinkTime([UINT, _In_] uint uMSeconds);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr SetActiveWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL ReleaseCapture();

        #region LoadString
        [DllImport("user32.dll")]
        public static extern int LoadStringA([HINSTANCE, _In_opt_] IntPtr hInstance, [UINT, _In_] uint uID, [LPSTR, _Out_writes_to_] byte[] lpBuffer, [_In_] int cchBufferMax);

        [DllImport("user32.dll")]
        public static extern int LoadStringW([HINSTANCE, _In_opt_] IntPtr hInstance, [UINT, _In_] uint uID, [LPWSTR, _Out_writes_to_] StringBuilder lpBuffer, [_In_] int cchBufferMax);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL LockSetForegroundWindow([UINT, _In_] uint uLockCode);

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

        #region InsertMenu
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL InsertMenuA([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCSTR, _In_opt_] byte[] lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL InsertMenuW([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uPosition, [UINT, _In_] uint uFlags, [UINT_PTR, _In_] UIntPtr uIDNewItem, [LPCWSTR, _In_opt_] string lpNewItem);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]

        public static extern BOOL IsMenu([HMENU, _In_] IntPtr hMenu);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindow([HWND, _In_opt_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsChild([HWND, _In_] IntPtr hWndParent, [HWND, _In_] IntPtr hWnd);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsClipboardFormatAvailable([UINT, _In_] uint format);

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

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint IsDlgButtonChecked([HWND, _In_] IntPtr hDlg, [_In_] int nIDButton);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsGUIThread([BOOL, _In_] BOOL bConvert);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsHungAppWindow([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsIconic([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsImmersiveProcess([HANDLE, _In_] IntPtr hProcess);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL InvertRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetTouchInputInfo([HTOUCHINPUT, _In_] IntPtr hTouchInput, [UINT, _In_] uint cInputs, [PTOUCHINPUT, _Out_writes_] TouchInput[] pInputs, [_In_] int cbSize);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumThreadWindows([DWORD, _In_] uint dwThreadId, [WNDENUMPROC, _In_] WndEnumProc lpfn, [LPARAM, _In_] IntPtr lParam);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnumDisplayMonitors([HDC, _In_opt_] IntPtr hdc, [LPCRECT, _In_opt_] in RECT lprcClip, [MONITORENUMPROC, _In_] MonitorEnumProc lpfnEnum, [LPARAM, _In_] IntPtr dwData);

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

        #region EnumWindowStations
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL EnumWindowStationsA([WINSTAENUMPROCA, _In_] NameEnumProcA lpEnumFunc, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL EnumWindowStationsW([WINSTAENUMPROCW, _In_] NameEnumProcW lpEnumFunc, [LPARAM, _In_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        public static extern int ExcludeUpdateRgn([HDC, _In_] IntPtr hDC, [HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL FlashWindowEx([PFLASHWINFO, _In_] in FlashWInfo pfwi);

        [DllImport("user32.dll")]
        public static extern int FrameRect([HDC, _In_] IntPtr hDC, [RECT, Ptr, CONST, _In_] in RECT lprc, [HBRUSH, _In_] IntPtr hbr);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetAutoRotationState([PAR_STATE] out ArState pState);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCIMSSM([INPUT_MESSAGE_SOURCE, Ptr, _Out_] out InputMessageSource inputMessageSource);

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

        #region DefDlgProc
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LRESULT]
        public static extern IntPtr DefDlgProcA([HWND, _In_] IntPtr hDlg, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LRESULT]
        public static extern IntPtr DefDlgProcW([HWND, _In_] IntPtr hDlg, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        [return: LRESULT]
        public static extern IntPtr DefRawInputProc([PRAWINPUT, Ptr, _In_reads_] RawInput[] paRawInput, [INT, _In_] int nInput, [UINT, _In_] uint cbSizeHeader);

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

        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int DisplayConfigGetDeviceInfo([DISPLAYCONFIG_DEVICE_INFO_HEADER, Ptr, _Inout_] ref DisplayConfigDeviceInfoHeader requestPacket);

        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int DisplayConfigSetDeviceInfo([DISPLAYCONFIG_DEVICE_INFO_HEADER, Ptr, _In_] in DisplayConfigDeviceInfoHeader setPacket);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DragDetect([HWND, _In_] IntPtr hwnd, [POINT, _In_] POINT pt);

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint DragObject([HWND, _In_] IntPtr hwndParent, [HWND, _In_] IntPtr hwndFrom, [UINT, _In_] uint fmt, [ULONG_PTR, _In_] UIntPtr data, [HCURSOR, _In_opt_] IntPtr hcur);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL DrawAnimatedRects([HWND, _In_opt_] IntPtr hwnd, [_In_] int idAni, [RECT, Ptr, CONST, _In_] in RECT lprcFrom, [RECT, Ptr, CONST, _In_] in RECT lprcTo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableScrollBar([HWND, _In_] IntPtr hWnd, [UINT, _In_] uint wSBflags, [UINT, _In_] uint wArrows);

        [DllImport("user32.dll")]
        public static extern int GetDialogBaseUnits();

        [DllImport("user32.dll")]
        public static extern int GetDlgCtrlID([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetDlgItem([HWND, _In_opt_] IntPtr hDlg, [_In_] int nIDDlgItem);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDpiForSystem();

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDpiForWindow([HWND, _In_] IntPtr hwnd);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDlgItemInt([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [BOOL, Ptr, _Out_opt_] out BOOL lpTranslated, [BOOL, _In_] BOOL bSigned);

        #region SetDlgItemText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL SetDlgItemTextA([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPCSTR, _In_] byte[] lpString);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL SetDlgItemTextW([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPCWSTR, _In_] string lpString);
        #endregion

        #region GetDlgItemText
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint GetDlgItemTextA([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPSTR, _Out_writes_] byte[] lpString, [_In_] int cchMax);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint GetDlgItemTextW([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [LPWSTR, _Out_writes_] string lpString, [_In_] int cchMax);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDoubleClickTime([UINT, _In_] uint arg1);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetGestureConfig([HWND, _In_] IntPtr hwnd, [DWORD, _In_] uint dwReserved, [UINT, _In_] uint cIDs, [PGESTURECONFIG, _In_reads_] GestureConfig[] pGestureConfig, [UINT, _In_] uint cbSize);

        [DllImport("user32.dll")]
        [return: VOID]
        public static extern void SetDebugErrorLevel([DWORD, _In_] uint dwLevel);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDialogControlDpiChangeBehavior([HWND, _In_] IntPtr hWnd, [DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS, _In_] DialogControlDpiChangeBehaviors mask, [DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS, _In_] DialogControlDpiChangeBehaviors values);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDialogDpiChangeBehavior([HWND, _In_] IntPtr hDlg, [DIALOG_DPI_CHANGE_BEHAVIORS, _In_] DialogDpiChangeBehaviors mask, [DIALOG_DPI_CHANGE_BEHAVIORS, _In_] DialogDpiChangeBehaviors values);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDisplayAutoRotationPreferences([ORIENTATION_PREFERENCE, _In_] OrientationPreference orientation);

        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int SetDisplayConfig([UINT32, _In_] uint numPathArrayElements, [DISPLAYCONFIG_PATH_INFO, Ptr, _In_reads_opt_] DISPLAYCONFIG_PATH_INFO pathArray, [UINT32, _In_] uint numModeInfoArrayElements, [DISPLAYCONFIG_MODE_INFO, Ptr, _In_reads_opt_] DISPLAYCONFIG_MODE_INFO modeInfoArray, [UINT32, _In_] uint flags);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetDlgItemInt([HWND, _In_] IntPtr hDlg, [_In_] int nIDDlgItem, [UINT, _In_] uint uValue, [BOOL, _In_] BOOL bSigned);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL SetLayeredWindowAttributes([HWND, _In_] IntPtr hwnd, [COLORREF, _In_] uint crKey, [BYTE, _In_] byte bAlpha, [DWORD, _In_] uint dwFlags);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetOpenClipboardWindow();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPhysicalCursorPos([LPPOINT, _Out_] out POINT lpPoint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerCursorId([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Out_] out uint cursorId);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDevices([UINT32, Ptr, _Inout_] uint deviceCount, [POINTER_DEVICE_INFO, Ptr, _Out_writes_opt_] PointerDeviceInfo[] pointerDevices);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDeviceCursors([HANDLE, _In_] IntPtr device, [UINT32, Ptr, _Inout_] ref uint cursorCount, [POINTER_DEVICE_CURSOR_INFO, Ptr, _Out_writes_opt_] PointerDeviceCursorInfo[] deviceCursors);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDeviceProperties([HANDLE, _In_] IntPtr device, [UINT32, Ptr, _Inout_] ref uint propertyCount, [POINTER_DEVICE_PROPERTY, Ptr, _Out_writes_opt_] PointerDeviceProperty[] pointerProperties);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDeviceRects([HANDLE, _In_] IntPtr device, [RECT, Ptr, _Out_writes_] out RECT pointerDeviceRect, [RECT, Ptr, _Out_writes_] out RECT displayRect);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerDevices([UINT32, Ptr, _Inout_] ref uint deviceCount, [POINTER_DEVICE_INFO, Ptr, _Out_writes_opt_] PointerDeviceInfo[] pointerDevices);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameInfo([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_INFO, Ptr, _Out_writes_opt_] PointerInfo[] pointerInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_INFO, Ptr, _Out_writes_opt_] PointerInfo[] pointerInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFramePenInfo([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_PEN_INFO, Ptr, _Out_writes_opt_] POINTER_PEN_INFO[] penInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFramePenInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_PEN_INFO, Ptr, _Out_writes_opt_] POINTER_PEN_INFO[] penInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameTouchInfo([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_TOUCH_INFO, Ptr, _Out_writes_opt_] PointerTouchInfo[] touchInfo);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetPointerFrameTouchInfoHistory([UINT32, _In_] uint pointerId, [UINT32, Ptr, _Inout_] ref uint entriesCount, [UINT32, Ptr, _Inout_] ref uint pointerCount, [POINTER_TOUCH_INFO, Ptr, _Out_writes_opt_] PointerTouchInfo[] touchInfo);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetCapture();

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetCaretBlinkTime();

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCaretPos([LPPOINT, _Out_] out POINT lpPoint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetCurrentInputMessageSource([INPUT_MESSAGE_SOURCE, Ptr, _Out_] out InputMessageSource inputMessageSource);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetComboBoxInfo([HWND, _In_] IntPtr hwndCombo, [PCOMBOBOXINFO, _Inout_] ref ComboBoxInfo pcbi);

        [DllImport("user32.dll")]
        [return: DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS]
        public static extern DialogControlDpiChangeBehaviors GetDialogControlDpiChangeBehavior([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: DIALOG_DPI_CHANGE_BEHAVIORS]
        public static extern DialogControlDpiChangeBehaviors GetDialogDpiChangeBehavior([HWND, _In_] IntPtr hDlg);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetDisplayAutoRotationPreferences([ORIENTATION_PREFERENCE, Ptr, _Out_] out OrientationPreference pOrientation);

        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int GetDisplayConfigBufferSizes([UINT32, _In_] uint flags, [UINT32, Ptr, _Out_] out uint numPathArrayElements, [UINT32, Ptr, _Out_] out uint numModeInfoArrayElements);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDoubleClickTime();

        [DllImport("user32.dll")]
        [return: DPI_AWARENESS_CONTEXT]
        public static extern IntPtr GetDpiAwarenessContextForProcess([HANDLE, _In_] IntPtr hProcess);

        [DllImport("user32.dll")]
        [return: UINT]
        public static extern uint GetDpiFromDpiAwarenessContext([DPI_AWARENESS_CONTEXT, _In_] IntPtr value);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL EnableNonClientDpiScaling([HWND, _In_] IntPtr hwnd);

        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort TileWindows([HWND, _In_opt_] IntPtr hwndParent, [UINT, _In_] uint wHow, [RECT, Ptr, CONST, _In_opt_] in RECT lpRect, [UINT, _In_] uint cKids, [HWND, Ptr, CONST, _In_reads_opt_] IntPtr lpKids);

        #region TabbedTextOut
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: LONG]
        public static extern int TabbedTextOutA([HDC, _In_] IntPtr hdc, [_In_] int x, [_In_] int y, [LPCSTR, _In_reads_] byte[] lpString, [_In_] int chCount, [_In_] int nTabPositions, [INT, Ptr, CONST, _In_reads_opt_] int[] lpnTabStopPositions, [_In_] int nTabOrigin);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: LONG]
        public static extern int TabbedTextOutW([HDC, _In_] IntPtr hdc, [_In_] int x, [_In_] int y, [LPCWSTR, _In_reads_] string lpString, [_In_] int chCount, [_In_] int nTabPositions, [INT, Ptr, CONST, _In_reads_opt_] int[] lpnTabStopPositions, [_In_] int nTabOrigin);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TrackMouseEvent([LPTRACKMOUSEEVENT, _Inout_] ref TrackMouseEventStruct lpEventTrack);

        #region TrackPopupMenu
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TrackPopupMenu([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uFlags, [_In_] int x, [_In_] int y, [_Reserved_] int nReserved, [HWND, _In_] IntPtr hWnd, [RECT, Ptr, _Reserved_, CONST] in RECT prcRect);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL TrackPopupMenuEx([HMENU, _In_] IntPtr hMenu, [UINT, _In_] uint uFlags, [_In_] int x, [_In_] int y, [HWND, _In_] IntPtr hwnd, [LPTPMPARAMS, _In_opt_] in TPMParams lptpm);
        #endregion

        #region PostMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL PostMessageA([HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL PostMessageW([HWND, _In_opt_] IntPtr hWnd, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PhysicalToLogicalPoint([HWND, _In_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PhysicalToLogicalPointForPerMonitorDPI([HWND, _In_opt_] IntPtr hWnd, [LPPOINT, _Inout_] ref POINT lpPoint);

        #region PostThreadMessage
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL PostThreadMessageA([DWORD, _In_] uint idThread, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL PostThreadMessageW([DWORD, _In_] uint idThread, [UINT, _In_] uint Msg, [WPARAM, _In_] IntPtr wParam, [LPARAM, _In_] IntPtr lParam);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PrintWindow([HWND, _In_] IntPtr hwnd, [HDC, _In_] IntPtr hdcBlt, [UINT, _In_] uint nFlags);

        #region PrivateExtractIcons
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        [return: UINT]
        public static extern uint PrivateExtractIconsA([LPCSTR, _In_reads_] byte[] szFileName, [_In_] int nIconIndex, [_In_] int cxIcon, [_In_] int cyIcon, [HICON, Ptr, _Out_writes_opt_] IntPtr phicon, [UINT, Ptr, _Out_writes_opt_] uint piconid, [UINT, _In_] uint nIcons, [UINT, _In_] uint flags);


        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: UINT]
        public static extern uint PrivateExtractIconsW([LPCWSTR, _In_reads_] string szFileName, [_In_] int nIconIndex, [_In_] int cxIcon, [_In_] int cyIcon, [HICON, Ptr, _Out_writes_opt_] IntPtr phicon, [UINT, Ptr, _Out_writes_opt_] uint piconid, [UINT, _In_] uint nIcons, [UINT, _In_] uint flags);
        #endregion

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL PtInRect([RECT, Ptr, _In_, CONST] in RECT lprc, [POINT, _In_] POINT pt);

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

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsZoomed([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindowVisible([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindowUnicode([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWindowEnabled([HWND, _In_] IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL IsWinEventHookInstalled([DWORD, _In_] uint @event);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterHotKey([HWND, _In_opt_] IntPtr hWnd, [_In_] int id, [UINT, _In_] ModifierKeys fsModifiers, [UINT, _In_] VirtualKeys vk);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RegisterPointerDeviceNotifications([HWND, _In_] IntPtr window, [BOOL, _In_] BOOL notifyRange);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL RedrawWindow([HWND, _In_opt_] IntPtr hWnd, [RECT, Ptr, CONST, _In_opt_] in RECT lprcUpdate, [HRGN, _In_opt_] IntPtr hrgnUpdate, [UINT, _In_] uint flags);

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr RealChildWindowFromPoint([HWND, _In_] IntPtr hwndParent, [POINT, _In_] POINT ptParentClientCoords);

        [DllImport("user32.dll")]
        [return: LONG]
        public static extern int QueryDisplayConfig([UINT32, _In_] uint flags, [UINT32, Ptr, _Inout_] ref uint numPathArrayElements, [DISPLAYCONFIG_PATH_INFO, Ptr, _Out_writes_to_] DISPLAYCONFIG_PATH_INFO[] pathArray, [UINT32, Ptr, _Inout_] ref uint numModeInfoArrayElements, [DISPLAYCONFIG_MODE_INFO, Ptr, _Out_writes_to_] DISPLAYCONFIG_MODE_INFO[] modeInfoArray, [DISPLAYCONFIG_TOPOLOGY_ID, Ptr] out DISPLAYCONFIG_TOPOLOGY_ID currentTopologyId);

        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL QuerySendMessage([MSG, Ptr] ref MSG pMsg);

        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL IsServerSideWindow([HWND] IntPtr hWnd);

        [DllImport("user32.dll")] // NOTE: Inaccurate
        [return: BOOL]
        public static extern BOOL IsThreadDesktopComposited();

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

        [DllImport("user32.dll")]
        [return: WORD]
        public static extern ushort GetClassWord([HWND, _In_] IntPtr hWnd, [_In_] int nIndex);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetClientRect([HWND, _In_] IntPtr hWnd, [LPRECT, _Out_] out RECT lpRect);

        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL GetClipCursor([LPRECT, _Out_] out RECT lpRect);

        [DllImport("user32.dll")]
        [return: HANDLE]
        public static extern IntPtr GetClipboardData([UINT, _In_] uint uFormat);

        #region GetClipboardFormatName
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int GetClipboardFormatNameA([UINT, _In_] uint format, [LPSTR, _Out_writes_] byte[] lpszFormatName, [_In_] int cchMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetClipboardFormatNameW([UINT, _In_] uint format, [LPWSTR, _Out_writes_] StringBuilder lpszFormatName, [_In_] int cchMaxCount);
        #endregion

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetClipboardOwner();

        [DllImport("user32.dll")]
        [return: HWND]
        public static extern IntPtr GetClipboardViewer();

        [DllImport("user32.dll")]
        [return: DWORD]
        public static extern uint GetClipboardSequenceNumber();

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

        [DllImport("user32.dll")]
        public static extern IntPtr GetAncestor([HWND, _In_] IntPtr hwnd, [UINT, _In_] uint gaFlags);


    }

    [StructLayout(LayoutKind.Sequential)]
    [ALTTABINFO]
    public struct ALTTABINFO
    {
        [DWORD]public uint cbSize;
        public int cItems;
        public int cColumns;
        public int cRows;
        public int iColFocus;
        public int iRowFocus;
        public int cxItem;
        public int cyItem;
        [POINT]public POINT ptStart;
    }






    [DRAWSTATEPROC]
    [return: BOOL]
    public delegate BOOL DrawStateProc([HDC] IntPtr hdc, [LPARAM] IntPtr lData, [WPARAM] IntPtr wData, int cx, int cy);

    [DLGPROC]
    [return: INT_PTR]
    public delegate IntPtr DLGProc([HWND] IntPtr hwnd, [UINT] uint arg2, [WPARAM] IntPtr arg3, [LPARAM] IntPtr arg4);

    [PFNCALLBACK]
    [return: HDDEDATA]
    public delegate IntPtr PfnCallback([UINT] uint uType, [UINT] uint uFmt, [HCONV] IntPtr hconv, [HSZ] IntPtr hsz1, [HSZ] IntPtr hsz2, [HDDEDATA] IntPtr hdata, [ULONG_PTR] UIntPtr dwData1, [ULONG_PTR] UIntPtr dwData2);

    [WNDPROC]
    [return: LRESULT]
    public delegate IntPtr WndProc([HWND] IntPtr hWnd, [UINT] uint msg, [WPARAM] IntPtr wParam, [LPARAM] IntPtr lParam);

    [WNDENUMPROC]
    [return: BOOL]
    public delegate BOOL WndEnumProc([HWND] IntPtr hWnd, [LPARAM] IntPtr lParam);

    [HOOKPROC]
    [return: LRESULT]
    public delegate IntPtr HookProc(int code, [WPARAM] IntPtr wParam, [LPARAM] IntPtr lParam);

    [TIMERPROC]
    [return: VOID]
    public delegate void TimerProc([HWND] IntPtr hwnd, [UINT] uint arg2, [UINT_PTR] UIntPtr arg3, [DWORD] uint arg4);

    [DESKTOPENUMPROCA]
    [return: BOOL]
    public delegate BOOL DesktopEnumProcA([LPSTR] byte[] str, [LPARAM] IntPtr lParam);

    [DESKTOPENUMPROCW]
    [return: BOOL]
    public delegate BOOL DesktopEnumProcW([LPWSTR] string str, [LPARAM] IntPtr lParam);

    [PROPENUMPROCA]
    [return: BOOL]
    public delegate BOOL PropEnumProcA([HWND] IntPtr hWnd, [LPCSTR] byte[] str, [HANDLE] IntPtr handle);

    [PROPENUMPROCW]
    [return: BOOL]
    public delegate BOOL PropEnumProcW([HWND] IntPtr hWnd, [LPCWSTR] string str, [HANDLE] IntPtr handle);

    [PROPENUMPROCEXA]
    [return: BOOL]
    public delegate BOOL PropEnumProcExA([HWND] IntPtr hWnd, [LPCSTR] byte[] str, [HANDLE] IntPtr handle, [ULONG_PTR] UIntPtr arg4);

    [PROPENUMPROCEXW]
    [return: BOOL]
    public delegate BOOL PropEnumProcExW([HWND] IntPtr hWnd, [LPCWSTR] string str, [HANDLE] IntPtr handle, [ULONG_PTR] UIntPtr arg4);

    [MONITORENUMPROC]
    [return: BOOL]
    public delegate BOOL MonitorEnumProc([HMONITOR] IntPtr hMonitor, [HDC] IntPtr hdc, [LPRECT] IntPtr lpRect, [LPARAM] IntPtr lParam);

    [NAMEENUMPROCA]
    [return: BOOL]
    public delegate BOOL NameEnumProcA([LPSTR] byte[] str, [LPARAM] IntPtr lParam);

    [NAMEENUMPROCW]
    [return: BOOL]
    public delegate BOOL NameEnumProcW([LPWSTR] byte[] str, [LPARAM] IntPtr lParam);


}
