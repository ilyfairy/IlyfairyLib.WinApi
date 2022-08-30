using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [AR_STATE]
    public enum ArState
    {
        AR_ENABLED = 0x0,
        AR_DISABLED = 0x1,
        AR_SUPPRESSED = 0x2,
        AR_REMOTESESSION = 0x4,
        AR_MULTIMON = 0x8,
        AR_NOSENSOR = 0x10,
        AR_NOT_SUPPORTED = 0x20,
        AR_DOCKED = 0x40,
        AR_LAPTOP = 0x80
    }
    

}
