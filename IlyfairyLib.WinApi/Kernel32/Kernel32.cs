using System;
using System.Runtime.InteropServices;
using System.Text;
using IlyfairyLib.WinApi.Attributes;
using IlyfairyLib.WinApi.WinNT;

namespace IlyfairyLib.WinApi.Kernel32
{
    public static class KernelMethods32
    {
        #region AccessCheck
        [DllImport("user32.dll")]
        [return: BOOL]
        public static extern BOOL AccessCheck([PSECURITY_DESCRIPTOR, _In_] in SECURITY_DESCRIPTOR pSecurityDescriptor, [HANDLE, _In_] IntPtr ClientToken, [DWORD, _In_] uint DesiredAccess, [PGENERIC_MAPPING, _In_] in GENERIC_MAPPING GenericMapping, [PPRIVILEGE_SET, _Out_writes_bytes_to_opt_] PRIVILEGE_SET[] PrivilegeSet, [LPDWORD, _Inout_] ref uint PrivilegeSetLength, [LPDWORD, _Out_] out uint GrantedAccess, [LPBOOL, _Out_] out BOOL AccessStatus);
        #endregion

    }
}
