using OO.Core.Logic;
using System;

namespace OO.Core.Types
{
    public abstract class Condition
    {
        public abstract bool Evaluate();

        public static implicit operator Condition(bool evaluatedCondition)
        {
            return new BooleanCondition(evaluatedCondition);
        }

        public static implicit operator bool(Condition condition)
        {
            return condition.Evaluate();
        }

        public static bool operator true(Condition condition)
        {
            return condition.Evaluate();
        }

        public static bool operator false(Condition condition)
        {
            return !condition.Evaluate();
        }

        public static Condition operator |(Condition condition1, Condition condition2)
        {
            return new AnyCondition(condition1, condition2);
        }
    }

    public abstract class Condition<T>
    {
        public abstract bool Evaluate(T input);

        public static implicit operator Condition<T>(Predicate<T> predicate)
        {
            return new PredicateCondition<T>(predicate);
        }
    }
}
