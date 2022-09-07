using System;
using System.Runtime.InteropServices;
using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.KernelBase
{
    [StructLayout(LayoutKind.Sequential)]
    [PROCESS_INFORMATION]
    public struct PROCESS_INFORMATION
    {
        [HANDLE] public IntPtr hProcess;
        [HANDLE] public IntPtr hThread;
        [DWORD] public uint dwProcessId;
        [DWORD] public uint dwThreadId;
    }

}