Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());

int p = 1;

Console.WriteLine("Введите элементы последовательности");
for (int i = 0; i < n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    p *= Math.Abs(a);
}
Console.WriteLine($"Произведение модулей элементов = {p}");