using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2018_09_IC_loops_for_ClassAveHighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            double lowestMark = 100, highestMark = 0, averageMark, sumOfMarks = 0;

            Console.Write("How many students are there in the class?: ");
            int students = int.Parse(Console.ReadLine());
            for (int number = 1; number <= students;)
            {
                Console.Write($" what is Student #{number}'s mark?: ");
                double mark = double.Parse(Console.ReadLine());

                if (mark < lowestMark)
                    lowestMark = mark;

                if (mark > highestMark)
                    highestMark = mark;

                sumOfMarks += mark;
                number++;
            }
            averageMark = sumOfMarks / students;

            Console.WriteLine($" the lowest mark was {lowestMark}%, the highest mark was {highestMark}%, and the class average was {averageMark}%");
        }
    }
}
