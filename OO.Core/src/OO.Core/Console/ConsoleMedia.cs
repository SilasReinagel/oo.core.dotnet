using OO.Core.Output;
using OO.Core.Types;

namespace OO.Core.Console
{
    public sealed class ConsoleMedia : Media<Text>
    {
        public override void Print(Text text)
        {
            System.Console.WriteLine(text);
        }
    }
}
