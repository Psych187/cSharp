/*Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
Console.Clear();

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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

int[] ProductArray(int[] pArr)
{

    int[] result = new int[pArr.Length / 2]; 
    int mult = 0;
    for (int i = 0; i < pArr.Length / 2; i++)
        {
        mult = pArr[i] * pArr[pArr.Length - 1 - i];
        result[i] = mult;
        } 
        return result;
}
    

int[] userArray = GetRandArray(6);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);