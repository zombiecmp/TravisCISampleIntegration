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
        public void FailingTest()
        {
            Assert.Equal(5, SumTwoNumbers.Add(2, 2));
        }
    }
}
