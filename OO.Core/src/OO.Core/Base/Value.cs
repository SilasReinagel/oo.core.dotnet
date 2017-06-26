using System;
using OO.Core.Base;

namespace OO.Core.Types
{
    public abstract class Value<T>
    {
        public abstract T Get();

        public static implicit operator Value<T>(Func<T> function)
        {
            return new FunctionValue<T>(function);
        }

        public static implicit operator T(Value<T> value)
        {
            return value.Get();
        }
    }
}
