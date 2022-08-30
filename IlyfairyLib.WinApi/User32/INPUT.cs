using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Sequential)]
    [INPUT]
    public struct Input
    {
        [DWORD] public InputType type;
        public InputUnion inputUnion;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InputUnion
    {
        [FieldOffset(0)]
        public MouseInput mi;
        [FieldOffset(0)]
        public KeybdInput ki;
        [FieldOffset(0)]
        public HardwareInput hi;
    }

    [StructLayout(LayoutKind.Sequential)]
    [MOUSEINPUT]
    public struct MouseInput
    {
        [LONG] public int dx;
        [LONG] public int dy;
        [DWORD] public uint mouseData;
        [DWORD] public uint dwFlags;
        [DWORD] public uint time;
        [ULONG_PTR] public UIntPtr dwExtraInfo;
    }

    [KEYBDINPUT]
    public struct KeybdInput
    {
        [WORD] public ushort wVk;
        [WORD] public ushort wScan;
        [DWORD] public uint dwFlags;
        [DWORD] public uint time;
        [ULONG_PTR] public UIntPtr dwExtraInfo;
    }

    [HARDWAREINPUT]
    public struct HardwareInput
    {
        [DWORD] public uint uMsg;
        [WORD] public ushort wParamL;
        [WORD] public ushort wParamH;
    }
}
