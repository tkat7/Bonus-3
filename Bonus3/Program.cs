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
            Console.Write("Guess a number 1-100");

        }
    }
}
