using IlyfairyLib.WinApi.Attributes;

namespace IlyfairyLib.WinApi.User32
{
    [ORIENTATION_PREFERENCE]
    public enum OrientationPreference
    {
        ORIENTATION_PREFERENCE_NONE = 0x0,
        ORIENTATION_PREFERENCE_LANDSCAPE = 0x1,
        ORIENTATION_PREFERENCE_PORTRAIT = 0x2,
        ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 0x4,
        ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 0x8
    }


}
