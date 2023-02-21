//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "0";
    return res;
}

int GetFactorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
       fact *= i;
    return fact;
}

Console.Clear();
int number = int.Parse (Prompt("Введите число: "));
Console.WriteLine ($"{number} -> {GetFactorial(number)}");