/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.DarkGreen);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2intArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void print2DArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t", ConsoleColor.Cyan);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

string findSredArif(int[,] array)
{
    string result = string.Empty;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double SredArif = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SredArif = SredArif + array[i, j];
        }
        SredArif = Math.Round(((SredArif / array.GetLength(0)) + 0.0), 2);
        result = result + " \t" + SredArif;
    }

    return result;
}
int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int start = GetDataFromUser("Введите нижний диапазон чисел");
int finish = GetDataFromUser("Введите верхний диапазон чисел");
int[,] array = get2intArray(n, m, start, finish);
print2DArray(array);
string result = findSredArif(array);
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце:");
printInColor(result, ConsoleColor.Yellow);