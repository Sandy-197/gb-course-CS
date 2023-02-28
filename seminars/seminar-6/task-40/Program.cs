// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.

bool IsTriangle(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (c + b > a);
}

int a = 3;
int b = 4;
int c = 5;
Console.WriteLine(IsTriangle(a, b, c) ? "Yes" : "No");