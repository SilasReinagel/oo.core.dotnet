using System;
using OO.Core.Types;

namespace OO.Core.Base
{
    public sealed class ActionWork : Work
    {
        private readonly Action _work;

        public ActionWork(Action work)
        {
            _work = work;
        }

        public override void Go()
        {
            _work.Invoke();
        }
    }
}
