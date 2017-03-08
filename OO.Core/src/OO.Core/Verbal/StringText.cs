
namespace OO.Core.Verbal
{
    internal sealed class StringText : Types.Text
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
