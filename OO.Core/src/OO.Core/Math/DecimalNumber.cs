using OO.Core.Types;

namespace OO.Core.Math
{
    internal sealed class DecimalNumber : Number
    {
        private readonly decimal _value;

        public DecimalNumber(decimal value)
        {
            _value = value;
        }

        protected override decimal AsReal()
        {
            return _value;
        }
    }
}
