// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

int[,] CreateArray(int a, int b)
{
    Console.WriteLine("\nПервичный массив:");
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] SortedRowsArray(int[,] array)
{
    int row = 0;
    int[] singleArray = new int[array.GetLength(1)];
    while (row < array.GetLength(0))
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
            singleArray[columns] = array[row, columns];

        Array.Sort(singleArray);
        Array.Reverse(singleArray);

        for (int columns = 0; columns < array.GetLength(1); columns++)
            array[row, columns] = singleArray[columns];

        row++;
    }
    return array;
}

void PrintNewArray(int[,] matrix)
{
    Console.WriteLine("\nМассив после сортировки строк:");
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintNewArray(
    SortedRowsArray(
        CreateArray(4,4)));