// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
System.Console.WriteLine("Enter 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000) {
    Console.WriteLine("Error. Number does not match condition");
}
else {
    int first = number % 100;
int second = first / 10;
System.Console.Write(second);
}
