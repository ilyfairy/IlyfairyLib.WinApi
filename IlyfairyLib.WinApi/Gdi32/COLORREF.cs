using System.Drawing;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct COLORREF
    {
        public byte _;
        public byte B;
        public byte G;
        public byte R;

        public COLORREF(byte r, byte g, byte b, byte _ = 0)
        {
            R = r;
            G = g;
            B = b;
            this._ = _;
        }

        public COLORREF(uint color)
        {
            R = (byte)((color >> 0) & 0xff);
            G = (byte)((color >> 8) & 0xff);
            B = (byte)((color >> 16) & 0xff);
            _ = (byte)((color >> 24) & 0xff);
        }

        public COLORREF(int color)
        {
            R = (byte)((color >> 0) & 0xff);
            G = (byte)((color >> 8) & 0xff);
            B = (byte)((color >> 16) & 0xff);
            _ = 0;
        }

        public static implicit operator COLORREF(uint color) => new COLORREF(color);

        public static explicit operator COLORREF(int color) => new COLORREF(color);

        public static implicit operator uint(COLORREF color) => color.R | (uint)color.G << 8 | (uint)color.B << 16;

        public static implicit operator COLORREF(Color color) => new COLORREF { R = color.R, G = color.G, B = color.B };

        public static implicit operator Color(COLORREF color) => new COLORREF { R = color.R, G = color.G, B = color.B };

        public static COLORREF operator +(COLORREF left, COLORREF right)
        {
            return new COLORREF((byte)(left.R + right.R), (byte)(left.G + right.G), (byte)(left.B + right.B), (byte)(left._ + right._));
        }

        public static COLORREF operator -(COLORREF left, COLORREF right)
        {
            return new COLORREF((byte)(left.R - right.R), (byte)(left.G - right.G), (byte)(left.B - right.B), (byte)(left._ - right._));
        }
    }
}
