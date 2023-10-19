/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе*/
Console.Clear();

System.Console.WriteLine("Enter number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int SummNumbers(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /= 10)
    {
        result = i + result % 10;
    }
    return result;
}
int userResult = SummNumbers(userNum);
System.Console.WriteLine($"{userNum} -> {userResult}");