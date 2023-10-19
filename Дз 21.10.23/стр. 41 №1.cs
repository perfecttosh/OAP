Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
double p = n % 10;
while (n > 0)
{
    n = n / 10;
    summ += n / 10;
}
Console.WriteLine(summ + p);