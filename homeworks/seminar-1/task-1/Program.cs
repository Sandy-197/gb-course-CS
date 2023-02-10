// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine() ?? "0");

if (first > second && first > third)
{ 
    Console.WriteLine("Максимальное число: " + first);
}
else if (second > third)
{
    Console.WriteLine("Максимальное число: " + second);
}
else 
{
    Console.WriteLine("Максимальное число: " + third);
}