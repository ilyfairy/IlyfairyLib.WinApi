using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [SECURITY_DESCRIPTOR]
    public unsafe struct SECURITY_DESCRIPTOR
    {
        [BYTE] public byte Revision;
        [BYTE] public byte Sbz1;
        [SECURITY_DESCRIPTOR_CONTROL] public uint Control;
        [PSID] public void* Owner;
        [PSID] public void* Group;
        [PACL] public ACL* Sacl;
        [PACL] public ACL* Dacl;
    }


}
