using OO.Core.Group;
using OO.Core.Types;
using System.Collections.Generic;

namespace OO.Core.Math
{
    public sealed class Range : Group<Number>
    {
        public Range(Number first, Number last)
            : this(first, last, 1) { }

        public Range(Number first, Number last, Number stepSize)
            : base(Create(first, last, stepSize)) { }

        private static IEnumerable<Number> Create(Number first, Number last, Number stepSize)
        {
            for (var i = first; i <= last; i = i + stepSize)
                yield return i;
        }
    }
}
