using OO.Core.Types;

namespace OO.Core.Verbal
{
    public sealed class NumberAsText : Text
    {
        private readonly Number _number;

        public NumberAsText(Number number)
        {
            _number = number;
        }

        public override string Get()
        {
            return _number.ToString();
        }
    }
}
