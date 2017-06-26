using OO.Core.Types;

namespace OO.Core.Verbal
{
    public sealed class JoinedText : Text
    {
        private readonly Texts _texts;
        private readonly Text _separator;

        public JoinedText(Texts texts, Text separator)
        {
            _texts = texts;
            _separator = separator;
        }

        public override string Get()
        {
            return string.Join(_separator, _texts.Map<string>(x => x.Get()));
        }
    }
}
