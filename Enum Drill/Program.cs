using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Drill
{
    class Program
    {

        public enum DaysOfTheWeek
        {
            Wrong,
            Monday = 1,
            Tuesday = 2,
            wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {

            Console.WriteLine("What day of the week is it today?");
            string value = Console.ReadLine();
            DaysOfTheWeek day;
            try
            {
               day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. Make sure it is capitalized if possible");
                Console.WriteLine(ex.Message);
                day = DaysOfTheWeek.Wrong;
                Console.ReadLine();
            }
            if (day == DaysOfTheWeek.Thursday)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Not the correct day of the week.");
            }



            //DaysOfTheWeek currentDay = DaysOfTheWeek.Monday;       // enum's limit the possible values you can receive from a user     // helps limit errors from users

            Console.ReadLine();
        }
    }
}
