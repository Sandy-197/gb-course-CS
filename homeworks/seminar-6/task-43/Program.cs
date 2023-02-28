// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// (k2-k1)/(b1-b2)

int X = 0;
int Y = 1;
int K = 0;
int B = 1;


string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}
double?[] GetCrossCoordinate(double k1, double b1, double k2, double b2)
{
    double?[] res = new double?[2];
    if (k1 == k2)
    {
        if (b1 == b2)
        { res[X] = null; }// Прямые совпадают
        else
        { res[X] = null; }// Прямые паралельны. Точек пересечения нет.
    }
    else
    {
        res[X] = (b1 - b2) / (k2 - k1);
        res[Y] = k1 * res[X] + b1;
    }
    return res;
}

double?[] GetCrossCoordinate2(double[] first, double[] second)
{
    double?[] res = new double?[2];
    if (first[K] == second[K])
    {
        if (first[B] == second[B])
        { res[X] = null; }// Прямые совпадают
        else
        { res[X] = null; }// Прямые паралельны. Точек пересечения нет.
    }
    else
    {
        res[X] = (first[B] - second[B]) / (second[K] - first[K]);
        res[Y] = first[K] * res[X] + first[B];
    }
    return res;
}

// double k1 = double.Parse(Prompt("Введите первый коэфициент K1: "));
// double b1 = double.Parse(Prompt("Введите свободный член B1: "));

// double k2 = double.Parse(Prompt("Введите первый коэфициент K2: "));
// double b2 = double.Parse(Prompt("Введите свободный член B2: "));
//string s = Prompt("Введите первое линейное уравнение вида y=kx+b -> у=");

double[] firstLine = Prompt("Введите первое линейное уравнение вида y=kx+b -> у=")
                    .ToLower()
                    .Split("x")
                    .Select(item => double.Parse(item))
                    .ToArray();
double[] secondLine = Prompt("Введите второе линейное уравнение вида y=kx+b -> у=")
                    .ToLower()
                    .Split("x")
                    .Select(item => double.Parse(item))
                    .ToArray();

// double?[] crossCoordinate = GetCrossCoordinate(k1, b1, k2, b2);
double?[] crossCoordinate = GetCrossCoordinate2(firstLine, secondLine);
// Console.WriteLine($"({GetCrossCoordinate(k1,b1,k2,b2)[0]}. {GetCrossCoordinate(k1,b1,k2,b2)[1]})");

// if (crossCoordinate[0] != null)
// {
//     Console.WriteLine($"({GetCrossCoordinate(k1, b1, k2, b2)[0]}. {GetCrossCoordinate(k1, b1, k2, b2)[1]})");
// }
// else
// {
//     Console.WriteLine("Прямые паралельны.");
// }

if (crossCoordinate[X] != null)
{
    Console.WriteLine($"({crossCoordinate[X]}, {crossCoordinate[Y]})");
}
else
{
    Console.WriteLine("Прямые паралельны.");
}