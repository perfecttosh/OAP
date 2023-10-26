int N = 10;
double x = 1;

for (double i = 0.1; i <= N;i = i + 0.1)
{
    x = 1 + Math.Sin(i);
}
Console.WriteLine(x);