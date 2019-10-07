using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_2017_09_IC_loops_do_while_AddCalcPlayMany
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "=";
            int total = 0, calc = 0;
            bool playing = false, error = false;
            do
                {
                do
                    {

                        Console.Write("Enter a number: ");
                        num = Console.ReadLine();
                        if(num == "=")
                            {}
                        else
                        {
                            calc = int.Parse(num);
                            total+=calc;
                        }
                    }while(num != "=");
                    
                    Console.WriteLine($"your total was {total}");
                    Console.WriteLine("\nplay again? Y/N\n");
                    var userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.Y)
                    {
                        playing = true;
                        error = false;
                    }
                    else if (userInput.Key == ConsoleKey.N)
                    {
                        playing = false;
                        Console.WriteLine($"Thank you for playing");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("invalid key entered");
                        error = true;
                    }while (error == true);
                }while (playing == true);
        }
    }
}
