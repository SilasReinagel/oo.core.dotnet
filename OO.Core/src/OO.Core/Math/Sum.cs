using OO.Core.Types;

namespace OO.Core.Math
{
    public sealed class Sum : Number
    {
        private readonly Numbers _numbers;

        public Sum(params Number[] numbers)
            : this (new Numbers(numbers)) { }

        public Sum(Numbers numbers)
        {
            _numbers = numbers;
        }

        public override decimal AsDecimal()
        {
            return _numbers.Sum();
        }
    }
}
