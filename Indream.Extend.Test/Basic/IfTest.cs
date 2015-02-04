using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Indream.Extend;

namespace Indream.Extend.Test.Basic
{
    [TestClass]
    public class IfTest
    {
        [TestMethod]
        public void IfThen()
        {
            true
                .Then(() => { });
        }

        [TestMethod]
        public void IfThenThen()
        {
            true
                .Then(() => { })
                .Then(() => { });
        }

        [TestMethod]
        public void IfThenWithResultRedefinition()
        {
            true
                .Then(() => true)
                .Then(() => { });

            true
                .Then(() => false)
                .Then(() => { });
        }

        [TestMethod]
        public void IfThenElse()
        {
            true
                .Then(() => { })
                .Else(() => { });
        }

        [TestMethod]
        public void IfThenElseThen()
        {
            true
                .Then(() => { })
                .Else(() => { })
                .Then(() => { });
        }

        [TestMethod]
        public void IfThenElseWithResultRedefinition()
        {
            true
                .Then(() => { })
                .Else(() => true)
                .Then(() => { });

            true
                .Then(() => { })
                .Else(() => false)
                .Then(() => { });
        }
    }
}
