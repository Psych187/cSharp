/*Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины.*/
Console.Clear();

Console.WriteLine("Enter triangle sides:");
Console.Write("Side A: ");
double sideA = double.Parse(Console.ReadLine());

Console.Write("Side B: ");
double sideB = double.Parse(Console.ReadLine());

Console.Write("Side C: ");
double sideC = double.Parse(Console.ReadLine());

bool isTriangle = IsTriangle(sideA, sideB, sideC);
{
    if (isTriangle)
        {
            Console.WriteLine("Triangle exists");
        }
        else
        {
            Console.WriteLine("Triangle does not exist");
        }
}
bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }