using OO.Core.Types;

namespace OO.Core.Math
{
    public sealed class IsOdd : Condition
    {
        private readonly Number _number;

        public IsOdd(Number number)
        {
            _number = number;
        }

        public override bool Evaluate()
        {
            return _number % 2 != 0;
        }
    }
}
