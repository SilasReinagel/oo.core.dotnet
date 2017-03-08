using OO.Core.Types;

namespace OO.Core.Output
{
    public class Printed : Work
    {
        private readonly Text _text;
        private readonly Media _media;

        public Printed(Text text, Media media)
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
