/*Программа. которая по заданному номеру четверти показывает диапазон 
возможных координат точек этой четверти*/
System.Console.WriteLine("Enter quarter number: ");
int userQuarter = Convert.ToInt32(Console.ReadLine());

if (userQuarter == 1)
{
    System.Console.WriteLine("All of x and y greater than 0");
}
if (userQuarter == 2)
{
    System.Console.WriteLine("All of x less than 0 and y greater than 0");
}
if (userQuarter == 3)
{
    System.Console.WriteLine("All of x and y less than 0");
}
if (userQuarter == 4)
{
    System.Console.WriteLine("All of y less than 0 and x greater than 0");
}
else
System.Console.WriteLine("quarter does not exist");