/*Напишите программу, которая принимает на вход координаты точки (x&y) 
и выдает номер четверти плоскости*/
System.Console.WriteLine("Enter x: ");
int userX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter y: ");
int userY = Convert.ToInt32(Console.ReadLine());

if (userX > 0 && userY > 0)
{
    System.Console.WriteLine("it is first quarter");
}
if (userX < 0 && userY > 0)
{
    System.Console.WriteLine("it is second quarter");
}
if (userX < 0 && userY < 0)
{
    System.Console.WriteLine("it is third quarter");
}
if (userX > 0 && userY < 0)
{
    System.Console.WriteLine("it is fourth quarter");
}
if (userX == 0 || userY == 0)
{
    System.Console.WriteLine("it is axis");
}
