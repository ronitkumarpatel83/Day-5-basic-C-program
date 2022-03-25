using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograming
{
    internal class PowerOfTwo
    {
        public void PT()
        {
            Console.WriteLine("Wlcome to Power Of Two program");
            Console.WriteLine("Please Enter the range: ");
            int range = int.Parse(Console.ReadLine());
            if (range >= 31)
            {
                Console.WriteLine("Please input the range with in 31");
            }
            else
            {
                int n = range;
                int result = 1;
                while (range > 0)
                {
                    result = result * 2;
                    range--;
                }
                Console.WriteLine("Result of 2^" + n + "is: " + result);
            }
            Console.ReadLine();

        }
    }
}
