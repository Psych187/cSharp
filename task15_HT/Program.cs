/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным*/
System.Console.WriteLine("Enter number of week day: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber <= 5 && userNumber > 0)
{ System.Console.WriteLine("It is work day"); }
if (userNumber == 7 || userNumber == 6)
{ System.Console.WriteLine("Weekend!"); }
else if (userNumber < 1 || userNumber > 7)
{ System.Console.WriteLine("No such day of week"); }