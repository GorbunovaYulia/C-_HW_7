/*
Задача 46.Двумерный массив MxN заполненный случайными числами 
*/

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
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
    int subscriber = 100;
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start * subscriber, (finish + 1) * subscriber) / (subscriber + 0.0);
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
double[,] array = get2DoubleArray(n, m, 0, 1000);
print2DArray(array);
