using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_VIDEO_SIGNAL_INFO]
    public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
    {
        [UINT64] public ulong pixelRate;
        [DISPLAYCONFIG_RATIONAL] public DISPLAYCONFIG_RATIONAL hSyncFreq;
        [DISPLAYCONFIG_RATIONAL] public DISPLAYCONFIG_RATIONAL vSyncFreq;
        [DISPLAYCONFIG_2DREGION] public DISPLAYCONFIG_2DREGION activeSize;
        [DISPLAYCONFIG_2DREGION] public DISPLAYCONFIG_2DREGION totalSize;
        public VideoStandardUnion videoStandardUnion;
        [DISPLAYCONFIG_SCANLINE_ORDERING] public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;


        public struct VideoStandardUnion
        {
            public AdditionalSignalInfo additionalSignalInfo;
            [UINT32] public uint videoStandard;
        }

        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public struct AdditionalSignalInfo
        {
            [UINT32] public unsafe fixed byte videoStandard[16];
            [UINT32] public unsafe fixed byte vSyncFreqDivider[6];
            [UINT32] public unsafe fixed byte reserved[10];

            //[UINT32]public uint videoStandard : 16;
            //[UINT32]public uint vSyncFreqDivider : 6;
            //[UINT32]public uint reserved : 10;
        }
    }


}
