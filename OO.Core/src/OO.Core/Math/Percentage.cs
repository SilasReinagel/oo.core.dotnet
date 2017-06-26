using OO.Core.Types;

namespace OO.Core.Math
{
    public sealed class Percentage : Number
    {
        private readonly Number _number;

        public Percentage(Number number)
        {
            _number = number;            
        }

        public override decimal AsDecimal()
        {
            return (decimal)_number / 100;
        }

        public Number Of(Number other)
        {
            return other * AsDecimal();
        }
    }
}
