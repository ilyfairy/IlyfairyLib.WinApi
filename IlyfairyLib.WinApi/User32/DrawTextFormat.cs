using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
    public enum DrawTextFormat : uint
    {
        Top = 0,
        Left = 0,
        Center = 1,
        Right = 2,
        VCenter = 4,
        Bottom = 8,
        WordBreak = 0x10,
        SingleLine = 0x20,
        ExpandTabs = 0x40,
        TabStop = 0x80,
        NoClip = 0x100,
        ExternalLeading = 0x200,
        CalcRect = 0x400,
        NoPrefix = 0x800,
        Internal = 0x1000,
        EditControl = 0x2000,
        PathEllipsis = 0x4000,
        EndEllipsis = 0x8000,
        ModifyString = 0x10000,
        RtlReading = 0x20000,
        WordEllipsis = 0x40000,
        NoFullWidthCharBreak = 0x80000,
        HidePrefix = 0x100000,
        PrefixOnly= 0x200000,
    }
}