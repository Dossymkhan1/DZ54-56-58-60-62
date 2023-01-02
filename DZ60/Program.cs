// Задача 60: Сформируйте трехмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

int[] CreateArray(int a, int b, int c)
{
    Console.WriteLine("\nТрехмерный массив:\n");
    int[,,] matrix = new int[a, b, c];
    int[] checkArray = new int[a * b * c];
    int indexCheckArray = 0;
    int elem = 0;
    for (int depth = 0; depth < matrix.GetLength(2); depth++)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                while (true)
                {
                    bool check = true;
                    elem = new Random().Next(10, 99);
                    for (int i = 0; i < checkArray.Length; i++)
                    {
                        if (elem == checkArray[i]) check = false;
                    }
                    if (check == true)
                    {
                        matrix[row, column, depth] = elem;
                        Console.Write($"[r{row},c{column},d{depth}]={matrix[row, column, depth]}  ");
                        checkArray[indexCheckArray] = elem;
                        indexCheckArray++;
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
    }
    return checkArray;
}

void Check(int[] array)
{
    Console.WriteLine($"Проверочная матрица (набор всех использованных элементов в сорт виде):\n");
    Array.Sort(array);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


while (true)
{
Console.Clear();
Console.WriteLine();
Console.WriteLine("Введите габариты матрицы [Row, Column, Depth] (3 цифры без пробела):");
int sizeMatrix = int.Parse(Console.ReadLine()!);
int countAllElem = (sizeMatrix / 100) * (sizeMatrix / 10 % 10) * (sizeMatrix % 10);
if(countAllElem <= 90)
{
    Check(CreateArray(sizeMatrix / 100, sizeMatrix / 10 % 10, sizeMatrix % 10));
    break;
}
else
{
    Console.WriteLine("Максимальное кол-во неповторяющихся двузначных чисел = 90");
    Console.WriteLine($"Ваша матрица требует {countAllElem} чисел");
    Console.WriteLine($"Создать матрицу с необходимыми условиями невозможно.");
    Console.WriteLine($"Нажмите ВВОД и введите новые габариты.");
    Console.ReadKey();
}
}