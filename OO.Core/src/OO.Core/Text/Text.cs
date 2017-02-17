using OO.Core.Text;

namespace OO.Core.Types
{
    public abstract class Text : Value<string>
    {
        public abstract override string Get();

        public new string ToString()
        {
            return Get();
        }

        public static implicit operator Text(string text)
        {
            return new StringText(text);
        }
    }
}
