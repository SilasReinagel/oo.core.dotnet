using OO.Core.Types;

namespace OO.Core.Verbal
{
    public sealed class StringText : Text
    {
        private readonly string _value;

        public StringText(string value)
        {
            _value = value;
        }

        public override string Get()
        {
            return _value;
        }
    }
}
