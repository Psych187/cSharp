// принимает на вход пятизначное число number и проверяет, является ли оно палиндромом
Console.Clear();

System.Console.WriteLine("Enter 5-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n3 = n / 10 % 10;
int n4 = n % 10;

if (n >= 10000 & n <= 99999)
{
    if (n1 == n4 && n2 == n3)
    {
        System.Console.WriteLine("yes");
    }
    else
        System.Console.WriteLine("no");
}
else
    System.Console.WriteLine("not 5-digit number");
