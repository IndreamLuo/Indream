using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <typeparam name="T">The type</typeparam>
        /// <param name="iEnumerable">The query</param>
        /// <param name="loopAction">The looping action to each item</param>
        public static void ForEach<T>(this IEnumerable<T> iEnumerable, Action<T> loopAction)
        {
            foreach (var item in iEnumerable)
                loopAction(item);
        }

        /// <summary>
        /// Substitute for foreach method
        /// </summary>
        /// <example>
        /// iEnumerable.ForEach(item => doSomeThingWith(item));
        /// </example>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="iEnumerable">The query</param>
        /// <param name="loopAction">The looping action to each item, return true to continue and false to break</param>
        public static void ForEach<T>(this IEnumerable<T> iEnumerable, Func<T, bool> loopAction)
        {
            foreach (var item in iEnumerable)
                if (!loopAction(item))
                    break;
        }

        /// <summary>
        /// Substitute for foreach method
        /// </summary>
        /// <example>
        /// iEnumerable.ForEach(item => doSomeThingWith(item));
        /// </example>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="iEnumerable">The query</param>
        /// <param name="loopAction">The looping action to each item, return true to continue and false to break</param>
        public static void ForEach<T>(this IEnumerable<T> iEnumerable, Func<T, int, bool> loopAction)
        {
            int index = 0;

            foreach (var item in iEnumerable)
                if (!loopAction(item, index++))
                    break;
        }
    }
}
