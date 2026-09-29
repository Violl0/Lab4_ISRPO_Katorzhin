using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Каторжин Максим Вячеславович");
            Console.WriteLine("Группа: ИСП-241");
            Console.WriteLine("Дата: 29.09.2026");
            Console.WriteLine("1 - ФИО");
            Console.WriteLine("2 - Группа");
            Console.WriteLine("3 - Дата");
            Console.WriteLine("4 - Выход");
            Console.Write("Выбор: ");
            string choice = Console.ReadLine();
            if (choice == "1") Console.WriteLine("Каторжин Максим Вячеславович");
            else if (choice == "2") Console.WriteLine("ИСП-241");
            else if (choice == "3") Console.WriteLine("29.09.2026");
            else if (choice == "4") break;
        }
    }
}