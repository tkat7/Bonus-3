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
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            int guess = GetAndConvertInputToInt();
        }
        public static int GetAndConvertInputToInt()
        {
            string input;
            int convertedString;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Guess a number between 1 and 100 ");
                input = Console.ReadLine();
                try
                {
                    convertedString = Convert.ToInt32(input);
                    if (convertedString > 100 || convertedString < 0)
                    {
                        Console.WriteLine("A number you entered was a invalid number, please try again");
                        convertedString = 1;
                    }
                    return convertedString;
                }
                catch
                {
                    Console.WriteLine("A number you entered was a invalid number, please try again.");
                }
            }

        }
    }
}
