using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_MODE_INFO]
    public struct DISPLAYCONFIG_MODE_INFO
    {
        [DISPLAYCONFIG_MODE_INFO_TYPE]public  DISPLAYCONFIG_MODE_INFO_TYPE infoType;
        [UINT32]public  uint id;
        [LUID] public LUID adapterId;
        public DisplayConfigUnion displayConfigUnion;

        [StructLayout(LayoutKind.Sequential)]
        public struct DisplayConfigUnion
        {
            [DISPLAYCONFIG_TARGET_MODE] public DISPLAYCONFIG_TARGET_MODE targetMode;
            [DISPLAYCONFIG_SOURCE_MODE] public DISPLAYCONFIG_SOURCE_MODE sourceMode;
            [DISPLAYCONFIG_DESKTOP_IMAGE_INFO] public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
        }
    }


}
