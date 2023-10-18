/*Принимает на вход число и выдает таблицу квадратов чисел 1..N*/
Console.Clear();
System.Console.Write("Enter number: ");
int userNum = int.Parse(Console.ReadLine());

for (int i = 1; i <= userNum; i++)
{
    System.Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)}");
}