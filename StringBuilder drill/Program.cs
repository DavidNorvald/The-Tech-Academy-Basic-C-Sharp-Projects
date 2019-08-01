using System;
using System.Text;

namespace StringBuilder_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dave";
            string job = "Software Developer";
            string school = "The Tech Academy";
            string description = name + " is studying to be a " + job + " at " + school.ToUpper() + "!";

            StringBuilder sb = new StringBuilder(50);
            sb.Append("Hello World! ");
            sb.AppendLine("This is my first attempt at using StringBuilder.");
            sb.AppendLine("StringBuilder is making it easy to add new strings into my paragraph.");
            sb.AppendLine("This is another line in my paragraph using AppendLine to create a new line.");

            Console.WriteLine(description);
            Console.ReadLine();

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
