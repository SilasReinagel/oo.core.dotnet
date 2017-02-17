using System;
using OO.Core.Types;

namespace OO.Core.Base
{
    internal sealed class FunctionValue<T> : Value<T>
    {
        private readonly Func<T> _function;

        public FunctionValue(Func<T> function)
        {
            _function = function;
        }

        public override T Get()
        {
            return _function.Invoke();
        }
    }
}
