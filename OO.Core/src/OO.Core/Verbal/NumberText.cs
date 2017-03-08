using OO.Core.Types;

namespace OO.Core.Verbal
{
    public class NumberText : Text
    {
        private readonly Number _number;

        public NumberText(Number number)
        {
            _number = number;
        }

        public override string Get()
        {
            return _number.ToString();
        }
    }
}
