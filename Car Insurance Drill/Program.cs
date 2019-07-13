using System;

namespace Car_Insurance_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you qualify for Auto Insurance?");
            Console.WriteLine("Please answer the following questions:");
            Console.WriteLine("What is your age?");
            string ageNow = Console.ReadLine();
            int currentAge = Convert.ToInt32(ageNow);

            Console.WriteLine("Have you ever had a DUI? true or false");
            string duiStatus = Console.ReadLine();
            string yesDui = "true";
            string noDui = "false";

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketNum = Console.ReadLine();
            int numOfTickets = Convert.ToInt32(ticketNum);

            bool isQualified = (currentAge > 15 && duiStatus == "false" && numOfTickets <= 3);
            Console.WriteLine("Qualified?: " + isQualified);
            Console.ReadLine();
             
        }
    }
}


