using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static partial class UtilityExtend
    {
        public static T NullOr<T>(this T @object, Func<T> getValue) where T : class
        {
            return @object ?? getValue();
        }

        public static T NullOr<T>(this T @object, Func<T> getValue, ref T output) where T : class
        {
            output = @object ?? getValue();
            return output;
        }
    }
}
