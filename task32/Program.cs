/*Напишите программу замена элементов массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
Console.Clear();
int[] GetRandArray(int size, int start, int end)
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
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
System.Console.WriteLine("Enter array size: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter array diapazone from: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter array diapazone till: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandArray(userSize, userStart, userEnd);
PrintArray(userArray);

int[] Result(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}
//PrintArray(Result(userArray));
int[] userResult = Result(userArray);
PrintArray(userResult);