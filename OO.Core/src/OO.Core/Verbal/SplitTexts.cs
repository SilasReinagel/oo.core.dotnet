using System;
using OO.Core.Types;

namespace OO.Core.Verbal
{
    public sealed class SplitTexts : Value<Texts>
    {
        private readonly Text _text;
        private readonly Text _splitBy;

        public SplitTexts(Text text, Text splitBy)
        {
            _text = text;
            _splitBy = splitBy;
        }

        public override Texts Get()
        {
            return new Texts(_text.Get().Split(new string[] { _splitBy.Get() }, StringSplitOptions.None));
        }
    }
}
