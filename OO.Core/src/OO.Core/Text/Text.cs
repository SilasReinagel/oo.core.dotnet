
using OO.Core.Types;

namespace OO.Core.Text
{
    public abstract class Text : Value<string>
    {
        public abstract string Get();

        public new string ToString()
        {
            return Get();
        }

        public static implicit operator Text(string simpleText)
        {
            return new SimpleText(simpleText);
        }
    }
}
