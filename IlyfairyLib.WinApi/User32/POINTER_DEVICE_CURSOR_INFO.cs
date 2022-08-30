using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTER_DEVICE_CURSOR_INFO]
    public struct PointerDeviceCursorInfo
    {
        [UINT32] public uint cursorId;
        [POINTER_DEVICE_CURSOR_TYPE] public PointerDeviceCursorType cursor;
    }


}
