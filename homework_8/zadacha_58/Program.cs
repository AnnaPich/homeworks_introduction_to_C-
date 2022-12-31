//Задача 58: 
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//Метод, умножающий матрицу 1 на матрицу 2:
void MultMatrixs(int[,] arr1, int[,] arr2)
{
    int[,] resultArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    int result = 0;

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int k = 0; k < arr2.GetLength(1); k++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                result = result + arr1[i, j] * arr2[j, k];
                
            }
            resultArray[i, k] = result;
            result = 0;
            Console.Write("[" + resultArray[i, k] + "] ");
        }
        Console.WriteLine();
    }
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
int rightRange = 5;
int rows1 = 2;
int columns = 3;
int columns2 = 3;

int[,] matrix1 = FillArrayWithRandomNumbers(rows1, columns, leftRange, rightRange);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = FillArrayWithRandomNumbers(columns, columns2, leftRange, rightRange);
PrintMatrix(matrix2);
Console.WriteLine();
MultMatrixs(matrix1, matrix2);