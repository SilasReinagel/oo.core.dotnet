using OO.Core.Types;
using OO.Core.Group;

namespace OO.Core.Math
{
    public class TextsAsNumbers : Group<Number>
    {
        public TextsAsNumbers(Texts texts)
            : base(texts.Map<Number>(x => new TextAsNumber(x))) { }
    }
}
