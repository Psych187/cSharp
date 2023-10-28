/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.*/
Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(double[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "\t");
    }
}

double[] GetAVGInArray(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array[j, i];
        }
        avgArray[i] = Math.Round(result / array.GetLength(0), 2);
    }
    return avgArray;
}

int userArrayRow = TakeEnteredNumber("Rows amount:");
int userArrayColumn = TakeEnteredNumber("Columns amount:");
int userArrayStart = TakeEnteredNumber("Diapazone starts:");
int userArrayEnd = TakeEnteredNumber("Diapazone ends:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine();
double[] resultArray = GetAVGInArray(user2DArray);
PrintArray(resultArray);