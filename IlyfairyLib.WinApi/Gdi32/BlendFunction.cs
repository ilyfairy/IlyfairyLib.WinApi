using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [BLENDFUNCTION]
    public struct BlendFunction
    {
        [BYTE] public byte BlendOp;
        [BYTE] public byte BlendFlags;
        [BYTE] public byte SourceConstantAlpha;
        [BYTE] public byte AlphaFormat;
    }
}
