/*
    Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
    Первые два числа Фибоначчи: 0 и 1.
    Если N = 5 -> 0 1 1 2 3
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8
*/
//Console.Clear();

Console.Write("Введите число N Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
GetFibonacciNumbers(N);

void GetFibonacciNumbers(int N)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{N} -> ");
    int index;
    if (N > 0) 
    {
        int[] F = new int[N];

        for (int i = 0; i < F.Length; i++)
        { 
            if (i == 0) 
            {
                F[i] = 0; Console.Write($"{0} ");
            }
            else if (i == 1)
            {
                F[i] = 1; Console.Write($"{1} ");
            }
            else
            {
                F[i] = F[i - 1] + F[i - 2];
                Console.Write($"{F[i]} ");
            }  
        }
    }
    else 
    {
        index = N * -1;
        int[] F = new int[index];

        for (int i = 0; i < F.Length; i++)
        { 
            if (i == 0) 
            {
                F[i] = 0; Console.Write($"{0} ");
            }
            else if (i == 1)
            {
                F[i] = 1; Console.Write($"{1 * -1} ");
            }
            else
            {
                F[i] = F[i - 1] + F[i - 2];
                Console.Write($"{F[i] * -1} ");
            }  
        }
    }
    Console.WriteLine();
    Console.ResetColor();
}