#nullable enable
using System.Collections;
using System.Collections.Generic;

namespace GOF.Behavioral.Iterator
{
    public class ConcreteIterator : IEnumerable
    {
        private int _count = 0;
        public IEnumerator GetEnumerator()
        {
            for (_count = 0;_count  < 3; _count++)
            {
                yield return "IEnumerable " + _count.ToString();
            }

            _count = 0;
        }
    }
}