using OO.Core.Logic;

namespace OO.Core.Types
{
    public abstract class Condition
    {
        public abstract bool Evaluate();

        public static implicit operator Condition(bool evaluatedCondition)
        {
            return new BooleanCondition(evaluatedCondition);
        }
    }
}
