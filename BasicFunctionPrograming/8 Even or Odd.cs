using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograming
{
    internal class EvenOdd
    {
        public void ED()
        {
            Console.WriteLine("Enter a number to check even or odd: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The given number " + num + " Is even");
            }
            else
            {
                Console.WriteLine("The given number " + num + " Is Odd");
            }
            Console.ReadLine();
        }
    }
}
