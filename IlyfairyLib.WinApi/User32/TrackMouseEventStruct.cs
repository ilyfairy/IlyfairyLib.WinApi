using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [TRACKMOUSEEVENT]
    public struct TrackMouseEventStruct
    {
        [DWORD] public uint cbSize;
        [DWORD] public uint dwFlags;
        [HWND] public IntPtr hwndTrack;
        [DWORD] public uint dwHoverTime;
    }


}
