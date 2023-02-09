/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5     7       -2      -0,2
1       -3,3    8       -9,9
8       7,8     -7,1      9
*/

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

double[,] get2DoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = Math.Round(new Random().Next(start, finish + 1) + new Random().NextDouble(), 2);
        }
    }
    return array;
}

void print2DArray(double[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int start = GetDataFromUser("Введите нижний диапазон вещественных чисел");
int finish = GetDataFromUser("Введите верхний диапазон вещественных чисел");
double[,] array = get2DoubleArray(n, m, start, finish);
print2DArray(array);
