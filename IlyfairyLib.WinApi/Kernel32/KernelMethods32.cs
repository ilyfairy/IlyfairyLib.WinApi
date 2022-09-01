using System;
using System.IO;
using System.Runtime.InteropServices;
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









    }























    [PTHREAD_START_ROUTINE]
    [return: DWORD]
    public delegate uint PThreadStartRouting([LPVOID] IntPtr lpThreadParameter);
}