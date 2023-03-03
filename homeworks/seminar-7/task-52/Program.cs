// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
int ROW = 0;
int COLUMN = 1;
bool BY_COLUMN = true;
bool BY_ROW = false;

Clear();
int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество столбцов массива: "));

int[,] array = GetArray(m, n, 10, 99);

PrintTwoDemensionsArray(array);
WriteLine();
PrintArray(MeanValue(array, BY_ROW));

/* --- МЕТОДЫ ------------------------*/

int[] MeanValue(int[,] array, bool byColumn = true)
{
    int[] res;
    int i = 0;
    // int count = 0;
    // count = (byColumn) ? array.GetLength(COLUMN) : array.GetLength(ROW);
    // res = new int[count];

    res = (byColumn) ? new int[array.GetLength(COLUMN)] : new int[array.GetLength(ROW)];
    for (int r = 0; r < array.GetLength(ROW); r++)
    {
        for (int c = 0; c < array.GetLength(COLUMN); c++)
        {
            res[i] += array[r, c];
            if (byColumn) { i++; }
        }
        i = (byColumn) ? 0 : i + 1;
    }
    return res;
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,] GetArray(int row, int column, int minValue = 0, int maxValue = 0)
{
    int[,] result = new int[row, column];
    if (!(minValue == 0 && maxValue == 0))
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintTwoDemensionsArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(ROW); i++)
    {
        for (int j = 0; j < inArray.GetLength(COLUMN); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]} ");
    }
}