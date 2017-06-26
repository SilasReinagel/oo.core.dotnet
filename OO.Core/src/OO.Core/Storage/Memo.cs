using OO.Core.Types;

namespace OO.Core.Storage
{
    public sealed class Memo<T> : Value<T>
    {
        private readonly Store<T> _store = new Store<T>();
        private readonly Value<T> _value;
        
        public Memo(Value<T> value)
        {
            _value = value;
        }

        public override T Get()
        {
            // TODO: Turn this into a one-liner
            if (_store.IsEmpty())
                _store.Put(_value.Get());
            return _store.Get();
        }
    }
}
