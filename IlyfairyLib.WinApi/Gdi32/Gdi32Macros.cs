using IlyfairyLib.WinApi.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.Gdi32
{
    public static class Gdi32Macros
    {
        public static uint MAKEROP4(uint fore, uint back) => ((back << 8) & 0xFF000000) | fore;

        [return: COLORREF]
        public static uint RGB(byte r, byte g, byte b) => r | (uint)g << 8 | (uint)b << 16;

        public static uint PALETTERGB(byte r, byte g, byte b) => 0x02000000 | RGB(r, g, b);

        [return: COLORREF]
        public static uint PALETTEINDEX(uint i) => 0x01000000 | (uint)(ushort)i;

        public static byte GetRValue([COLORREF] uint rgb) => (byte)(rgb & 0xff);

        public static byte GetGValue([COLORREF] uint rgb) => (byte)((rgb >> 8) & 0xff);

        public static byte GetBValue([COLORREF] uint rgb) => (byte)((rgb >> 16) & 0xff);

        public static byte GetKValue(uint cmyk) => (byte)cmyk;

        public static byte GetYValue(uint cmyk) => (byte)(cmyk >> 8);

        public static byte GetMValue(uint cmyk) => (byte)(cmyk >> 16);

        public static byte GetCValue(uint cmyk) => (byte)(cmyk >> 24);

        public static uint CMYK(byte c, byte m, byte y, byte k) => k | ((uint)y << 8) | ((uint)m << 16) | ((uint)c << 24);

        public static uint GDI_WIDTHBYTES(uint bits) => ((bits + 31) & (~31u)) / 8;

        public static uint GDI_DIBWIDTHBYTES(in BITMAPINFOHEADER bi) => GDI_WIDTHBYTES(((uint)bi.biWidth) * ((uint)bi.biBitCount));

        public static uint GDI__DIBSIZE(in BITMAPINFOHEADER bi) => GDI_DIBWIDTHBYTES(bi) * (uint)bi.biHeight;

        public static long GDI_DIBSIZE(in BITMAPINFOHEADER bi) => (bi.biHeight < 0) ? (-1) * GDI__DIBSIZE(bi) : GDI__DIBSIZE(bi);


    }
}
