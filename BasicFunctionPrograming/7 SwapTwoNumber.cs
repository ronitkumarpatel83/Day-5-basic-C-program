using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograming
{
    internal class SwapTwoNumber
    {
        public void STN()
        {
            Console.WriteLine("Welcome To Swap To Number Program: ");
            Console.WriteLine("Please Enter first Number ");

            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Second number: ");

            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Swapping First number is: " + first + " and second number is " + second);

            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine("After Swapping First number is: " + first + " and second number is " + second);
            Console.ReadLine();
        }
    }
}
