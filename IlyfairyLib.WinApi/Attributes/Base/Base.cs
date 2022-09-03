using System;
using System.ComponentModel;

namespace IlyfairyLib.WinApi.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false, AllowMultiple = true)]
    public class WinApiBaseAttribute : Attribute
    {
    }
}
