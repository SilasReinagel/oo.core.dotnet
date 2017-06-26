using OO.Core.Base;
using OO.Core.Storage;
using OO.Core.Types;

namespace OO.Core.Console
{
    public sealed class ConsoleText : Text
    {
        private readonly Memo<Text> _memo = new Memo<Text>(new FunctionValue<Text>(() => System.Console.ReadLine()));

        public override string Get()
        {
            return _memo.Get();
        }
    }
}
