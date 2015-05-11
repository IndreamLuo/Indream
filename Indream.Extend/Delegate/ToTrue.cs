using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static partial class DelegateExtend
    {
        /// <summary>
        /// Runs the action and returns true
        /// </summary>
        /// <returns>TRUE</returns>
        public static bool RunAndToTrue(this Action action)
        {
            action();

            return true;
        }

        /// <summary>
        /// Runs the action and returns false
        /// </summary>
        /// <returns>FALSE</returns>
        public static bool RunAndToFalse(this Action action)
        {
            action();

            return true;
        }
    }
}
