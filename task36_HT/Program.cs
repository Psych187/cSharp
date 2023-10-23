﻿/*Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве 
целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает 
сумму элементов с нечетными индексами в массиве.
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
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Enter massive: ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
        System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Sum of odd elements: {SumOddElements(arrayOne)}");
}
int length = Promt("Array length: ");
int min = Promt("Array min: ");
int max = Promt("Array max: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);