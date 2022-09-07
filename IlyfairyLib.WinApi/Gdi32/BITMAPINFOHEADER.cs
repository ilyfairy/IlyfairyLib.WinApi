using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [BITMAPINFOHEADER]
    public struct BITMAPINFOHEADER
    {
        [DWORD] public uint biSize;
        [LONG] public int biWidth;
        [LONG] public int biHeight;
        [WORD] public ushort biPlanes;
        [WORD] public ushort biBitCount;
        [DWORD] public uint biCompression;
        [DWORD] public uint biSizeImage;
        [LONG] public int biXPelsPerMeter;
        [LONG] public int biYPelsPerMeter;
        [DWORD] public uint biClrUsed;
        [DWORD] public uint biClrImportant;
    }
}
