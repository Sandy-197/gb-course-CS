//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// int a = new Random().Next(2)

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "0";
    return res;
}

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

void PrintArray(int[] collection)
{
    foreach (var el in collection)
        Console.Write($"{el} ");
}

Console.Clear();
int count = int.Parse(Prompt("Введите кол-во элементов массива: "));
int min = int.Parse(Prompt("Введите минимальное значене элемента массив: "));
int max = int.Parse(Prompt("Введите максимальное значене элемента массив: "));
int[] arr = FillArray(count, min, max);
PrintArray(arr);