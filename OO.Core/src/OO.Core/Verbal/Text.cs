using OO.Core.Verbal;

namespace OO.Core.Types
{
    public abstract class Text : Value<string>
    {
        public abstract override string Get();

        public sealed override string ToString()
        {
            return Get();
        }

        public static implicit operator Text(string text)
        {
            return new StringText(text);
        }
    }
}
