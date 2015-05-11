using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend.Linq.Infrastructure
{
    /// <summary>
    /// A lazy load IEnumerable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyLoadEnumerable<T> : IEnumerable<T>
    {
        /// <summary>
        /// Constructor with the lazy loading get IEnumerable function
        /// </summary>
        public LazyLoadEnumerable(Func<IEnumerable<T>> getEnumerable)
        {
            this.GetEnumerable = getEnumerable;
        }

        public Func<IEnumerable<T>> GetEnumerable { get; private set; }

        public IEnumerable<T> OriginEnumerable
        {
            get
            {
                return this._originEnumerable
                    .NullThen(this.GetEnumerable, ref this._originEnumerable);
            }
        } IEnumerable<T> _originEnumerable;

        public IEnumerator<T> GetEnumerator()
        {
            return this.OriginEnumerable.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
