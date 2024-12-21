using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{

    [TestClass]
    public class UnitTestICalc2
    {
        [TestMethod]
        public void ICalc2TestCountDistinct()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            Interfaces.Array task3 = new Interfaces.Array(array);
            int distinctCount = task3.CountDistinct();
            Assert.AreEqual(5, distinctCount);
        }

        [TestMethod]
        public void ICalc2TestEqualToValue()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            Interfaces.Array task3 = new Interfaces.Array(array);
            int equalCount = task3.EqualToValue(3);
            Assert.AreEqual(2, equalCount);
        }
    }
}
