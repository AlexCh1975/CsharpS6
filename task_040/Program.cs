/*
    Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
    может ли существовать треугольник с сторонами такой длины.
*/

Console.Clear();

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int result = IsTriangle(a, b, c);
PrintResult(result);

int IsTriangle(int a, int b, int c)
{
    if (a + b > c && c + a > b && c + b > a)
    {
        return 1;
    }
    else return 0;
}

void PrintResult(int result)
{
    Console.ForegroundColor = ConsoleColor.Green;
    if (result == 1) Console.WriteLine("Да, может существовать треугольник!");
    else Console.WriteLine("Нет, не может существовать треугольник!");
    Console.ResetColor();
}