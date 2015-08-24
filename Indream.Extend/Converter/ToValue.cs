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
        /// Convert the origin value to target value
        /// </summary>
        public static TValue ToValue<TOrigin, TValue>(this TOrigin origin, TValue value)
        {
            return value;
        }

        /// <summary>
        /// Convert the origin value to target value
        /// </summary>
        public static TValue ToValue<TOrigin, TValue>(this TOrigin origin, Func<TOrigin, TValue> converter)
        {
            return converter(origin);
        }
    }
}
