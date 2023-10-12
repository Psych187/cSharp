// Программа поиска наибольшего из двух чисел
System.Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"First number `{number1}` is bigger than the second one `{number2}`");
}
else if (number1 < number2) {
    Console.WriteLine($"First number `{number1}` is smaller than the second one `{number2}`");
}
else if (number1 == number2) {
    Console.WriteLine($"First number `{number1}` is equal to the second one `{number2}`");
}