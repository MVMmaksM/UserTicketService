using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Test
{
    [TestFixture]
    internal class CalculatorTest
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue() 
        {
            var calculator = new Calculator();
            Assert.That(calculator.Add(10, 220), Is.EqualTo(230));
        }
    }
}
