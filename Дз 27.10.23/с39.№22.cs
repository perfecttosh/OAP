Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнюю цифру числа: ");
int b = Convert.ToInt32(Console.ReadLine());

double a;
double number;
double summa = 0;
for (int i = 1; i <= N; i++)
{
    a = Convert.ToDouble(Console.ReadLine());
    number = a % 10;
    if(number==b)
    {
        summa += a;
    }    
}
Console.WriteLine($"Сумма последовательности по цифре равна: {summa}");
