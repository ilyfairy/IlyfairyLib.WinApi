﻿using System;

namespace IlyfairyLib.WinApi.User32
{
    [Flags]
    public enum PointerFlags
    {
        POINTER_FLAG_NONE = 0x00000000,
        POINTER_FLAG_NEW = 0x00000001,
        POINTER_FLAG_INRANGE = 0x00000002,
        POINTER_FLAG_INCONTACT = 0x00000004,
        POINTER_FLAG_FIRSTBUTTON = 0x00000010,
        POINTER_FLAG_SECONDBUTTON = 0x00000020,
        POINTER_FLAG_THIRDBUTTON = 0x00000040,
        POINTER_FLAG_FOURTHBUTTON = 0x00000080,
        POINTER_FLAG_FIFTHBUTTON = 0x00000100,
        POINTER_FLAG_PRIMARY = 0x00002000,
        POINTER_FLAG_CONFIDENCE = 0x00004000,
        POINTER_FLAG_CANCELED = 0x00008000,
        POINTER_FLAG_DOWN = 0x00010000,
        POINTER_FLAG_UPDATE = 0x00020000,
        POINTER_FLAG_UP = 0x00040000,
        POINTER_FLAG_WHEEL = 0x00080000,
        POINTER_FLAG_HWHEEL = 0x00100000,
        POINTER_FLAG_CAPTURECHANGED = 0x00200000,
        POINTER_FLAG_HASTRANSFORM = 0x00400000,
    }
}