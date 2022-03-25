using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograming
{
    internal class QuatationandReminder
    {
        public void QR()
        {
            Console.WriteLine("Welcome to Quatation and Reminder Program");
            int q, r;
            Console.WriteLine("Please Enter a Divinded:");
            int divi = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Divisor: ");
            int div = int.Parse(Console.ReadLine());
            q = divi / div;
            r = divi % div;
            Console.WriteLine("The Quotient is: " + q);
            Console.WriteLine("The Reminder is: " + r);
            Console.ReadLine();
        }
    }
}
