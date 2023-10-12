// Программа принимает на вход число и выводит все четные числа от 1 до этого числа включительно (если оно четное)
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i+=2)
{System.Console.Write(i + "\t");}