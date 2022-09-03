using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.WinNT;

namespace IlyfairyLib.WinApi.Kernel32
{
    public static class Kernel32Methods
    {
        #region AccessCheck
        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL AccessCheck([PSECURITY_DESCRIPTOR, _In_] in SECURITY_DESCRIPTOR pSecurityDescriptor, [HANDLE, _In_] IntPtr ClientToken, [DWORD, _In_] uint DesiredAccess, [PGENERIC_MAPPING, _In_] in GENERIC_MAPPING GenericMapping, [PPRIVILEGE_SET, _Out_writes_bytes_to_opt_] PRIVILEGE_SET[] PrivilegeSet, [LPDWORD, _Inout_] ref uint PrivilegeSetLength, [LPDWORD, _Out_] out uint GrantedAccess, [LPBOOL, _Out_] out BOOL AccessStatus);
        #endregion

        #region AccessCheckAndAuditAlarmW
        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL AccessCheckAndAuditAlarmW([LPCWSTR, _In_] string SubsystemName, [LPVOID, _In_opt_] IntPtr HandleId, [LPWSTR, _In_] string ObjectTypeName, [LPWSTR, _In_opt_] string ObjectName, [PSECURITY_DESCRIPTOR, _In_] in SECURITY_DESCRIPTOR SecurityDescriptor, [DWORD, _In_] uint DesiredAccess, [PGENERIC_MAPPING, _In_] GENERIC_MAPPING GenericMapping, [BOOL, _In_] BOOL ObjectCreation, [LPDWORD, _Out_] out uint GrantedAccess, [LPBOOL, _Out_] out BOOL AccessStatus, [LPBOOL, _Out_] out BOOL pfGenerateOnClose);
        #endregion

        #region AccessCheckByType
        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL AccessCheckByType([PSECURITY_DESCRIPTOR, _In_] in SECURITY_DESCRIPTOR pSecurityDescriptor, [PSID, _In_opt_] IntPtr PrincipalSelfSid, [HANDLE, _In_] IntPtr ClientToken, [DWORD, _In_] uint DesiredAccess, [POBJECT_TYPE_LIST, _Inout_updates_opt_] OBJECT_TYPE_LIST[] ObjectTypeList, [DWORD, _In_] uint ObjectTypeListLength, [PGENERIC_MAPPING, _In_] in GENERIC_MAPPING GenericMapping, [PPRIVILEGE_SET, _Out_writes_bytes_to_opt_] PRIVILEGE_SET[] PrivilegeSet, [LPDWORD, _Inout_] ref uint PrivilegeSetLength, [LPDWORD, _Out_] out uint GrantedAccess, [LPBOOL, _Out_] out BOOL AccessStatus);
        #endregion

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL AccessCheckByTypeAndAuditAlarmW([LPCWSTR, _In_] string SubsystemName, [LPVOID, _In_] IntPtr HandleId, [LPCWSTR, _In_] string ObjectTypeName, [LPCWSTR, _In_opt_] string ObjectName, [PSECURITY_DESCRIPTOR, _In_] in SECURITY_DESCRIPTOR SecurityDescriptor, [PSID, _In_opt_] IntPtr PrincipalSelfSid, [DWORD, _In_] uint DesiredAccess, [AUDIT_EVENT_TYPE, _In_] AUDIT_EVENT_TYPE AuditType, [DWORD, _In_] uint Flags, [POBJECT_TYPE_LIST, _Inout_updates_opt_] OBJECT_TYPE_LIST[] ObjectTypeList, [DWORD, _In_] uint ObjectTypeListLength, [PGENERIC_MAPPING, _In_] in GENERIC_MAPPING GenericMapping, [BOOL, _In_] BOOL ObjectCreation, [LPDWORD, _Out_] out uint GrantedAccess, [LPBOOL, _Out_] out BOOL AccessStatus, [LPBOOL, _Out_] out BOOL pfGenerateOnClose);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL Beep([DWORD, _In_] uint dwFreq, [DWORD, _In_] uint dwDuration);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL AllocConsole();

