// принимает на вход два числа и проверяет, является ли одно число квадратом другого
System.Console.WriteLine("Enter number1: "); 
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number2: "); 
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    System.Console.WriteLine($"Number `{number1}` is a square of number `{number2}`");
}
if (number2 == number1 * number1)
{
    System.Console.WriteLine($"Number `{number2}` is a square of number `{number1}`");
}
else 
System.Console.WriteLine("There is no square");

/*
if (number1 == number2 * number2 || number2 == number1 * number1)
{
    System.Console.WriteLine($"One number is a square of second one");}
else 
System.Console.WriteLine("There is no square");
*/