// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine()??"";
    return res;
}

Console.Clear();
double x1 = double.Parse(Prompt("Введите X1: "));
double y1 = double.Parse(Prompt("Введите Y1: "));
double z1 = double.Parse(Prompt("Введите Z1: "));
double x2 = double.Parse(Prompt("Введите X2: "));
double y2 = double.Parse(Prompt("Введите Y2: "));
double z2 = double.Parse(Prompt("Введите Z2: "));

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"d={d:f2}");