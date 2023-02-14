Виктор Фурсенко 10:00
// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("введите число:");
int num = int.Parse(Console.ReadLine()!);


if(num % 7 == 0 && num % 23 == 0 )
{
 Console.WriteLine($"{num} кратно 7 и 23");   
}
else 
{
    Console.WriteLine($"{num} не кратно 7 и 23 "); 
}
// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("введите число:");
int num = int.Parse(Console.ReadLine()!);
int a1 = 7, a2 = 23;

if(num % a1 == 0 && num % a2 == 0 )
{
 Console.WriteLine($"{num} кратно {a1} и {a2}");   
}
else 
{
    Console.WriteLine($"{num} не кратно {a1} и {a2} "); 
}    

Console.WriteLine("вариант 2:");

if(num % (7*23)==0)
{
 Console.WriteLine($"{num} кратно 7 и 23");   
}
else 
{
    Console.WriteLine($"{num} не кратно 7 и 23 "); 
}