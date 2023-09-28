Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите оценку:");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 1 | x > 5)
    Console.WriteLine("Попробуйте еще раз.");

switch (x)
{
    case 1:
        Console.WriteLine("Плохо");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 5:
        Console.WriteLine("Отлично");
        break;
}