        #region CancelIo
        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL CancelIo([HANDLE, _In_] IntPtr hFile);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL CancelIoEx([HANDLE, _In_] IntPtr hFile, [LPOVERLAPPED, _In_opt_] IntPtr lpOverlapped);
        #endregion

        [DllImport("kernel32.dll")]

        [return: HANDLE]
        public static extern IntPtr CreateThread([LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpThreadAttributes, [SIZE_T, _In_] UIntPtr dwStackSize, [LPTHREAD_START_ROUTINE, _In_] PThreadStartRouting lpStartAddress, [LPVOID, __drv_aliasesMem, _In_opt_] IntPtr lpParameter, [DWORD, _In_] uint dwCreationFlags, [LPDWORD, _Out_opt_] out uint lpThreadId);

        [DllImport("kernel32.dll")]
        [return: VOID]
        public static extern void DebugBreak();

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL DeviceIoControl([HANDLE, _In_] IntPtr hDevice, [DWORD, _In_] uint dwIoControlCode, [LPVOID, _In_reads_bytes_opt_] byte[] lpInBuffer, [DWORD, _In_] uint nInBufferSize, [LPVOID, _Out_writes_bytes_to_opt_] byte[] lpOutBuffer, [DWORD, _In_] uint nOutBufferSize, [LPDWORD, _Out_opt_] out uint lpBytesReturned, [LPOVERLAPPED, _Inout_opt_] ref OVERLAPPED lpOverlapped);

        #region CreateFile
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: HANDLE]
        public static extern IntPtr CreateFileA([LPCSTR, _In_] byte[] lpFileName, [DWORD, _In_] FileAccess dwDesiredAccess, [DWORD, _In_] FileShare dwShareMode, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpSecurityAttributes, [DWORD, _In_] FileMode dwCreationDisposition, [DWORD, _In_] FileAttributes dwFlagsAndAttributes, [HANDLE, _In_opt_] IntPtr hTemplateFile);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: HANDLE]
        public static extern IntPtr CreateFileA([LPCSTR, _In_] byte[] lpFileName, [DWORD, _In_] FileAccess dwDesiredAccess, [DWORD, _In_] FileShare dwShareMode, [LPSECURITY_ATTRIBUTES, _In_opt_] IntPtr lpSecurityAttributes, [DWORD, _In_] FileMode dwCreationDisposition, [DWORD, _In_] FileAttributes dwFlagsAndAttributes, [HANDLE, _In_opt_] IntPtr hTemplateFile);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: HANDLE]
        public static extern IntPtr CreateFileW([LPCWSTR, _In_] string lpFileName, [DWORD, _In_] FileAccess dwDesiredAccess, [DWORD, _In_] FileShare dwShareMode, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpSecurityAttributes, [DWORD, _In_] FileMode dwCreationDisposition, [DWORD, _In_] FileAttributes dwFlagsAndAttributes, [HANDLE, _In_opt_] IntPtr hTemplateFile);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: HANDLE]
        public static extern IntPtr CreateFileW([LPCWSTR, _In_] string lpFileName, [DWORD, _In_] FileAccess dwDesiredAccess, [DWORD, _In_] FileShare dwShareMode, [LPSECURITY_ATTRIBUTES, _In_opt_] IntPtr lpSecurityAttributes, [DWORD, _In_] FileMode dwCreationDisposition, [DWORD, _In_] FileAttributes dwFlagsAndAttributes, [HANDLE, _In_opt_] IntPtr hTemplateFile);
        #endregion

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint GetLastError();

        #region GetNLSVersion
        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL GetNLSVersion([NLS_FUNCTION, _In_] uint Function, [LCID, _In_] uint Locale, [LPNLSVERSIONINFO, _Inout_] ref NLSVERSIONINFO lpVersionInformation);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL GetNLSVersionEx([NLS_FUNCTION, _In_] uint function, [LPCWSTR, _In_opt_] string lpLocaleName, [LPNLSVERSIONINFOEX, _Inout_] ref NLSVERSIONINFOEX lpVersionInformation);
        #endregion

        [DllImport("kernel32.dll")]
        [return: VOID]
        public static extern void GetSystemTime([LPSYSTEMTIME, _Out_] out SYSTEMTIME lpSystemTime);

        #region GetTempPath
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: DWORD]
        public static extern uint GetTempPathA([DWORD, _In_] uint nBufferLength, [LPSTR, _Out_writes_to_opt_] byte[] lpBuffer);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: DWORD]
        public static extern uint GetTempPathW([DWORD, _In_] uint nBufferLength, [LPWSTR, _Out_writes_to_opt_] StringBuilder lpBuffer);
        #endregion

        #region LockFile
        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL LockFile([HANDLE, _In_] IntPtr hFile, [DWORD, _In_] uint dwFileOffsetLow, [DWORD, _In_] uint dwFileOffsetHigh, [DWORD, _In_] uint nNumberOfBytesToLockLow, [DWORD, _In_] uint nNumberOfBytesToLockHigh);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL LockFileEx([HANDLE, _In_] IntPtr hFile, [DWORD, _In_] uint dwFlags, [DWORD, _Reserved_] uint dwReserved, [DWORD, _In_] uint nNumberOfBytesToLockLow, [DWORD, _In_] uint nNumberOfBytesToLockHigh, [LPOVERLAPPED, _Inout_] ref OVERLAPPED lpOverlapped);
        #endregion

        [DllImport("kernel32.dll")]
        [return: LPVOID]
        public static extern unsafe void* HeapAlloc([HANDLE, _In_] IntPtr hHeap, [DWORD, _In_] uint dwFlags, [SIZE_T, _In_] UIntPtr dwBytes);

        [DllImport("kernel32.dll")]
        [return: HANDLE]
        public static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint GetCurrentProcessId();

        [DllImport("kernel32.dll")]
        [return: VOID]
        public static extern void ExitProcess([UINT, _In_] uint uExitCode);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL TerminateProcess([HANDLE, _In_] IntPtr hProcess, [UINT, _In_] uint uExitCode);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL GetExitCodeProcess([HANDLE, _In_] IntPtr hProcess, [LPDWORD, _Out_] out uint lpExitCode);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL SwitchToThread();

        [DllImport("kernel32.dll")]
        [return: HANDLE]
        public static extern IntPtr GetCurrentThread();

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint GetCurrentThreadId();

        [DllImport("kernel32.dll")]
        [return: HANDLE]
        public static extern BOOL OpenThread([DWORD, _In_] uint dwDesiredAccess, [BOOL, _In_] BOOL bInheritHandle, [DWORD, _In_] uint dwThreadId);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL SetThreadPriority([HANDLE, _In_] IntPtr hThread, [_In_] int nPriority);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL SetThreadPriorityBoost([HANDLE, _In_] IntPtr hThread, [BOOL, _In_] BOOL bDisablePriorityBoost);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL GetThreadPriorityBoost([HANDLE, _In_] IntPtr hThread, [PBOOL, _Out_] out BOOL pDisablePriorityBoost);

        [DllImport("kernel32.dll")]
        public static extern int GetThreadPriority([HANDLE, _In_] IntPtr hThread);

        [DllImport("kernel32.dll")]
        public static extern void ExitThread([DWORD, _In_] uint dwExitCode);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL TerminateThread([HANDLE, _In_] IntPtr hThread, [DWORD, _In_] uint dwExitCode);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL GetExitCodeThread([HANDLE, _In_] IntPtr hThread, [LPDWORD, _Out_] out uint lpExitCode);

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint SuspendThread([HANDLE, _In_] IntPtr hThread);

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint ResumeThread([HANDLE, _In_] IntPtr hThread);

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint TlsAlloc();

        [DllImport("kernel32.dll")]
        [return: LPVOID]
        public static extern unsafe IntPtr TlsGetValue([DWORD, _In_] uint dwTlsIndex);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL TlsSetValue([DWORD, _In_] uint dwTlsIndex, [LPVOID, _In_opt_] IntPtr lpTlsValue);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL TlsFree([DWORD, _In_] uint dwTlsIndex);

        #region CreateProcess
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL CreateProcessA([LPCSTR, _In_opt_] byte[] lpApplicationName, [LPSTR, _Inout_opt_] byte[] lpCommandLine, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpProcessAttributes, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpThreadAttributes, [BOOL, _In_] BOOL bInheritHandles, [DWORD, _In_] uint dwCreationFlags, [LPVOID, _In_opt_] IntPtr lpEnvironment, [LPCSTR, _In_opt_] byte[] lpCurrentDirectory, [LPSTARTUPINFOA, _In_] in STARTUPINFOA lpStartupInfo, [LPPROCESS_INFORMATION, _Out_] out PROCESS_INFORMATION lpProcessInformation);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CreateProcessW([LPCSTR, _In_opt_] string lpApplicationName, [LPSTR, _Inout_opt_] char[] lpCommandLine, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpProcessAttributes, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpThreadAttributes, [BOOL, _In_] BOOL bInheritHandles, [DWORD, _In_] uint dwCreationFlags, [LPVOID, _In_opt_] IntPtr lpEnvironment, [LPCSTR, _In_opt_] string lpCurrentDirectory, [LPSTARTUPINFOW, _In_] in STARTUPINFOW lpStartupInfo, [LPPROCESS_INFORMATION, _Out_] out PROCESS_INFORMATION lpProcessInformation);
        #endregion

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL SetProcessShutdownParameters([DWORD, _In_] uint dwLevel, [DWORD, _In_] uint dwFlags);

        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint GetProcessVersion([DWORD, _In_] uint ProcessId);

        #region GetStartupInfoW
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: VOID]
        public static extern void GetStartupInfoW([LPSTARTUPINFOW, _Out_] out STARTUPINFOW lpStartupInfo);
        #endregion

        #region CreateProcessAsUser
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL CreateProcessAsUserA([HANDLE, _In_opt_] IntPtr hToken, [LPCSTR, _In_opt_] byte[] lpApplicationName, [LPSTR, _Inout_opt_] byte[] lpCommandLine, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpProcessAttributes, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpThreadAttributes, [BOOL, _In_] BOOL bInheritHandles, [DWORD, _In_] uint dwCreationFlags, [LPVOID, _In_opt_] IntPtr lpEnvironment, [LPCSTR, _In_opt_] byte[] lpCurrentDirectory, [LPSTARTUPINFOA, _In_] STARTUPINFOA lpStartupInfo, [LPPROCESS_INFORMATION, _Out_] out PROCESS_INFORMATION lpProcessInformation);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL CreateProcessAsUserW([HANDLE, _In_opt_] IntPtr hToken, [LPCWSTR, _In_opt_] string lpApplicationName, [LPWSTR, _Inout_opt_] char[] lpCommandLine, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpProcessAttributes, [LPSECURITY_ATTRIBUTES, _In_opt_] in SECURITY_ATTRIBUTES lpThreadAttributes, [BOOL, _In_] BOOL bInheritHandles, [DWORD, _In_] uint dwCreationFlags, [LPVOID, _In_opt_] IntPtr lpEnvironment, [LPCWSTR, _In_opt_] string lpCurrentDirectory, [LPSTARTUPINFOW, _In_] STARTUPINFOW lpStartupInfo, [LPPROCESS_INFORMATION, _Out_] out PROCESS_INFORMATION lpProcessInformation);
        #endregion

        #region QueueUserAPC
        [DllImport("kernel32.dll")]
        [return: DWORD]
        public static extern uint QueueUserAPC([PAPCFUNC, _In_] PAPCFunc pfnAPC, [HANDLE, _In_] IntPtr hThread, [ULONG_PTR, _In_] UIntPtr dwData);
        #endregion

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL GetProcessTimes([HANDLE, _In_] IntPtr hProcess, [LPFILETIME, _Out_] out FILETIME lpCreationTime, [LPFILETIME, _Out_] out FILETIME lpExitTime, [LPFILETIME, _Out_] out FILETIME lpKernelTime, [LPFILETIME, _Out_] out FILETIME lpUserTime);

        #region GetProcAddress
