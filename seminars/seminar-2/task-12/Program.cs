// 12 Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.Clear();
Console.WriteLine("введите число 1:");

int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число 2:");
int num2 = int.Parse(Console.ReadLine()!);
//int num1 = new Random().Next(1,100);
//int num2 = new Random().Next(1,100);
int ost  = num1 % num2;
if (ost == 0)
{
    Console.WriteLine($"{num1}, {num2} -> кратно");   
}
else 
{
    Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {ost}"); 
}