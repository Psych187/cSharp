//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
//Console.Clear();

int[] GetArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

System.Console.WriteLine("Enter massive diapazone from: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter massive diapazone till: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter massive size: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);