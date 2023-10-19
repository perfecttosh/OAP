Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());

double summa = 0;

Console.WriteLine("Введите элементы последовательности");
for (int i = 0; i < n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    summa += Math.Pow(a, 2);
}
Console.WriteLine($"Сумма квадратов элементов = {summa}");