using IlyfairyLib.WinApi.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
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

    [MSGBOXCALLBACK]
    [return: VOID]
    public delegate BOOL MsgBoxCallback([LPHELPINFO] ref HELPINFO lpHelpInfo);

    [GRAYSTRINGPROC]
    [return: VOID]
    public delegate BOOL GrayStringProc([HDC] IntPtr hdc, [LPARAM] IntPtr lParam, int arg3);

    [SENDASYNCPROC]
    [return: VOID]
    public delegate void SendAsyncProc([HWND] IntPtr hwnd, [UINT] uint arg2, [ULONG_PTR] UIntPtr arg3, [LRESULT] IntPtr arg4);

    [WINEVENTPROC]
    [return: VOID]
    public delegate void WinEventProc([HWINEVENTHOOK] IntPtr hWinEventHook, [DWORD] uint @event, [HWND] IntPtr hwnd, [LONG] int idObject, [LONG] int idChild, [DWORD] uint idEventThread, [DWORD] uint dwmsEventTime);

}
