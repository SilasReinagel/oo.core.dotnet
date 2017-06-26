using OO.Core.Types;

namespace OO.Core.Math
{
    public class IsInRangeInclusive : Condition
    {
        private Number _number;
        private Number _min;
        private Number _max;

        public IsInRangeInclusive(Number number, Number min, Number max)
        {
            _number = number;
            _min = min;
            _max = max;
        }

        public override bool Evaluate()
        {
            return _number >= _min && _number <= _max;
        }
    }
}
