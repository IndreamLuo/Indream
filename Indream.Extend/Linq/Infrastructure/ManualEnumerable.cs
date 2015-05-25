using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend.Linq.Infrastructure
{
    public class ManualEnumerable : IEnumerable
    {
        public ManualEnumerable(Func<IEnumerator> getEnumerator)
        {
            this.getEnumerator = getEnumerator;
        }

        readonly Func<IEnumerator> getEnumerator;

        public IEnumerator GetEnumerator()
        {
            return this.getEnumerator();
        }
    }
}
