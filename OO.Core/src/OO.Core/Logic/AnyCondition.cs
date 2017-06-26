using OO.Core.Types;
using System.Collections.Generic;
using System.Linq;

namespace OO.Core.Logic
{
    public sealed class AnyCondition : Condition
    {
        private readonly IEnumerable<Condition> _conditions;

        public AnyCondition(params Condition[] conditions)
        {
            _conditions = conditions;
        }

        public override bool Evaluate()
        {
            return _conditions.Any(x => x.Evaluate());
        }
    }

    public sealed class AnyCondition<T> : Condition<T>
    {
        private readonly IEnumerable<Condition<T>> _conditions;

        public AnyCondition(params Condition<T>[] conditions)
        {
            _conditions = conditions;
        }

        public override bool Evaluate(T input)
        {
            return _conditions.Any(x => x.Evaluate(input));
        }
    }
}
