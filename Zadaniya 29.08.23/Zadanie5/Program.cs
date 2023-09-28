//Задача номер 5 с.28
Console.WriteLine("Веддите число, которое хотите поменять на месяц:");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 | x > 12)
    Console.WriteLine("Введено не то число. Попробуйте еще раз");

switch (x)
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Февраль");
        break;
    case 3:
        Console.WriteLine("Март");
        break;
    case 4:
        Console.WriteLine("Апрель");
        break;
    case 5:
        Console.WriteLine("Май");
        break;
    case 6:
        Console.WriteLine("Июнь");
        break;
    case 7:
        Console.WriteLine("Июль");
        break;
    case 8:
        Console.WriteLine("Август");
        break;
    case 9:
        Console.WriteLine("Сентябрь");
        break;
    case 10:
        Console.WriteLine("Октябрь");
        break;
    case 11:
        Console.WriteLine("Ноябрь");
        break;
    case 12:
        Console.WriteLine("Декабрь");
        break;
}