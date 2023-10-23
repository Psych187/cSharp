/*Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/
Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(0, 1000);
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

int Sum(int[] array)
{
    int sum1 = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] <= 99)
        sum1++;
    }
     return sum1;
}
System.Console.WriteLine("Enter array size: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userSize);
PrintArray(userArray);
int userSum = Sum(userArray);
//PrintArray(userSum);
System.Console.WriteLine(userSum);