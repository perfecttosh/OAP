Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;

Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    summa += a;
}
Console.WriteLine($"Сумма элементво последовательности равна:{summa}");

