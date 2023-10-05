Console.WriteLine("Введите длину последовательности:");
int x = Convert.ToInt32(Console.ReadLine());
int a = 0;
int kolvo = 0;

Console.WriteLine("Введите повторяющееся число");
int y = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < x; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a == y)
    {
        kolvo++;
    }
}
Console.WriteLine($"{kolvo}");