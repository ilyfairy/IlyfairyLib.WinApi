using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.Gdi32
{
    [StructLayout(LayoutKind.Sequential)]
    [DISPLAYCONFIG_PATH_INFO]
    public struct DISPLAYCONFIG_PATH_INFO
    {
        [DISPLAYCONFIG_PATH_SOURCE_INFO] public DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;
        [DISPLAYCONFIG_PATH_TARGET_INFO] public DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;
        [UINT32] public uint flags;
    }


}
