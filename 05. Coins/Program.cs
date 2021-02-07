using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double lv = Math.Floor(money);
            double moneti = Math.Round((money - lv) * 100);
            int coins = 0;
            while (lv > 0)
            {
                //2
                if (lv >= 2)
                {
                    lv -= 2;
                    coins++;
                }
                //1
                else if (lv >= 1)
                {
                    lv -= 1;
                    coins++;
                }
            }
            while (moneti > 0)
            {
                //0.50
                if (moneti >= 50)
                {
                    moneti -= 50;
                    coins++;
                }
                //0.20
                else if (moneti >= 20)
                {
                    moneti -= 20;
                    coins++;
                }
                //0.10
                else if (moneti >= 10)
                {
                    moneti -= 10;
                    coins++;
                }
                //0.05
                else if (moneti >= 5)
                {
                    moneti -= 5;
                    coins++;
                }
                //0.02
                else if (moneti >= 2)
                {
                    moneti -= 2;
                    coins++;
                }
                //0.01
                else if (moneti >= 1)
                {
                    moneti -= 1;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}