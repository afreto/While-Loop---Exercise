using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int allowedLowGrade = int.Parse(Console.ReadLine());

            int numLowGrade = 0;
            int numOfSolvedProblems = 0;
            double sumGrade = 0;
            string lastProblem = "";
            bool needBreak = false;

            string problem = Console.ReadLine();

            while (problem != "Enough")
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numLowGrade++;
                }
                if (numLowGrade >= allowedLowGrade)
                {
                    needBreak = true;
                    break;
                }

                numOfSolvedProblems++;
                sumGrade += grade;
                lastProblem = problem;

                problem = Console.ReadLine();
            }
            if (needBreak)
            {
                Console.WriteLine($"You need a break, {numLowGrade} poor grades.");
            }
            else
            {
                double averageGrade = sumGrade / numOfSolvedProblems;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {numOfSolvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
