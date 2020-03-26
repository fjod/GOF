using System.Collections;
using System.Collections.Generic;

namespace GOF.Behavioral.Iterator
{
    class ConcreteIterator2 : IEnumerator
    {
        private int _count = -1;
        public bool MoveNext()
        {
            _count++;
            return (_count < 3);
        }

        public void Reset()
        {
            _count = -1;
        }

        object? IEnumerator.Current => Current1;

        string Current1 => "IEnumerator " + _count;
    }

    class ConcreteIterator3 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new ConcreteIterator2();
        }
    }
    
}