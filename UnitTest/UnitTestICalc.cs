using Interfaces;

namespace UnitTest
{
    [TestClass]
    public class UnitTestICalc
    { 
        [TestMethod]
        public void ICalcTestLess()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            HMTask1 task1 = new HMTask1(array);
            Assert.AreEqual(2, task1.Less(3));
        }

        [TestMethod]
        public void ICalcTestGreater()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            HMTask1 task1 = new HMTask1(array);
            Assert.AreEqual(2, task1.Greater(3));
        }
    }
}