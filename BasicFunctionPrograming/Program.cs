using System;

namespace BasicFunctionPrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# Program");
            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("1.Flip Coin \n2.Leap Year \n3.Power of Two \n4.Harmonic Number");
                Console.WriteLine("5.Factors \n6.Quatation and Number \n7.Swap Two Number");
                Console.WriteLine("8.Even or Odd \n9.Alphabet or Consonant \n10.Largest Among");
                Console.WriteLine("Please choose a number : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Flipcoin flipcoin = new Flipcoin();
                        flipcoin.FlipCoin1();
                        break;

                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.LY();
                        break;

                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.PT();
                        break;

                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.HN();
                        break;

                    case 5:
                        Factors factors = new Factors();
                        factors.Fact();
                        break;

                    case 6:
                        QuatationandReminder quatationandReminder = new QuatationandReminder();
                        quatationandReminder.QR();
                        break;

                    case 7:
                        SwapTwoNumber swapTwoNumber = new SwapTwoNumber();
                        swapTwoNumber.STN();
                        break;

                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.ED();
                        break;

                    case 9:
                        AlphabetorConsonant alphabetorConsonant = new AlphabetorConsonant();
                        alphabetorConsonant.AC();
                        break;

                    case 10:
                        LargestAmong largestAmong = new LargestAmong();
                        largestAmong.LA();
                        break;

                    default:
                        Console.WriteLine("Please enter valid number");
                        break;

                }

            }
            Console.WriteLine("\n Press 1 to Continue or Press any other key to Exit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
