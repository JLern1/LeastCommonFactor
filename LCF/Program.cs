using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCFBusiness;

namespace LCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = PickNumber();
            int secondNum = PickNumber();
            int leastCommonFactor = CheckNumbers(firstNum, secondNum);
            Console.WriteLine($"The LCF of {firstNum} and {secondNum} is {leastCommonFactor}.");
            Console.ReadLine();
        }

        private static int PickNumber()
        {
            Console.Write("Pick a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return Number;
        }

        public static int CheckNumbers(int firstNum, int secondNum)
        {
            var checker = new Checker();
            return checker.CheckValues(firstNum, secondNum);
        }
    }
}
