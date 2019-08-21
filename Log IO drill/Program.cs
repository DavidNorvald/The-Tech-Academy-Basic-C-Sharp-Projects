using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log_IO_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number, type any number you like!");
            string text = Console.ReadLine();
            File.WriteAllText(@"F:\MASTER - School Programs\Visual Studio Projects\Log IO drill\\log.txt", text);        // the @ symbol is used as an escape character

            string log = File.ReadAllText(@"F:\MASTER - School Programs\Visual Studio Projects\Log IO drill\log.txt");         //by hovering over string text, shows what text is being read in the file.
            Console.WriteLine("Number logged to file is: " + log);
            Console.ReadLine();
        }
    }
}
