using OO.Core.Math;

namespace OO.Core.Types
{
    public abstract class Number
    {
        public abstract decimal AsDecimal();

        public sealed override string ToString()
        {
            return AsDecimal().ToString();
        }

        public sealed override bool Equals(object other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return other is Number ? Equals((Number) other) : false;
        }

        public static Number Parse(Text text)
        {
            return new DecimalNumber(decimal.Parse(text.ToString()));
        }

        public sealed override int GetHashCode()
        {
            return AsDecimal().GetHashCode();
        }

        public bool Equals(int other)
        {
            return ((int) AsDecimal()) == other;
        }

        private bool Equals(Number other)
        {
            return AsDecimal() == other.AsDecimal();
        }

        public static bool operator ==(Number first, Number second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(Number first, Number second)
        {
            return !Equals(first, second);
        }

        public static Number operator +(Number first, Number second)
        {
            return first.AsDecimal() +  second.AsDecimal();
        }

        public static implicit operator short(Number number)
        {
            return (short) number.AsDecimal();
        }

        public static implicit operator ushort(Number number)
        {
            return (ushort) number.AsDecimal();
        }

        public static implicit operator int(Number number)
        {
            return (int) number.AsDecimal();
        }

        public static implicit operator uint(Number number)
        {
            return (uint) number.AsDecimal();
        }

        public static implicit operator long(Number number)
        {
            return (long) number.AsDecimal();
        }

        public static implicit operator ulong(Number number)
        {
            return (ulong) number.AsDecimal();
        }

        public static implicit operator float(Number number)
        {
            return (float) number.AsDecimal();
        }

        public static implicit operator double(Number number)
        {
            return (double) number.AsDecimal();
        }

        public static implicit operator decimal(Number number)
        {
            return number.AsDecimal();
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
