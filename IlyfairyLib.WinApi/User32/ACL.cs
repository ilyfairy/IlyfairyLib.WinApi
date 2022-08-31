﻿using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [ACL]
    public struct ACL
    {
        [BYTE] byte AclRevision;
        [BYTE] byte Sbz1;
        [WORD] ushort AclSize;
        [WORD] ushort AceCount;
        [WORD] ushort Sbz2;
    }


}
