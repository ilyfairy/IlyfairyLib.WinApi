using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS]
    public enum DialogControlDpiChangeBehaviors
    {
        DCDC_DEFAULT = 0x0000,
        DCDC_DISABLE_FONT_UPDATE = 0x0001,
        DCDC_DISABLE_RELAYOUT = 0x0002,
    }


}
