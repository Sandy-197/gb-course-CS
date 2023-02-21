// 26 Напишите программу,
// которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "0";
    return res;
}

int CountDigitInInt(int n) // подсчет кол-ва разрядов в числе, через математику. Так же можно через длину строки. но не так интересно.
{
    int count = 0;
    if (n < 0) { n *= -1; }
    while (n != 0)
    {
        count++;
        n /= 10;
    }
    return count;
}
Console.Clear();
int n = int.Parse(Prompt("Введите число N: "));
Console.WriteLine(CountDigitInInt(n));