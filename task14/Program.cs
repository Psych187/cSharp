// Принимает на вход число и проверяет кратность 7 и 23
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("multiple");
}
else {
    System.Console.WriteLine("not multiple");
}