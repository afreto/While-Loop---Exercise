using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main()
        {
            string searchedBook = Console.ReadLine();
            string bookName = Console.ReadLine();
            int bookNum = 0;
            bool isFound = false;
            while (bookName != "No More Books")
            {
                if (bookName == searchedBook)
                {
                    isFound = true;
                    break;
                }
                bookName = Console.ReadLine();
                bookNum++;
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {bookNum} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookNum} books.");
            }
        }
    }
}