int GetSum(int N)
{
    int sum = 0;
    while N <
    for (int i=0; i<=N; i++)
    {
        sum = sum + N % 10;
        N /=10;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел в числе {N} равна {GetSum(N)}");