using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indream.Extend.Basic;

namespace Indream.Extend
{
    public static partial class BasicExtend
    {
        /// <summary>
        /// Substitute for foreach method
        /// </summary>
        /// <example>
        /// iEnumerable.ForEach(item => doSomeThingWith(item));
        /// </example>
        /// <param name="loopAction">The looping action to each item</param>
        /// <returns>The origin enumerable object</returns>
        public static TEnumerable ForEach<TEnumerable, TItem>(this TEnumerable iEnumerable, Action<TItem> loopAction)
            where TEnumerable : IEnumerable<TItem>
        {
            lock (iEnumerable)
            {
                foreach (var item in iEnumerable)
                    loopAction(item);
            }

            return iEnumerable;
        }

        /// <summary>
        /// Substitute for foreach method
        /// </summary>
        /// <example>
        /// iEnumerable.ForEach(item => doSomeThingWith(item));
        /// </example>
        /// <param name="loopAction">The looping action to each item, return true to continue and false to break</param>
        public static TEnumerable ForEach<TEnumerable, TItem>(this TEnumerable iEnumerable, Func<TItem, bool> loopAction)
            where TEnumerable : IEnumerable<TItem>
        {
            lock (iEnumerable)
            {
                foreach (var item in iEnumerable)
                    if (!loopAction(item))
                        break;
            }

            return iEnumerable;
        }

        /// <summary>
        /// Substitute for foreach method
        /// </summary>
        /// <example>
        /// new int[] { 0, 1, 2 }
        ///     .ForEach((item, index) => i == 0);
        /// </example>
        /// <param name="loopAction">The looping action to each item, return true to continue and false to break</param>
        public static TEnumerable ForEach<TEnumerable, TItem>(this TEnumerable iEnumerable, Func<TItem, int, bool> loopAction)
            where TEnumerable : IEnumerable<TItem>
        {
            int index = 0;

            lock (iEnumerable)
            {
                foreach (var item in iEnumerable)
                    if (!loopAction(item, index++))
                        break;
            }

            return iEnumerable;
        }

        public static IEnumerable<IEnumerable> ForEach(this IEnumerable<IEnumerable> iEnumerables, Func<object[], int, bool> loopAction)
        {
            lock(iEnumerables)
            {
                var firstEnumerable = iEnumerables.First();
                lock (firstEnumerable)
                {
                    foreach (var item in firstEnumerable)
                    {

                    }
                }
            }

            return iEnumerables;
        }
    }
}
