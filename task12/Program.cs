// Принимает на вход два числа и проверяет, кратно ли торое число первому. Если не кратно - остаток от деления
System.Console.WriteLine("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number2 % number1;
if (number2 % number1 == 0)
{
    System.Console.WriteLine($"Number `{number2}` is multiple number `{number1}`");
}
else 
System.Console.WriteLine($"Number `{number2}` is not multiple number `{number1}`. The remainder is `{number3}`");