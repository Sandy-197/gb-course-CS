// 23. Напишите программу, которая принимает на вход число а
// и выдает сумму чисел от 1 до а
// a = 5
// sum = 1+2+3+4+5

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "0";
    return res;
}

int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    return sum;
}

Console.Clear();
int n = int.Parse(Prompt("Введите число A: "));
Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");