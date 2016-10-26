using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean safe = false;
            Boolean check = false;
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            do
            {
                int n;
                while (safe == false)
                {
                    Console.WriteLine("Guess a number 1-100");
                    string input = Console.ReadLine();
                    safe = int.TryParse(input, out n);
                }
                int guess = int.Parse(input);




                int status = 1;
                switch (status)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                }
            } while (check == false);
        }

        public static Boolean CheckGuess(int guess, int num)
        {
            if (guess >= num + 10)
            {
                Console.WriteLine("That is way too high");
                return false;
            }
            else if (guess <= num - 10)
            {
                Console.WriteLine("That is way too low");
                return false;
            }
            else if (guess > num)
            {
                Console.WriteLine("That is too high");
                return false;
            }
            else if (guess < num)
            {
                Console.WriteLine("That is too low");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
