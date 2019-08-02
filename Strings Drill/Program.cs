using System;
using System.Collections.Generic;

namespace Strings_Drill
{
    class Program
    {
        static void Main()
        {
            int tryTimes = 0;
            while (tryTimes < 2)
            {
                string[] nameArray = { "Dave", "John", "Bob", "Tiffany", "Lilly", "Betty" };
                Console.WriteLine("Pick a number. 0. for Dave, 1. for John, 2. for Bob, 3. for Tiffany, 4. for Lilly, or 5. for Betty.");
                int userName = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("You selected: " + nameArray[userName]);
                    Console.ReadLine();
                    break;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Number is not in the Array, please select a number again.");
                    Console.ReadLine();
                    tryTimes++;
                }
            }
            int tryTimesAgain = 0;
            while (tryTimesAgain < 2)
            {
                int[] numberArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine("Now, pick a number between 0 - 9.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("You chose the number: " + numberArray[userNum]);
                    Console.ReadLine();
                    break;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Number is not in the Array, please select a number again.");
                    Console.ReadLine();
                    tryTimesAgain++;
                }
            }
            int tryTimesYetAgain = 0;
            while (tryTimesYetAgain < 2)
            {
                List<string> colorList = new List<string>
                {
                "Red",
                "Blue",
                "Yellow",
                "Green",
                "Orange",
                "Purple"
                };

                Console.WriteLine("Pick a color, 0. for Red, 1. for Blue, 2. for Yellow, 3. for Green, 4. for Orange, or 5. for Purple.");
                int userColor = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("You chose the color: " + (colorList[userColor]));
                    Console.ReadLine();
                    break;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number is not in the List, please select a number again.");
                    Console.ReadLine();
                    tryTimesYetAgain++;
                }
            }
        }
    }
}
