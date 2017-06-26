using OO.Core.Math;
using OO.Core.Types;

namespace OO.Core.Console
{
    public sealed class ConsoleNumber : Number
    {
        private readonly Text _text;

        public ConsoleNumber()
        {
            _text = new ConsoleText();
        }

        public override decimal AsDecimal()
        {
            return new TextAsNumber(_text);
        }
    }
}
