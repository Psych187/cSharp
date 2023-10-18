// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.Clear();

System.Console.WriteLine("Enter number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Number(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
        sum = sum * i;
    }
    return sum;
}
int userRes = Number(userNum);
System.Console.WriteLine(userRes);
