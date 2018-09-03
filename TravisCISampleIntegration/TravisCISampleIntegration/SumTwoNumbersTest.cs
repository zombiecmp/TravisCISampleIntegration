using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravisCISampleIntegration
{
    public class SumTwoNumbersTest
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(4, SumTwoNumbers.Add(2, 2));
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(5, SumTwoNumbers.Add(2, 2));
        }
    }
}
