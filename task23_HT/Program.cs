﻿/*принимает на вход число (N) и выводит таблицу 
кубов чисел от 1 до N (включительно) каждое на новой строке*/
Console.Clear();
System.Console.Write("Enter number: ");
int userNum = int.Parse(Console.ReadLine());

for (int i = 1; i <= userNum; i++)
{
    System.Console.WriteLine($"{Math.Pow(i, 3)}");
}