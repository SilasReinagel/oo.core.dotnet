using OO.Core.Base;
using OO.Core.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OO.Core.Group
{
    public abstract class Group<T> : IEnumerable<T>
    {
        private IEnumerable<T> _elements;

        public Group(Group<T> group)
            : this(group._elements) { }

        public Group(IEnumerable<T> elements)
        {
            _elements = elements;
        }

        public T Reduce(Func<IEnumerable<T>, T> reduction)
        {
            return reduction(_elements);
        }

        public Group<T2> Map<T2>(Func<T, T2> mapping)
        {
            return new SimpleGroup<T2>(_elements.Select(x => mapping(x)));
        }

        public Texts Texts(Func<T, Text> mapping)
        {
            return new Texts(_elements.Select(x => mapping(x)));
        }

        public Work ForEach(Action<T> work)
        {
            return new ActionWork(() => _elements.ToList().ForEach(x => work(x)));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static implicit operator T[](Group<T> group)
        {
            return group.ToArray();
        }
    }
}
