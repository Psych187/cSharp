/*
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/
Console.Clear();
int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

//int Conv(int number)
//{
//    int result = 0;
//    int tmp = 0;
//    for (int i = number; i > 0; i /= 2)
//   {
//       tmp = i % 2;
//      result = tmp + result * 10;
//    }
//   return result;
//}
string Conv(int number)
{
    string result = "";
    int tmp = 0;
    for (int i = number; i > 0; i /= 2)
    {
        tmp = i % 2;
        result = tmp + result;
    }
    return result;
}
int uNum = UserInOut("Enter number: ");
System.Console.WriteLine(Conv(uNum));