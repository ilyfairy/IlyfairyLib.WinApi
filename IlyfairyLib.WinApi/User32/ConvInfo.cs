using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [CONVINFO]
    public struct ConvInfo
    {
        [DWORD] public uint cb;
        [DWORD_PTR] public IntPtr hUser;
        [HCONV] public IntPtr hConvPartner;
        [HSZ] public IntPtr hszSvcPartner;
        [HSZ] public IntPtr hszServiceReq;
        [HSZ] public IntPtr hszTopic;
        [HSZ] public IntPtr hszItem;
        [UINT] public uint wFmt;
        [UINT] public uint wType;
        [UINT] public uint wStatus;
        [UINT] public uint wConvst;
        [UINT] public uint wLastError;
        [HCONVLIST] public IntPtr hConvList;
        [CONVCONTEXT] public IntPtr ConvCtxt;
        [HWND] public IntPtr hwnd;
        [HWND] public IntPtr hwndPartner;
    }
}
