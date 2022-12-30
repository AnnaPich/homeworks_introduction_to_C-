//Задача 56: 
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//метод поиска наименьшей суммы элементов строки:
void SumElementsRow(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    int indexMin = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumRow[i] = sum;
        sum = 0;
    }
    int sumMin = sumRow[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumRow[i] < sumMin)
        {
            sumMin = sumRow[i];
            indexMin = i;
        }
    }
Console.WriteLine('[' + string.Join(", ", sumRow) + ']');
Console.WriteLine(sumMin);
Console.WriteLine($"Строка {indexMin + 1} имеет наименьшую сумму элементов");
}

//метод печати маcсива:
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//метод заполнения массива:
int[,] FillArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

//программа:

int leftRange = 0;
int rightRange = 10;
int rows = 4;
int columns = 5;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, leftRange, rightRange);
PrintMatrix(matrix);
Console.WriteLine();
SumElementsRow(matrix);