using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend.Basic.For
{
    public class ForResult
    {
        public ForResult(int currentIndex, int loopTimes, ForResult lastFor = null)
        {
            this.CurrentIndex = currentIndex;
            this.Times = loopTimes;
            this.LastFor = lastFor;
        }

        public int CurrentIndex { get; private set; }

        public int Times { get; private set; }

        public ForResult LastFor { get; private set; }
    }
}
