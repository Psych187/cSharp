// Программа, принимающая на вход одно число N, а на выходе показывает все числа промежутка -N..N
System.Console.WriteLine("Enter number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int start = numberA * -1;
while (start <= numberA)
{
    Console.Write(start + " ");
    start = start + 1;
}
