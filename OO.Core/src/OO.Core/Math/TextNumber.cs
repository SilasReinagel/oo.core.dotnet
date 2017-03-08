using OO.Core.Types;

namespace OO.Core.Math
{
    public class TextNumber : Number
    {
        private readonly Text _text;

        public TextNumber(Text text)
        {
            _text = text;
        }

        protected override decimal AsReal()
        {
            return decimal.Parse(_text.Get());
        }
    }
}
