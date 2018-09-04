using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravisCISampleIntegration
{
    public class SumTwoNumbersTest
    {
        //[Fact]
        public void PassingTest()
        {
            Assert.Equal(4, SumTwoNumbers.Add(2, 2));
        }

        //[Fact]
        public void FailingTest()
        {
            Assert.Equal(5, SumTwoNumbers.Add(2, 2));
        }
    }
}
