using Indream.Extend;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Indream.Extend.Test.Delegate
{
    [TestClass]
    public class ToValueTest
    {
        [TestMethod]
        public void IntToString()
        {
            Assert.AreEqual("123", 123.ToValue("123"));
            Assert.AreEqual("123", 123.ToValue(number => number.ToString()));
        }
    }
}
