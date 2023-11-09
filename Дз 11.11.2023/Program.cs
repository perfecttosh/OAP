//Перов №16 с.15
double x = Convert.ToInt32(Console.ReadLine());
double y = Convert.ToInt32(Console.ReadLine());
int R = 6;
double S = x * x + y * y;

if (x > 0 && y > 0)
{
    Console.WriteLine("False");
}
else if(S < R * R)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}