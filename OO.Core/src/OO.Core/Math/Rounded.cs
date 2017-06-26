using OO.Core.Types;

namespace OO.Core.Math
{
    public sealed class Rounded : Number
    {
        private readonly Number _number;
        private readonly Number _decimalPlaces;

        public Rounded(Number number)
            : this(number, 0) { }

        public Rounded(Number number, Number decimalPlaces)
        {
            _number = number;
            _decimalPlaces = decimalPlaces;
        }

        public override decimal AsDecimal()
        {
            return System.Math.Round((decimal)_number, _decimalPlaces);
        }
    }
}
