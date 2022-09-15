using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.Kernel32
{
    public static class Kernel32Methods
    {
        [DllImport("kernel32.dll", EntryPoint = "GetQueuedCompletionStatus", ExactSpelling = true)]
        static extern unsafe int GetQueuedCompletionStatus(nint CompletionPort, uint* lpNumberOfBytesTransferred, nuint* CompletionKey, nint* lpOverlapped, int dwMilliseconds);
    }
}
