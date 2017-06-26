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

        public override decimal AsDecimal()
        {
            return _value;
        }
    }
}
