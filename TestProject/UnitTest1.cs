using TestConsole;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hello hello = new Hello();
            var ExpectedOutput = "Hello World";
            var AcutualOutput = hello.GetHello();
            Assert.AreEqual(ExpectedOutput, AcutualOutput);
        }
    }
}