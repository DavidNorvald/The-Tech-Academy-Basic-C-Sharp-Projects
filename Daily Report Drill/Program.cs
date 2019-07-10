using System;

namespace Daily_Report_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int currentPage = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool needHelp = true;
            string helpNeeded = Convert.ToString(needHelp);
            Console.ReadLine();
            bool noHelp = false;
            string helpNotNeeded = Convert.ToString(noHelp);
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
