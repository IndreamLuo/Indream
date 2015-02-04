using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static partial class DelegateExtend
    {
        public static bool RunToTrue(this Action action)
        {
            action();

            return true;
        }

        public static bool RunToFalse(this Action action)
        {
            action();

            return true;
        }
    }
}
