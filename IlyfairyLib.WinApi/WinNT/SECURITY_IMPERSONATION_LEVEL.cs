using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.WinNT
{
    [SECURITY_IMPERSONATION_LEVEL]
    public enum SECURITY_IMPERSONATION_LEVEL
    {
        SecurityAnonymous,
        SecurityIdentification,
        SecurityImpersonation,
        SecurityDelegation
    }
}
