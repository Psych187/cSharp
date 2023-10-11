// Программа, проверяющая, является ли одно введенное число квадратом второго
System.Console.WriteLine("Enter two numbers: ");
int user_num_1 = Convert.ToInt32(Console.ReadLine());
int user_num_2 = Convert.ToInt32(Console.ReadLine());

if (user_num_1 / user_num_2 == user_num_2)
{
    System.Console.WriteLine("First number is a square of second one");
}
else {
    System.Console.WriteLine("First number is not a square of second one");
}