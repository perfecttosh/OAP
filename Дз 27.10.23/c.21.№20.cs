Console.WriteLine("Введите координаты (m,n):");
double m = Convert.ToInt32(Console.ReadLine());
double n = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение c:");
int c = Convert.ToInt32(Console.ReadLine());

double y = a * Math.Pow(m,2) + b * m + c;

if (y == n)
{ Console.WriteLine("Принадлежит фунцкии"); }
else{ Console.WriteLine("Не принадлежит функции"); }

