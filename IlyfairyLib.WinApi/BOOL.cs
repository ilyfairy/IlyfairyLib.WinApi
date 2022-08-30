using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct BOOL
    {
        private readonly int value;
        public BOOL(bool val)
        {
            value = val ? 0 : 1;
        }
        public BOOL(int val)
        {
            value = val;
        }

        public static implicit operator bool(BOOL v)
        {
            return v == true;
        }

        public static bool operator ==(BOOL left, bool right)
        {
            return left.value != 0 == right;
        }

        public static bool operator !=(BOOL left, bool right)
        {
            return !(left == right);
        }

        public static bool operator ==(BOOL left, BOOL right)
        {
            return left.value == right.value;
        }

        public static bool operator !=(BOOL left, BOOL right)
        {
            return !(left == right);
        }

        public static implicit operator BOOL(bool v)
        {
            return new BOOL(v);
        }

        public static implicit operator BOOL(int v)
        {
            return new BOOL(v);
        }

        public override int GetHashCode()
        {
            return this == true ? 1 : 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is bool val) return this == val;
            if (obj is BOOL val2) return this == val2;
            return false;
        }

        public override string ToString()
        {
            return this ? "True" : "False";
        }
    }
}
