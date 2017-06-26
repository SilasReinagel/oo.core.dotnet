using System.Collections.Generic;

namespace OO.Core.Group
{
    public sealed class SimpleGroup<T> : Group<T>
    {
        public SimpleGroup(IEnumerable<T> elements)
            : base(elements) { }
    }
}
