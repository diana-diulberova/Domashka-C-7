/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);


double [,] GetArray(int rows, int columns, int min, int max)
{
    double [,] result = new double [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            double realNumber;
            Random digit = new Random();
            realNumber = digit.NextDouble();
            result[i,j] = new Random().Next(min, max) + realNumber;
            result[i,j] = Math.Round(result[i,j], 2);
        }
    }
    return result;
}


void PrintArray(double [,] array)
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