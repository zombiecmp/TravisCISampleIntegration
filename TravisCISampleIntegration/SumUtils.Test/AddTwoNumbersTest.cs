using System;
using Xunit;

namespace SumUtils.Test
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, SumTwoNumbers.Add(2, 2));
        }

        [Fact]
        public void PassingTest3Plus2()
        {
            Assert.Equal(5, SumTwoNumbers.Add(3, 2));
        }
    }
}
