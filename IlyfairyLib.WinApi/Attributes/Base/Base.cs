using System;

namespace IlyfairyLib.WinApi.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = true)]
    public class WinApiBaseAttribute : Attribute
    {
    }
}
