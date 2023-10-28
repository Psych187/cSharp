// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

/*
double[,] GetRandom2DArray(int deviation, int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round((new Random().NextDouble() * (2 * deviation) - deviation), 2);
        }
    }
    return array;
}
*/

double[,] GetRandom2DArray(int start, int end, int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()),2);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + array.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"["+ i +"]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int userArrayRow = TakeEnteredNumber("Rows amount:");
int userArrayColumn = TakeEnteredNumber("Columns amount:");
int userArrayStart = TakeEnteredNumber("Diapazone starts:");
int userArrayEnd = TakeEnteredNumber("Diapazone ends:");
double[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);