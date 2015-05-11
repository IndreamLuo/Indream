using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static partial class UtilityExtend
    {
        /// <summary>
        /// Returns value of object from getValue when NULL
        /// </summary>
        /// <param name="getValue">Gets the value of object</param>
        public static T NullThen<T>(this T @object, Func<T> getValue) where T : class
        {
            return @object ?? getValue();
        }

        /// <summary>
        /// Returns value of object from getValue when NULL
        /// </summary>
        /// <param name="getValue">Gets the value of object</param>
        /// <param name="setValueTo">Target to set the final value</param>
        public static T NullThen<T>(this T @object, Func<T> getValue, ref T setValueTo) where T : class
        {
            setValueTo = @object ?? getValue();
            return setValueTo;
        }
    }
}
