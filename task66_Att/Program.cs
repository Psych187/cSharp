// 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

System.Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter last number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sumNum(int first, int last)
{
    if (last >= first) 
       return (last + sumNum(first, last - 1));
       else return 0;
}

int result = sumNum(number1, number2);
System.Console.WriteLine(result);