using IlyfairyLib.WinApi.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.Gdi32
{
    public static class Gdi32Methods
    {
        [DllImport("gdi32.dll")]
        [return: BOOL]
        public static extern BOOL BitBlt([HDC, _In_] IntPtr hdc, [_In_] int x, [_In_] int y, [_In_] int cx, [_In_] int cy, [HDC, _In_opt_] IntPtr hdcSrc, [_In_] int x1, [_In_] int y1, [DWORD, _In_] TernaryRasterOperations rop);

        #region SetPixel
        [DllImport("gdi32.dll")]
        [return: COLORREF]
        public static extern uint SetPixel([HDC, _In_] IntPtr hdc, [_In_] int x, [_In_] int y, [COLORREF, _In_] uint color);
        #endregion

    }
}
