// Программа для определения наибольшего из трех чисел
System.Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) {
    max = number2;
}
if (number3 > max) {
    max = number3;
}
Console.WriteLine("Maximal number is " + max);