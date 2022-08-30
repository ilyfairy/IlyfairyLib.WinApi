using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTER_DEVICE_INFO]
    public struct PointerDeviceInfo
    {
        public const int POINTER_DEVICE_PRODUCT_STRING_MAX = 520;
        [DWORD] public uint displayOrientation;
        [HANDLE] public IntPtr device;
        [POINTER_DEVICE_TYPE] public POINTER_DEVICE_TYPE pointerDeviceType;
        [HMONITOR] public IntPtr monitor;
        [ULONG] public uint startingCursorId;
        [USHORT] public ushort maxActiveContacts;
        [WCHAR] public unsafe fixed char productString[POINTER_DEVICE_PRODUCT_STRING_MAX];
    }


}
