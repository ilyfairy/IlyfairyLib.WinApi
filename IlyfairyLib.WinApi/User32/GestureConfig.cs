using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GestureConfig
    {
        [DWORD] public uint dwID;
        [DWORD] public uint dwWant;
        [DWORD] public uint dwBlock;
    }
}
