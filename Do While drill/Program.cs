using System;

namespace Do_While_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 21?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 17;

            do
            {
                switch (number)
                {
                    case 19:
                        Console.WriteLine("You guessed the number 19. Guess again, not the number I am thinking of.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("You chose the number 15.");
                        Console.WriteLine("You are really close, but not close enough, try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That number is...");
                        Console.WriteLine("not your luck, try again.....");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("You guessed 11. Not a lucky number today...");
                        Console.WriteLine("Try another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("You guessed the number 17. That is correct!!!");
                        Console.WriteLine("How did you know?!");
                        isGuessed = true;
                        break;
                    case 5:
                        Console.WriteLine("Your number was 5, mine was not, try again...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You chose 1, that number is cold.....");
                        Console.WriteLine("Try another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("10.... Hrm...");
                        Console.WriteLine("Hrm...");
                        Console.WriteLine("Nope, not right, try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (isGuessed);

            Console.ReadLine();
        }
    }
}
