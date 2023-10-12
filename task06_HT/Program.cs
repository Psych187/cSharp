// Проверка четности вводимого числа
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    System.Console.WriteLine($"Number `{number}` is even");
}
else 
System.Console.WriteLine($"Number `{number}` is not even");