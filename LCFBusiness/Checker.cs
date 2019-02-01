using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCFBusiness
{
    public class Checker
    {
        public int CheckValues(int firstNum, int secondNum)
        {
            int i = 2;
            bool areBothDivisible;
            do
            {
                areBothDivisible = AreBothDivisible(firstNum, secondNum, i);
                ++i;
            } while (areBothDivisible != true);

            return i - 1;
        }

        public bool AreBothDivisible(int firstNum, int secondNum, int divisor)
        {
            var firstNumCheck = firstNum % divisor == 0;
            var SecondNumCheck = secondNum % divisor == 0;
            return (firstNumCheck && SecondNumCheck) ? true : false;
        }
    }
}
