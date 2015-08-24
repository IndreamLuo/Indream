using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Indream.Extend.Test.Converter
{
    [TestClass]
    public class ToTrueTest
    {
        [TestMethod]
        public void ToTrueOrFalse()
        {
            Assert.AreEqual(true, 1.ToTrue());
            Assert.AreEqual(false, 1.ToFalse());
        }

        [TestMethod]
        public void ContinuousToTrue()
        {
            new Action(() => { })
                .RunAndToTrue();
        }
    }
}
