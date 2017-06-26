using OO.Core.Types;
using System;

namespace OO.Core.Storage
{
    public sealed class Store<T> : Value<T>, Mutable<T>
    {
        private T _value;

        public override T Get()
        { 
            // TODO: Turn this into a one-liner
            if (IsEmpty())
                throw new InvalidOperationException("Store contains no value.");
            return _value;
        }

        public void Put(T value)
        {
            _value = value;
        }

        public Condition IsEmpty()
        {
            return _value == null;
        }
    }
}
