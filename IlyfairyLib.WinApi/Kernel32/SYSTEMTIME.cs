using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.Kernel32
{
    [StructLayout(LayoutKind.Sequential)]
    [SYSTEMTIME]
    public struct SYSTEMTIME
    {
        [WORD] public uint wYear;
        [WORD] public uint wMonth;
        [WORD] public uint wDayOfWeek;
        [WORD] public uint wDay;
        [WORD] public uint wHour;
        [WORD] public uint wMinute;
        [WORD] public uint wSecond;
        [WORD] public uint wMilliseconds;
    }
}