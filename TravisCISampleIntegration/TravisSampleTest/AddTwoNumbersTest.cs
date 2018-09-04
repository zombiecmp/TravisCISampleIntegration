using System;
using Xunit;

namespace TravisSampleTest
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
