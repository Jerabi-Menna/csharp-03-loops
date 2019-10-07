using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_2018_09_IC_loops_do_while_ClassAveHighLowPlayMany
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade=0, highGrade= 0, lowGrade = 100, sumOfGrades = 0;
            int Students = 0;
            do
            {
                Console.Write($"What is the grade of the #{Students+1} student? (999 to finish): ");
                grade = double.Parse(Console.ReadLine());
                if(grade < 0)
                {
                    Console.WriteLine("you can't give negative grades");
                }

                else if (grade == 999)
                {
                    Console.WriteLine($"You had {Students} Students entered, the highest mark was {highGrade}% the lowest mark was {lowGrade}% the class average was {sumOfGrades/(double)Students}%");
                }
                else if (grade >100)
                {
                    Console.WriteLine("You can not enter over 100%");
                }
                else
                {
                    //is it a record breaker?
                    if (grade < lowGrade)
                    lowGrade = grade;

                    if (grade > highGrade)
                    highGrade = grade;

                    //lets add the grade to total and increase number of students for average calculation later
                    sumOfGrades += grade;
                    Students++;
                }


            }while(grade != 999);

        
}
    }
}
