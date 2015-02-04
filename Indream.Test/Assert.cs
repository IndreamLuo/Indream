using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Test
{
    public static class Assert
    {
        public static T Value<T>(T value)
        {
            return value;
        }

        public static IEnumerable<T> Values<T>(params IEnumerable<T> values)
        {
            return values;
        }
    }
}
