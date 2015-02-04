using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static partial class BasicExtend
    {
        public static bool Then(this bool @if, Action then)
        {
            if (@if)
                then();

            return @if;
        }

        public static bool Then(this bool @if, Func<bool> then)
        {
            if (@if)
                return then();

            return @if;
        }

        public static bool Else(this bool then, Action @else)
        {
            if (!then)
                @else();

            return true;
        }

        public static bool Else(this bool then, Func<bool> @else)
        {
            if (!then)
                return @else();

            return true;
        }
    }
}
