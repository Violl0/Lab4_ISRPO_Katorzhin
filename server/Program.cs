using System.Collections;
Console.WriteLine("пр!");
Console.WriteLine("1 — Показать ФИО");
Console.WriteLine("2 — Показать группу");
Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");
int a = int.Parse(Console.ReadLine());
switch (a){
    case 1:
        Console.WriteLine("Каторжин Максим Вячеславович");
        break;
    case 2:
        Console.WriteLine("ИСП-241");
        break;
    case 3:
        Console.WriteLine("24.09 9:21");
        break;
    case 4:
        break;
}

