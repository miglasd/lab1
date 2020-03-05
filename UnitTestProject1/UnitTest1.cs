using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int result = ConsoleApp2.Program.Ploscha(a, b, c);
            int result2 = ConsoleApp2.Program.Obiem(a, b, c);
            Assert.AreEqual(22, result);
            Assert.AreEqual(6, result2);


        }
    }
}
