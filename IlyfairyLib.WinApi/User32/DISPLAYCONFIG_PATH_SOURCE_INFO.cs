using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_PATH_SOURCE_INFO]
    public struct DISPLAYCONFIG_PATH_SOURCE_INFO
    {
        [LUID] public LUID adapterId;
        [UINT32] public uint id;
        public ModeInfoIdxUnion modeInfoIdxUnion;
        [UINT32] public uint statusFlags;

        [StructLayout(LayoutKind.Explicit)]
        public struct ModeInfoIdxUnion
        {
            [FieldOffset(0)]
            [UINT32] public uint modeInfoIdx;
            [FieldOffset(0)]
            [UINT32] public ushort cloneGroupId;
            [FieldOffset(2)]
            [UINT32] public ushort sourceModeInfoIdx;
        }
    }


}
