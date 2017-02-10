
namespace OO.Core.Types
{
    public abstract class Number
    {
        protected abstract long AsInt();
        protected abstract decimal AsReal();

        public sealed override string ToString()
        {
            return AsInt().ToString();
        }

        public sealed override bool Equals(object other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return other is Number ? Equals((Number)other) : false;
        }

        public bool Equals(int other)
        {
            return AsInt() == other;
        }

        private bool Equals(Number other)
        {
            return AsInt() == other.AsInt();
        }

        public static bool operator ==(Number first, Number second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(Number first, Number second)
        {
            return !Equals(first, second);
        }

        public static implicit operator ushort(Number number)
        {
            return (ushort)number.AsInt();
        }

        public static implicit operator int(Number number)
        {
            return (int)number.AsInt();
        }

        public static implicit operator long(Number number)
        {
            return number.AsInt();
        }

        public static implicit operator Number(int number)
        {
            return new SimpleNumber(number);
        }

        public static implicit operator Number(double number)
        {
            return new SimpleNumber(number);
        }
    }

    public sealed class SimpleNumber : Number
    {
        private readonly double _realValue;

        public SimpleNumber(int value) : this((double)value) { }
        public SimpleNumber(uint value) : this((double)value) { }
        public SimpleNumber(short value) : this((double)value) { }
        public SimpleNumber(ushort value) : this((double)value) { }
        public SimpleNumber(long value) : this((double)value) { }
        public SimpleNumber(decimal value) : this((double)value) { }
        public SimpleNumber(float value) : this((double)value) { }

        public SimpleNumber(double realValue)
        {
            _realValue = realValue;
        }

        protected override long AsInt()
        {
            return (long)AsReal();
        }

        protected override double AsReal()
        {
            return _realValue;
        }
    }
}
