using System;

namespace Package_Express_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter your packages weight.");

            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is your packages width in feet");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your packages height in feet");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your packages length in feet");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                double packageSize = packageWidth + packageHeight + packageLength;

                if (packageSize > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double shippingQuote = packageSize * packageWeight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote);
                }
                Console.WriteLine("Thank you.");
                Console.ReadLine();
            }


        }
    }
}
