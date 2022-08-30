using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [POINTER_DEVICE_PROPERTY]
    public struct PointerDeviceProperty
    {
        [INT32] public int logicalMin;
        [INT32] public int logicalMax;
        [INT32] public int physicalMin;
        [INT32] public int physicalMax;
        [UINT32] public uint unit;
        [UINT32] public uint unitExponent;
        [USHORT] public ushort usagePageId;
        [USHORT] public ushort usageId;
    }


}
