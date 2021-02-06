using System;
using System.Threading.Channels;

namespace _03._Vacation
{
    class Program
    {
        static void Main()
        {
            double moneyNeededForTrip = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int numOfSpendDays = 0;
            int numOfDays = 0;
            while (numOfSpendDays < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                switch (action)
                {
                    case "spend":
                        numOfSpendDays++;
                        numOfDays++;
                        if (amount > availableMoney)
                        {
                            availableMoney = 0;
                        }
                        else
                        {
                            availableMoney -= amount;
                        }
                        break;
                    default:
                        numOfSpendDays = 0;
                        numOfDays++;
                        availableMoney += amount;
                        break;
                }
                if (availableMoney >= moneyNeededForTrip)
                {
                    Console.WriteLine($"You saved the money for {numOfDays} days.");
                    break;
                }
            }
            if (numOfSpendDays >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(numOfDays);
            }
        }
    }
}