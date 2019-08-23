using System;

namespace Const_Var_Drill
{
    class Program
    {
        static void Main(string[] args)
        {

            const string animalName = "Spot the dog";
            var restOfThePhrase = "jumped over the barn";

            Console.WriteLine("{0} {1}. Wow, that dog can jump!", animalName, restOfThePhrase);
            Console.ReadLine();

        }
    }
}
