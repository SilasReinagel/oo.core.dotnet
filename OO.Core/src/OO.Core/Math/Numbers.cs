using OO.Core.Group;
using OO.Core.Types;
using System.Collections.Generic;
using System.Linq;

namespace OO.Core.Math
{
    public sealed class Numbers : Group<Number>
    {
        public Numbers(params Number[] numbers)
            : this((IEnumerable<Number>)numbers) { }

        public Numbers(IEnumerable<Number> numbers)
            : base(numbers) { }

        public Numbers(Group<Number> numbers)
            : base(numbers) { }

        public Number Sum()
        {
            return Reduce(x => x.Sum(n => (decimal)n));
        }

        public static implicit operator Numbers(Number[] numbers)
        {
            return new Numbers(numbers);
        }
    }
}
