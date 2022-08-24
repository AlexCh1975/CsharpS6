/*
    Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    45 -> 101101
    3  -> 11
    2  -> 10
*/

//Console.Clear();

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetCalcDivisionNumber(number);

void GetCalcDivisionNumber(int number)
{
    int i = 0;
    var binaryNumber = new List<int>();

    Console.ForegroundColor = ConsoleColor.Green;
   
    for (int num = number; number >= 1; i++ )
    {  
        num = number % 2;
        number = number / 2;
        binaryNumber.Add(num);
    }
    
    for (int index = binaryNumber.Count -1; index >= 0; index--)
    {
        Console.Write($"{binaryNumber[index]} ");
    }
    Console.WriteLine();
    Console.ResetColor();
}

