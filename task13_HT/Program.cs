// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i >= 100; i = i / 10)
{
    result = i % 10;
}
if (number < 100)
{
    System.Console.WriteLine("No third digit");
}
else { System.Console.WriteLine(result); }
