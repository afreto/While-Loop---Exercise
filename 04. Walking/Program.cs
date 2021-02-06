using System;

namespace _04._Walking
{
    class Program
    {
        static void Main()
        {
            const int goal = 10000;
            string input = Console.ReadLine();
            int sumSteps = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                sumSteps += steps;
                if (sumSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sumSteps - goal} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                sumSteps += int.Parse(Console.ReadLine());
                if (sumSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sumSteps - goal} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{goal - sumSteps} more steps to reach goal.");
                }
            }
        }
    }
}