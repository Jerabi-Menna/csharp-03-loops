using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_loops_while_GuessNumberPlayOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0, answer = 1001;
            Random CookiesOfDoom = new Random();
            int question = CookiesOfDoom.Next(1, 100);

            while(answer != question)
            { 
                Console.Write("what is your guess at the number between 1 to 100: ");
                answer = int.Parse(Console.ReadLine());
                if (answer < question)
                {
                    Console.WriteLine("too low.... please go higher\n");
                    guesses++;
                }
                else if (answer > question)
                {
                    Console.WriteLine("THAT NUMBER IS TOO HIGH! LOWER IT\n");
                    guesses++;
                }
            }
            Console.WriteLine($"YOU ARE THE WINNER! IT TOOK YOU {guesses} tries");

        }
    }
}
