using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int pieces = 0;
            string takenCake = Console.ReadLine();
            while (takenCake != "STOP")
            {
                int numOfCake = int.Parse(takenCake);
                pieces += numOfCake;
                if (pieces >= (width * lenght))
                {
                    Console.WriteLine($"No more cake left! You need {pieces - (width * lenght)} pieces more.");
                    return;
                }
                takenCake = Console.ReadLine();
            }
            Console.WriteLine($"{(width * lenght) - pieces} pieces are left.");
        }
    }
}