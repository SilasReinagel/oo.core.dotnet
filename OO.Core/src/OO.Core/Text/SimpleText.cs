
namespace OO.Core.Text
{
    public sealed class SimpleText : Text
    {
        private readonly string value;

        public SimpleText(string value)
        {
            this.value = value;
        }

        public override string Get()
        {
            return value;
        }
    }
}
