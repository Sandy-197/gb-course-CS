// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.WriteLine("введите число 1:");
//string s= Console.ReadLine();
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число 2:");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 * num1 == num2 || num2 * num2 == num1)
//      ИСТИНА          ИЛИ        ЛОЖЬ
{
    Console.WriteLine("да");  
}
else
{
    Console.WriteLine("нет");     
}
//