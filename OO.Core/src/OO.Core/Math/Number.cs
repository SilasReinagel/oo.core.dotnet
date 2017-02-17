using OO.Core.Math;

namespace OO.Core.Types
{
    public abstract class Number
    {
        protected abstract decimal AsReal();

        public sealed override string ToString()
        {
            return AsReal().ToString();
        }

        public sealed override bool Equals(object other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return other is Number ? Equals((Number) other) : false;
        }

        public sealed override int GetHashCode()
        {
            return AsReal().GetHashCode();
        }

        public bool Equals(int other)
        {
            return ((int) AsReal()) == other;
        }

        private bool Equals(Number other)
        {
            return AsReal() == other.AsReal();
        }

        public static bool operator ==(Number first, Number second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(Number first, Number second)
        {
            return !Equals(first, second);
        }

        public static implicit operator short(Number number)
        {
            return (short) number.AsReal();
        }

        public static implicit operator ushort(Number number)
        {
            return (ushort) number.AsReal();
        }

        public static implicit operator int(Number number)
        {
            return (int) number.AsReal();
        }

        public static implicit operator uint(Number number)
        {
            return (uint) number.AsReal();
        }

        public static implicit operator long(Number number)
        {
            return (long) number.AsReal();
        }

        public static implicit operator ulong(Number number)
        {
            return (ulong) number.AsReal();
        }

        public static implicit operator float(Number number)
        {
            return (float) number.AsReal();
        }

        public static implicit operator double(Number number)
        {
            return (double) number.AsReal();
        }

        public static implicit operator decimal(Number number)
        {
            return number.AsReal();
        }

        public static implicit operator Number(short number)
        {
            return new DecimalNumber(number);
        }

        public static implicit operator Number(ushort number)
        {
            return new DecimalNumber(number);
        }

        public static implicit operator Number(int number)
        {
            return new DecimalNumber(number);
        }

        public static implicit operator Number(uint number)
        {
            return new DecimalNumber(number);
        }

        public static implicit operator Number(long number)
        {
            return new DecimalNumber(number);
        }

        public static implicit operator Number(ulong number)
        {
            return new DecimalNumber(number);
        }

        public static implicit operator Number(float number)
        {
            return new DecimalNumber((decimal)number);
        }

        public static implicit operator Number(double number)
        {
            return new DecimalNumber((decimal)number);
        }

        public static implicit operator Number(decimal number)
        {
            return new DecimalNumber(number);
        }
    }
}
