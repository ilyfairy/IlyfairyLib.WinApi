using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [RAWKEYBOARD]
    public struct PawKeyboard
    {
        [USHORT] ushort MakeCode;
        [USHORT] ushort Flags;
        [USHORT] ushort Reserved;
        [USHORT] ushort VKey;
        [UINT] uint Message;
        [ULONG] uint ExtraInformation;
    }
}
