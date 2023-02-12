/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет
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

int[,] get2intArray(int start, int finish)
{
    int colLength = new Random().Next(2, 11);
    int rowLength = new Random().Next(2, 11);
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

int findNumber(int[,] array, int n, int m)
{
    int result = -1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==n && j==m)
            {
                result = array [i,j];
            }
        }
    }
    return result;
}

int start = GetDataFromUser("Введите нижний диапазон чисел");
int finish = GetDataFromUser("Введите верхний диапазон чисел");
int[,] array = get2intArray(start, finish);
print2DArray(array);
int n = GetDataFromUser("Введите номер строки");
int m = GetDataFromUser("Введите номер столбца");
int result = findNumber(array, n, m);
if (result==-1000)
{
    printInColor($"Числа на позиции [{n}, {m}] в массиве нет", ConsoleColor.Yellow);
}
else
{
    printInColor($"Число на позиции [{n}, {m}] в массиве = {result}", ConsoleColor.Yellow);
}
