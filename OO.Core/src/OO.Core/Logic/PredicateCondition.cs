using OO.Core.Types;
using System;

namespace OO.Core.Logic
{
    public sealed class PredicateCondition<T> : Condition<T>
    {
        private readonly Predicate<T> _predicate;

        public PredicateCondition(Predicate<T> predicate)
        {
            _predicate = predicate;
        }

        public override bool Evaluate(T input)
        {
            return _predicate.Invoke(input);
        }
    }
}
