using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Indream.Extend.Test.Linq
{
    [TestClass]
    public class UnionTest
    {
        [TestMethod]
        public void And()
        {
            var originEnumerable = new int[] { 1, 2 };
            var newEnumerable = originEnumerable.Union(3).Union(4);

            var testArray = new object[4];
            var index = 0;
            foreach (var item in newEnumerable)
            {
                testArray[index++] = item;
            }

            Assert.AreEqual(testArray[0], 1);
            Assert.AreEqual(testArray[1], 2);
            Assert.AreEqual(testArray[2], 3);
            Assert.AreEqual(testArray[3], 4);

            testArray = new object[4];
            index = 0;
            foreach (var item in newEnumerable)
            {
                testArray[index++] = item;
            }

            Assert.AreEqual(testArray[0], 1);
            Assert.AreEqual(testArray[1], 2);
            Assert.AreEqual(testArray[2], 3);
            Assert.AreEqual(testArray[3], 4);
        }
    }
}
