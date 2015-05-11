using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Indream.Extend.Test.Delegate
{
    [TestClass]
    public class ToTrueTest
    {
        [TestMethod]
        public void ContinuousToTrue()
        {
            new Action(() => { })
                .RunAndToTrue();
        }
    }
}
