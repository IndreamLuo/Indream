using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static class Boolean
    {
        public static bool Navigate(this bool value)
        {
            return !value;
        }

        public static bool Or(this bool value, bool comparee)
        {
            return value || comparee;
        }

        public static bool And(this bool value, bool comparee)
        {
            return value && comparee;
        }
    }
}
