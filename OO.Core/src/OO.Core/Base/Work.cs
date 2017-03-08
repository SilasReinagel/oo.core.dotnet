using System;
using OO.Core.Base;

namespace OO.Core.Types
{
    public abstract class Work
    {
        public abstract void Go();

        public static implicit operator Work(Action work)
        {
            return new ActionWork(work);
        }
    }
}
