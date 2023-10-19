/*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
Console.Clear();
int[] GetRandArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if(i < arr.Length -1)
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

System.Console.WriteLine("Enter array size: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter array diapazone from: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter array diapazone till: ");
int userEnd = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("Enter number looking for: ");
int userNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(findNum(userArray,userNum));