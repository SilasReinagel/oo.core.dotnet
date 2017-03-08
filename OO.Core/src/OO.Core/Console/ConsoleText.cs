using OO.Core.Types;

namespace OO.Core.Console
{
    public sealed class ConsoleText : Text
    {
        public override string Get()
        {
            return System.Console.ReadLine();
        }
    }
}
