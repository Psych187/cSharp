// Программа, выводящая день недели (название) при вводе пользователем цифры дня недели
System.Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber == 1) 
{
    System.Console.WriteLine("Monday");
}
if (userNumber == 2) 
{
    System.Console.WriteLine("Tuesday");
}
if (userNumber == 3)
{
    System.Console.WriteLine("Wednesday");
}
if (userNumber == 4) 
{
    System.Console.WriteLine("Thursday");
}
if (userNumber == 5) 
{
    System.Console.WriteLine("Friday");
}
if (userNumber == 6) 
{
    System.Console.WriteLine("Saturday");
}
if (userNumber == 7) 
{
    System.Console.WriteLine("Sunday");
}
else 
System.Console.WriteLine("There is no such day of the week");