Console.Write("Введите объем первого прямоугольного параллелепипеда: ");
double v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите объем второго прямоугольного параллелепипеда: ");
double v2 = Convert.ToDouble(Console.ReadLine());

if (v1 > v2)
{ 
    Console.WriteLine("Объем первого больше, чем объем второго");
}
else if (v1 < v2)
{
    Console.WriteLine("Объем второго больше, чем объем первого");
}
else
{
    Console.WriteLine("Объем первого и второго параллелепипеда равны");
}