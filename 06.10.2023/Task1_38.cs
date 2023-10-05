Console.WriteLine("Введите длину последовательности:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int q = 0;


Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    q = q + a;
}

Console.WriteLine($"Сумма:{q}");