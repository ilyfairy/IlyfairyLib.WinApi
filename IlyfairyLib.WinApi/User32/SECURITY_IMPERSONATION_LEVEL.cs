using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
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
