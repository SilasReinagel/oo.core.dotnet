using OO.Core.Output;
using OO.Core.Types;

namespace OO.Core.Console
{
    public class ConsoleMedia : Media
    {
        public override void Print(Text text)
        {
            System.Console.WriteLine(text);
        }
    }
}
