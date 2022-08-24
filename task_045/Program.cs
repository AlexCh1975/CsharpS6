/*
    Задача 45: Напишите программу, которая будет создавать копию 
    заданного массива с помощью поэлементного копирования.
*/

Console.Clear();

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
int[] newArray = CreateNewArray(array);
PrintArray(array, newArray);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

    return array;
} 

int[] CreateNewArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray(int[] array, int[] newArray)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write("array:[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");

    Console.Write(" -> ");

    Console.Write("newArray: [ ");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == newArray.Length -1) Console.Write($"{newArray[i]} ");
        else Console.Write($"{newArray[i]}, ");
    }
    Console.WriteLine("]");

    Console.ResetColor();
}