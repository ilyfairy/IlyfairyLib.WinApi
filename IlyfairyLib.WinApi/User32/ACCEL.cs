using IlyfairyLib.WinApi.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Explicit)]
    [ACCEL]
    public struct Accel
    {
        [FieldOffset(0)]
        [BYTE]
        public byte fVirt;
        [FieldOffset(1)]
        [WORD]
        public ushort key;
        [FieldOffset(3)]
        [WORD]
        public ushort cmd;
    }



}
