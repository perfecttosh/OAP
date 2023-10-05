Console.WriteLine("Введите длину последовательности:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
int q = 1;

Console.WriteLine("Введите числа последовательности:");
for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    q = q * a;
}
Console.WriteLine($"Произведение чисел:{q}");