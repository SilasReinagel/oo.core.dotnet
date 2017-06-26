using OO.Core.Types;

namespace OO.Core.Output
{
    public sealed class PrintedText : Work
    {
        private readonly Text _text;
        private readonly Media<Text> _media;

        public PrintedText(Text text, Media<Text> media)
        {
            _text = text;
            _media = media;
        }

        public override void Go()
        {
            _media.Print(_text);
        }
    }
}
