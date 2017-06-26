using OO.Core.Output;
using OO.Core.Types;
using OO.Core.Verbal;

namespace OO.Core.Console
{
    public sealed class ConsolePrinted : Work
    {
        private readonly Texts _texts;
        private readonly Media<Text> _media;

        public ConsolePrinted(Number number)
            : this(new Texts((Text)new NumberAsText(number))) { }

        public ConsolePrinted(Text text)
            : this(new Texts(text)) { }

        public ConsolePrinted(Texts texts)
        {
            _texts = texts;
            _media = new ConsoleMedia();
        }

        public override void Go()
        {
            _texts.ForEach(_media.Print).Go();
        }
    }
}
