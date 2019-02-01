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
            bool firstNumCheck = false;
            bool SecondNumCheck = false;
            do
            {

                firstNumCheck = firstNum % i == 0;
                SecondNumCheck = secondNum % i == 0;
                ++i;
            } while (firstNumCheck != true && SecondNumCheck != true);

            return i - 1;
        }
    }
}
