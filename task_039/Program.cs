/*
   Задача 39: Напишите программу, которая перевернёт одномерный массив 
   (последний элемент будет на первом месте, а первый - на последнем и т.д.)
    [1 2 3 4 5] -> [5 4 3 2 1]
    [6 7 3 6] -> [6 3 7 6] 
*/

Console.Clear();

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
int[] reversArray = ReversArray(array);
PrintArray(array, reversArray);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] ReversArray(int[] array)
{
    int index = array.Length -1;
    int[] reversArray = new int[array.Length]; 

    for (int i = 0; i < reversArray.Length; i++)
    {
        reversArray[i] = array[index];
        index--;
    }
    return reversArray;
}

void PrintArray(int[] array, int[] reversArray)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i == array.Length -1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");

    Console.Write(" -> ");

    Console.Write("[ ");
    for (int i = 0; i < reversArray.Length; i++)
    { 
        if (i == reversArray.Length -1) Console.Write($"{reversArray[i]} ");
        else Console.Write($"{reversArray[i]}, ");
    }
    Console.WriteLine("]");
    Console.ResetColor();
}