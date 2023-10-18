// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
Console.Clear();
System.Console.WriteLine("enter number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Result(int number)
{
    int count = 0;
    for (int i = number; i > 0; i /= 10)
    {
        count = count + 1;
    }
    return count;
}
int userCount = Result(userNum);
System.Console.WriteLine(userCount);
