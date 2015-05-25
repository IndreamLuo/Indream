using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend.Linq.Infrastructure
{
    [Serializable]
    public struct UnionEnumerator : IEnumerator
    {
        public UnionEnumerator(IEnumerable originEnumerable, object nextObject)
        {
            this.originEnumerable = originEnumerable;
            this.originEnumerator = this.originEnumerable.GetEnumerator();
            this.nextObject = nextObject;
            this.isNextObjectYielded = false;
            this.isEndOfOriginEnumerable = false;
        }

        readonly IEnumerable originEnumerable;

        IEnumerator originEnumerator;

        readonly object nextObject;

        public bool isEndOfOriginEnumerable;

        bool isNextObjectYielded;

        void markNextObjectYielded()
        {
            if (this.isNextObjectYielded)
            {
                throw new NotImplementedException();
            }

            this.isNextObjectYielded = true;
        }

        public object Current
        {
            get
            {
                if (!this.isEndOfOriginEnumerable)
                {
                    return this.originEnumerator.Current;
                }
                else
                {
                    this.markNextObjectYielded();
                    return nextObject;
                }
            }
        }

        public bool MoveNext()
        {
            if (this.isEndOfOriginEnumerable)
                return !this.isNextObjectYielded;
            else if (this.originEnumerator.MoveNext())
                return true;
            else
                return this.isEndOfOriginEnumerable = true;
        }

        public void Reset()
        {
            this.originEnumerator.Reset();
            this.isEndOfOriginEnumerable = false;
            this.isNextObjectYielded = false;
        }
    }
}
