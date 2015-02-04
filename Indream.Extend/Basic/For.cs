using Indream.Extend.Basic.For;
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
        /// Loop the action in times by step
        /// </summary>
        /// <param name="times">Times to loop</param>
        /// <param name="step">Step with index called back</param>
        /// <returns>The result contains for infomations</returns>
        public static ForResult For(this int times, Action<int> step)
        {
            return new ForResult(0, times)
                .Continue(step);
        }

        /// <summary>
        /// Loop the action in times by step
        /// </summary>
        /// <param name="times">Times to loop</param>
        /// <param name="step">Step with index called back</param>
        /// <returns>The result contains for infomations</returns>
        public static ForResult Continue(this ForResult lastFor, Action<int> step)
        {
            return lastFor.Continue(i =>
            {
                step(i);
                return true;
            });
        }

        /// <summary>
        /// Loop the action in times by step
        /// </summary>
        /// <param name="times">Times to loop</param>
        /// <param name="step">Step with index called back, return false to break</param>
        /// <returns>The result contains for infomations</returns>
        public static ForResult For(this int times, Func<int, bool> step)
        {
            return new ForResult(0, times)
                .Continue(step);
        }

        /// <summary>
        /// Loop the action in times by step
        /// </summary>
        /// <param name="times">Times to loop</param>
        /// <param name="step">Step with index called back, return false to break</param>
        /// <returns>The result contains for infomations</returns>
        public static ForResult Continue(this ForResult lastFor, Func<int, bool> step)
        {
            int index;
            for (index = lastFor.CurrentIndex
                ; lastFor.CurrentIndex < lastFor.Times
                ; index++)
                if (!step(index))
                    break;

            return new ForResult(index, lastFor.Times, lastFor);
        }
    }
}
