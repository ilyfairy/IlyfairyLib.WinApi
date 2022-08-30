using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi
{
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct BOOLEAN
    {
        private readonly byte value;
        public BOOLEAN(bool val)
        {
            value = val ? (byte)0 : (byte)1;
        }
        public BOOLEAN(byte val)
        {
            value = val;
        }

        public static implicit operator bool(BOOLEAN v)
        {
            return v == true;
        }

        public static bool operator ==(BOOLEAN left, bool right)
        {
            return left.value != 0 == right;
        }

        public static bool operator !=(BOOLEAN left, bool right)
        {
            return !(left == right);
        }

        public static bool operator ==(BOOLEAN left, BOOLEAN right)
        {
            return left.value == right.value;
        }

        public static bool operator !=(BOOLEAN left, BOOLEAN right)
        {
            return !(left == right);
        }

        public static implicit operator BOOLEAN(bool v)
        {
            return new BOOLEAN(v);
        }

        public static implicit operator BOOLEAN(byte v)
        {
            return new BOOLEAN(v);
        }

        public override int GetHashCode()
        {
            return this == true ? 1 : 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is bool val) return this == val;
            if (obj is BOOLEAN val2) return this == val2;
            return false;
        }

        public override string ToString()
        {
            return this ? "True" : "False";
        }
    }
}
