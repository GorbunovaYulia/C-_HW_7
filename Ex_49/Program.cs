/*
49. Двумерный массив. Найдите элементы к оторых оба индекса четные и замените эти элементы на их квадраты.
*/

/*
Задача 48. Двумерный массив
Каждый элемент в массиве находится по формуле А=м*н
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

int[,] get2intArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish+1);
        }
    }
    return array;
}

void print2DArray(int[,] array)
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

int[,] findChetnue(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i=i+2)
    {
        for(int j = 2; j < array.GetLength(1); j=j+2)
        {
            array[i, j] =  array[i, j]* array[i, j];
        }
    }
    return array;
}

int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int[,] array = get2intArray(n, m, 0, 100);
print2DArray(array);
int[,] newarray=findChetnue(array);
print2DArray(newarray);

