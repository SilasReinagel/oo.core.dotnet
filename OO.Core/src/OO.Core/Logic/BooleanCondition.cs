using OO.Core.Types;

namespace OO.Core.Logic
{
    public sealed class BooleanCondition : Condition
    {
        private readonly bool _evaluatedCondition;

        public BooleanCondition(bool evaluatedCondition)
        {
            _evaluatedCondition = evaluatedCondition;
        }

        public override bool Evaluate()
        {
            return _evaluatedCondition;
        }
    }
}
