using Indream.Extend.Linq.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend.Linq
{
    public static class LinqExtend
    {
        /// <summary>
        /// Select a set with amount 
        /// </summary>
        /// <param name="getItem">Gets each item in index</param>
        public static IEnumerable<T> Select<T>(this int amount, Func<int, T> getItem)
        {
            return new LazyLoadEnumerable<T>(() => LinqExtend.GetEnumerable(amount, getItem));
        }

        static IEnumerable<T> GetEnumerable<T>(int amount, Func<int, T> getItem)
        {
            for (var index = 0; index < amount; index++)
            {
                yield return getItem(index);
            }
        }
    }
}
