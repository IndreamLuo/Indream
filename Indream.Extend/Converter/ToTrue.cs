using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static partial class ConvertExtend
    {
        /// <summary>
        /// Returns true
        /// </summary>
        /// <returns>TRUE</returns>
        public static bool ToTrue<TOrigin>(this TOrigin origin)
        {
            return origin.ToValue(true);
        }

        /// <summary>
        /// Returns false
        /// </summary>
        /// <returns>FALSE</returns>
        public static bool ToFalse<TOrigin>(this TOrigin origin)
        {
            return origin.ToValue(false);
        }

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
