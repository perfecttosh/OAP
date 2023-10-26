//x = cos1/sin1*cos1+cos2/sin1+sin2*...*cosN/sinN
Console.Write("Введите последовательность N: ");
int N = Convert.ToInt32(Console.ReadLine());
double x = 1;
for (int i = 1; i <= N; i++)
{
    x *= Math.Cos(i)/Math.Sin(i)+Math.Cos(i) / Math.Sin(i);
}
Console.WriteLine($"Выражение равно: {x}");
