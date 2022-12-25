//Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();


void FindArithmeticMeanColumn(int[,] array)
{
    double[] newarray = new double[array.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        newarray[j] = Math.Round((double)sum / array.GetLength(0), 1);
        sum = 0;
    }
    Console.WriteLine(string.Join(", ", newarray));
}


//метод печати масива:
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
int[,] FillArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRang)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRang + 1);
        }
    }
    return array;
}

//программа:

const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;
int rows = 5;
int columns = 7;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, LEFT_RANGE, RIGHT_RANGE);

PrintMatrix(matrix);

Console.Write("Среднее арифметическое столбцов: ");

FindArithmeticMeanColumn(matrix);