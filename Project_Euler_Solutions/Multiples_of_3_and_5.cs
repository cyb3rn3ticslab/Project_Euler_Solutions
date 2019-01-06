using System;

namespace Project_Euler_Solutions
{
    class Multiples_of_3_and_5
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i=1; i<1000; i++) {
                if ((i % 3 == 0) || (i % 5 == 0)) {
                    total += i;
                }
            }

            Console.WriteLine("The Sum of all the multiples of 3 or 5 below 1000 is:  " + total);
        }
    }
}
