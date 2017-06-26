using OO.Core.Types;

namespace OO.Core.Verbal
{
    public sealed class Conditional<T> : Value<T>
    {
        private readonly Condition _condition;
        private readonly T _ifTrue;
        private readonly T _ifFalse;

        public Conditional(Condition condition, T ifTrue, T ifFalse)
        {
            _condition = condition;
            _ifTrue = ifTrue;
            _ifFalse = ifFalse;
        }

        public override T Get()
        {
            return _condition ? _ifTrue : _ifFalse;
        }
    }
}
