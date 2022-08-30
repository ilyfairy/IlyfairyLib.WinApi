using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_PATH_TARGET_INFO]
    public struct DISPLAYCONFIG_PATH_TARGET_INFO
    {
        [LUID] public LUID adapterId;
        [UINT32] public uint id;
        public ModeInfoIdxUnion modeInfoIdxUnion;
        [DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY]public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
        [DISPLAYCONFIG_ROTATION] public DISPLAYCONFIG_ROTATION rotation;
        [DISPLAYCONFIG_SCALING] public DISPLAYCONFIG_SCALING scaling;
        [DISPLAYCONFIG_RATIONAL] public DISPLAYCONFIG_RATIONAL refreshRate;
        [DISPLAYCONFIG_SCANLINE_ORDERING] public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
        [BOOL] public BOOL targetAvailable;
        [UINT32] public uint statusFlags;

        [StructLayout(LayoutKind.Explicit)]
        public struct ModeInfoIdxUnion
        {
            [FieldOffset(0)]
            [UINT32] public uint modeInfoIdx;
            [FieldOffset(0)]
            [UINT32] public ushort desktopModeInfoIdx;
            [FieldOffset(2)]
            [UINT32] public ushort targetModeInfoIdx;
        }
    }


}
