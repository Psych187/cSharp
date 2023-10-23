/*Напишите программу, которая подсчитывает количество четных элементов в массиве целых 
положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает массив целых 
положительных трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".*/
Console.Clear();

int Promt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Enter massive: ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if(i < arrayOne.Length - 1)
        System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Number of even elements: {CountEvenElements(arrayOne)}");
}
int length = Promt("Massive length: ");
int min = Promt("Rand number starter: ");
int max = Promt("Rand number ender: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);