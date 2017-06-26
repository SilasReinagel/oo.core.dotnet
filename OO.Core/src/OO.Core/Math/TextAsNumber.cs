using OO.Core.Types;

namespace OO.Core.Math
{
    public class TextAsNumber : Number
    {
        private readonly Text _text;

        public TextAsNumber(Text text)
        {
            _text = text;
        }

        public override decimal AsDecimal()
        {
            return Parse(_text);
        }
    }
}
