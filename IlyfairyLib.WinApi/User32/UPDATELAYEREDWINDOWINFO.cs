using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [UPDATELAYEREDWINDOWINFO]
    public struct UPDATELAYEREDWINDOWINFO
    {
        [DWORD] public uint cbSize;
        [HDC] public IntPtr hdcDst;
        [POINT, Ptr, CONST] public unsafe POINT* pptDst;
        [SIZE, Ptr, CONST] public unsafe SIZE* psize;
        [HDC] public IntPtr hdcSrc;
        [POINT, Ptr, CONST] public unsafe POINT* pptSrc;
        [COLORREF] public uint crKey;
        [BLENDFUNCTION, Ptr, CONST] public unsafe BlendFunction* pblend;
        [DWORD] public uint dwFlags;
        [RECT, Ptr, CONST] public unsafe RECT* prcDirty;
    }


}