#if NET5_0_OR_GREATER
        [DllImport("kernel32.dll")]
        [return: FARPROC]
        public static extern unsafe delegate* unmanaged<void> GetProcAddress([HMODULE, _In_] IntPtr hModule, [LPCSTR, _In_] byte[] lpProcName);

        [DllImport("kernel32.dll",CharSet = CharSet.Ansi)]
        [return: FARPROC]
        public static extern unsafe delegate* unmanaged<void> GetProcAddress([HMODULE, _In_] IntPtr hModule, [LPCSTR, _In_] string lpProcName);
#else
        [DllImport("kernel32.dll")]
        [return: FARPROC]
        public static extern IntPtr GetProcAddress([HMODULE, _In_] IntPtr hModule, [LPCSTR, _In_] byte[] lpProcName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: FARPROC]
        public static extern IntPtr GetProcAddress([HMODULE, _In_] IntPtr hModule, [LPCSTR, _In_] string lpProcName);
#endif
        #endregion

        #region GetModuleHandle
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: HMODULE]
        public static extern IntPtr GetModuleHandleA([LPCSTR, _In_opt_] byte[] lpModuleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: HMODULE]
        public static extern IntPtr GetModuleHandleW([LPCWSTR, _In_opt_] string lpModuleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL GetModuleHandleExA([DWORD, _In_] uint dwFlags, [LPCSTR, _In_opt_] byte[] lpModuleName, [HMODULE, Ptr, _Out_] out IntPtr phModule);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL GetModuleHandleExW([DWORD, _In_] uint dwFlags, [LPCWSTR, _In_opt_] string lpModuleName, [HMODULE, Ptr, _Out_] out IntPtr phModule);
        #endregion

        #region LoadLibrary
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: HMODULE]
        public static extern IntPtr LoadLibraryA([LPCSTR, _In_] byte[] lpLibFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: HMODULE]
        public static extern IntPtr LoadLibraryW([LPCWSTR, _In_] string lpLibFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: HMODULE]
        public static extern IntPtr LoadLibraryExA([LPCSTR, _In_] byte[] lpLibFileName, [HANDLE, _Reserved_] IntPtr hFile, [DWORD, _In_] uint dwFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: HMODULE]
        public static extern IntPtr LoadLibraryExW([LPCWSTR, _In_] string lpLibFileName, [HANDLE, _Reserved_] IntPtr hFile, [DWORD, _In_] uint dwFlags);
        #endregion

        [DllImport("kernel32.dll")]
        [return: HGLOBAL]
        public static extern IntPtr LoadResource([HMODULE, _In_opt_] IntPtr hModule, [HRSRC, _In_] IntPtr hResInfo);

        #region LoadString
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern int LoadStringA([HINSTANCE, _In_opt_] IntPtr hInstance, [UINT, _In_] uint uID, [LPSTR, _Out_writes_to_] byte[] lpBuffer, [_In_] int cchBufferMax);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern int LoadStringW([HINSTANCE, _In_opt_] IntPtr hInstance, [UINT, _In_] uint uID, [LPSTR, _Out_writes_to_] StringBuilder lpBuffer, [_In_] int cchBufferMax);
        #endregion

        [DllImport("kernel32.dll")]
        [return: HANDLE]
        public static extern BOOL OpenProcess([DWORD, _In_] ProcessAccess dwDesiredAccess, [BOOL, _In_] BOOL bInheritHandle, [DWORD, _In_] uint dwProcessId);

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL AttachConsole([DWORD, _In_] uint dwProcessId);

        #region DeleteFile
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        [return: BOOL]
        public static extern BOOL DeleteFileA([LPCSTR, _In_] byte[] lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: BOOL]
        public static extern BOOL DeleteFileW([LPCWSTR, _In_] string lpFileName);
        #endregion

        [DllImport("kernel32.dll")]
        [return: BOOL]
        public static extern BOOL SetSystemTime([SYSTEMTIME, Ptr, _In_, CONST] in SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        [return: VOID]
        public static extern void Sleep([DWORD, _In_] uint dwMilliseconds);

        [DllImport("kernel32.dll")]
        [return: VOID]
        public static extern void WakeByAddressSingle([DWORD, _In_] IntPtr Address);


    }










    [PTHREAD_START_ROUTINE]
    [return: DWORD]
    public delegate uint PThreadStartRouting([LPVOID] IntPtr lpThreadParameter);

    [PAPCFUNC]
    [return: VOID]
    public delegate void PAPCFunc([ULONG_PTR, _In_] UIntPtr Parameter);

    public delegate void FARPROC();
}