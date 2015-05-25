using Indream.Extend.Linq.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
    public static class And
    {
        public static IEnumerable Union(this IEnumerable originEnumerable, object nextObject)
        {
            return new ManualEnumerable(() => new UnionEnumerator(originEnumerable, nextObject));
        }
    }
}
