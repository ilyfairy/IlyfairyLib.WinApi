using System;
using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.Kernel32
{
    [StructLayout(LayoutKind.Sequential)]
    [STARTUPINFOW]
    public struct STARTUPINFOW
    {
        [DWORD] public uint cb;
        [LPWSTR] public string lpReserved;
        [LPWSTR] public string lpDesktop;
        [LPWSTR] public string lpTitle;
        [DWORD] public uint dwX;
        [DWORD] public uint dwY;
        [DWORD] public uint dwXSize;
        [DWORD] public uint dwYSize;
        [DWORD] public uint dwXCountChars;
        [DWORD] public uint dwYCountChars;
        [DWORD] public uint dwFillAttribute;
        [DWORD] public uint dwFlags;
        [WORD] public ushort wShowWindow;
        [WORD] public ushort cbReserved2;
        [LPBYTE] public byte[] lpReserved2;
        [HANDLE] public IntPtr hStdInput;
        [HANDLE] public IntPtr hStdOutput;
        [HANDLE] public IntPtr hStdError;
    }

}