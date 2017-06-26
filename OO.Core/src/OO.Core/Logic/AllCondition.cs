using OO.Core.Types;
using System.Collections.Generic;
using System.Linq;

namespace OO.Core.Logic
{
    public sealed class AllCondition : Condition
    {
        private readonly IEnumerable<Condition> _conditions;

        public AllCondition(params Condition[] conditions)
        {
            _conditions = conditions;
        }

        public override bool Evaluate()
        {
            return _conditions.All(x => x.Evaluate());
        }
    }
}
