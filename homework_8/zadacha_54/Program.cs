//Задача 54: 
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxElement = array[i, 0];
        int indexmax = 0;
        for (int n = 0; n < array.GetLength(1) - 1; n++)
        {
            for (int j = n; j < array.GetLength(1); j++)
            {
                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    array[i, j] = array[i, indexmax];
                    array[i, indexmax] = maxElement;
                }
            maxElement = array[i, n];    
            indexmax = n;
            }         
        }
    }
    return array;
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

int leftRange = 10;
int rightRange = 100;
int rows = 4;
int columns = 8;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, leftRange, rightRange);
PrintMatrix(matrix);
Console.WriteLine();
int[,] sortMatrix = SortArray(matrix);
PrintMatrix(sortMatrix);
