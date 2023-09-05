namespace TestProj2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestCases.Addition add = new UnitTestCases.Addition();
            int x = add.AddInt(1, 2);
            Assert.AreEqual(3, x);
        }
    }
}