/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/

Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

Console.WriteLine("Введите номер строки искомого элемента массива:");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца искомого элемента массива:");
int columnNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int result = GetItem(array, rowNumber, columnNumber);

if(result >= 0)
    {
        Console.WriteLine($"Элемент с индексом ({rowNumber},{columnNumber}) равен {array[rowNumber,columnNumber]}");
    }
    else
    {
        Console.WriteLine($"Элемента с индексом ({rowNumber},{columnNumber}) в массиве не существует");
    }


int [,] GetArray(int rows, int columns, int min, int max)
{
    int [,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result [i,j] = new Random().Next(min,max);
        }
    }
    return result;
}


void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int GetItem (int[,] array, int rowNumber, int columnNumber)
{
    int result = 0;
    if(rowNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
    {
        result = array[rowNumber,columnNumber];
    }
    else
    {
        result = -1;
    }
    return result;
}