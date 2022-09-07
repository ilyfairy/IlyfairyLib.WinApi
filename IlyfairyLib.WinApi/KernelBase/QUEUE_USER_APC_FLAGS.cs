using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.KernelBase
{
    [QUEUE_USER_APC_FLAGS]
    public enum QUEUE_USER_APC_FLAGS
    {
        QUEUE_USER_APC_FLAGS_NONE = 0x00000000,
        QUEUE_USER_APC_FLAGS_SPECIAL_USER_APC = 0x00000001,
        QUEUE_USER_APC_CALLBACK_DATA_CONTEXT = 0x00010000,
    }

}