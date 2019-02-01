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
            Console.Write("Pick a number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Pick a number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int leastCommonFactor = CheckNumbers(firstNum, secondNum);
            Console.WriteLine($"The LCF of {firstNum} and {secondNum} is {leastCommonFactor}.");
            Console.ReadLine();
        }
        public static int CheckNumbers(int firstNum, int secondNum)
        {
            var checker = new Checker();
            return checker.CheckValues(firstNum, secondNum);
        }
    }
}
