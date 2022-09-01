using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [OBJECT_TYPE_LIST]
    public struct OBJECT_TYPE_LIST
    {
        [WORD] public ushort Level;
        [WORD] public ushort Sbz;
        [GUID] public unsafe GUID* ObjectType;
    }
}
