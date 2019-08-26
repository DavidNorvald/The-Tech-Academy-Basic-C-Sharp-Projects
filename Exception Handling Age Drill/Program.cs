using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Age_Drill
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 0)
                {
                    var myDate = DateTime.Now;
                    var newDate = myDate.AddYears(-age);
                    Console.WriteLine("You were born in: " + newDate.Year);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();

                }
            
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter only whole positive numbers");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured, Please contact your system administrator.");
                Console.ReadLine();
                return;
            }

        }
    }
}
