using IlyfairyLib.WinApi.Attributes;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    [SECURITY_QUALITY_OF_SERVICE]
    public struct SECURITY_QUALITY_OF_SERVICE
    {
        [DWORD] uint Length;
        [SECURITY_IMPERSONATION_LEVEL] SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;
        [SECURITY_CONTEXT_TRACKING_MODE] BOOLEAN ContextTrackingMode;
        [BOOLEAN] BOOLEAN EffectiveOnly;
    }
}
