using ConsoleApp1;
namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test(Description = "Test Less")]
            public void FixedTestLess() => DoTest(0);

            [Test(Description = "Test Same")]
            public void FixedTestSame() => DoTest(123);

            [Test(Description = "Test Greater")]
            public void FixedTestGreater() => DoTest(500);

            [Test(Description = "Test Max")]
            public void FixedTestMax() => DoTest(int.MaxValue);

            [Test(Description = "Test Min")]
            public void FixedTestMin() => DoTest(int.MinValue);

            static void DoTest(int a)
            {
                unchecked
                {
                    long b = Dinglemouse.Int123(a);
                    Assert.IsTrue(b >= 0, "B must be >= 0");
                    Assert.AreEqual(123, (int)(a + b), "A + B must give 123");
                }
            }
        }
    }
}