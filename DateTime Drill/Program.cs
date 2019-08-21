using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Drill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! the current date and time is: " + DateTime.Now);
            Console.WriteLine("Give me a number between 1 and 12.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In {0} hour(s), it will be {1}", userNum, DateTime.Now.AddHours(userNum));

            Console.ReadLine();
        }
    }
}
