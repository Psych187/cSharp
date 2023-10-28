/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:     
1 4 7 2     [1] и [7] -> такого числа по  индексу в массиве нет
5 9 2 3
8 4 2 4*/ 
Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetIndex2DArray(int row, int column, int k)
{
    int[,] array = new int[row, column];
    int num = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = num;
            num = num + k;
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
        System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayRow = TakeEnteredNumber("Rows amount:");
int userArrayColumn = TakeEnteredNumber("Columns amount:");
int numberK = TakeEnteredNumber("What number to encrese? ");
int[,] user2DIndexArray = GetIndex2DArray(userArrayRow, userArrayColumn, numberK);

Print2DArray(user2DIndexArray);
int PositionX = TakeEnteredNumber("Which row to find: ");
int PositionY = TakeEnteredNumber("Which column to find: ");

void FindElemnetInArray(int[,] array, int x, int y)
{
    if(x < array.GetLength(0) && y < array.GetLength(1))
    System.Console.WriteLine($"Array consist such number, it is {array[x, y]}");
    else
    System.Console.WriteLine("Array has not such number");
}
FindElemnetInArray(user2DIndexArray, PositionX, PositionY);