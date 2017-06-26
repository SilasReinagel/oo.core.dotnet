using OO.Core.Types;

namespace OO.Core.Verbal
{
    public sealed class FormattedText : Text
    {
        private readonly Text _body;
        private readonly Text[] _texts;

        public FormattedText(Text body, params Text[] texts)
        {
            _body = body;
            _texts = texts;
        }

        public override string Get()
        {
            return string.Format(_body.ToString(), _texts);
        }
    }
}
