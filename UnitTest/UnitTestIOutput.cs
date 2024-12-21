using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace UnitTest
{
    [TestClass]
    public class UnitTestIOutput
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            IOutput output = new Array(elements);
            output.Show();
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            IOutput output = new Array(elements);
            output.Show("Array elements:");
        }
    }

}