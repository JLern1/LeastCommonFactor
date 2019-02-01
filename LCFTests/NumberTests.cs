using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LCFBusiness;

namespace LCFTests
{
    [TestFixture]
    class NumberTests
    {
        [Test]
        public void TestNumbers()
        {
            var checker = new Checker();

            var firstNum = 55;
            var secondNum = 95;
            var expected = 5;

            var actual = checker.CheckValues(firstNum, secondNum);



            Assert.AreEqual(expected, actual);
           
        }
    }
}
