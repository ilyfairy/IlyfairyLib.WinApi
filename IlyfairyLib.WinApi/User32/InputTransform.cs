using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Explicit)]
    [INPUT_TRANSFORM]
    public struct InputTransform
    {
        [FieldOffset(0)]
        public P data;
        [FieldOffset(0)]
        public unsafe fixed float m[16];

        public unsafe Span<float> GetElements()
        {
            fixed(void* p = m)
            {
                return new Span<float>(p, 16);
            }
        }

        public struct P
        {
            public float M11, M12, M13, M14;
            public float M21, M22, M23, M24;
            public float M31, M32, M33, M34;
            public float M41, M42, M43, M44;
        }
    }


}
