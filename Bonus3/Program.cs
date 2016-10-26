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
            Boolean safe = true;
            Boolean check = false;
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            do
            {
                int n;
                Console.WriteLine("Guess a number 1-100");
                string input = Console.ReadLine();
                safe = int.TryParse(input, out n);
                while (safe == true);
                int guess = int.Parse(input);
            } while (check == false);
        }
    }
}
