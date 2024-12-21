using Interfaces;

namespace UnitTest
{
    [TestClass]
    public class UnitTestIOutput2
    {
        [TestMethod]
        public void IOutput2TestShowEven()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            HMTask2 task2 = new HMTask2(array);
            task2.ShowEven();
        }

        [TestMethod]
        public void IOutput2TestShowOdd()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            HMTask2 task2 = new HMTask2(array);
            task2.ShowOdd();
        }
    }
}
