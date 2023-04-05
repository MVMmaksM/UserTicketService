using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AdditionalMustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50,10,34);
            Assert.AreEqual(94, result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.AreEqual(120, result);
        }
    }
}
