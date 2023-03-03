// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

using System;
using static System.Console;
int ROW = 0;
int COLUMN = 1;

Clear();
int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество строк массива: "));
int r = int.Parse(Prompt("Введите номер строки массива для поиска: "));
int c = int.Parse(Prompt("Введите номер колонки массива для поиска: "));

int[,] array = GetArray(m, n, 10, 99);
PrintArray(array);
int? value = GetValueFromArray(r, c, array);
if (value != null)
{
    WriteLine($"Элемент на позиции [{r},{c}] = {GetValueFromArray(r, c, array)}");
}
else
{
    WriteLine($"Позиция [{r},{c}] отсутсвует. Индекс массива должен быть в пределах [0..{array.GetLength(ROW)-1},0..{array.GetLength(COLUMN)-1}]");
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

void PrintArray(int[,] inArray)
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

int? GetValueFromArray(int row, int column, int[,] array)
{
    return ((column < array.GetLength(COLUMN) && column >= 0) && (row < array.GetLength(ROW) && row >= 0)) ? array[row, column] : null;
}
