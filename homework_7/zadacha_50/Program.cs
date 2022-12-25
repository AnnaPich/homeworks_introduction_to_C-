//Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


//Проверка элемента:
void CheckElementArray(int[,] array, int numberrow, int numbercolumn)
{
    bool count = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == numberrow - 1 && j == numbercolumn - 1)
            {
                count = true;
                Console.Write($"Элемент [{numberrow}, {numbercolumn}] -> " + array[i, j]);
            }
        }
    }
    if (count == false) Console.Write($"Элемента [{numberrow}, {numbercolumn}] в данной матрице нет");
}

//Прием чисел от пользователя:
int DataEntyNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
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
Console.Clear();
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;
int rows = 5;
int columns = 7;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, LEFT_RANGE, RIGHT_RANGE);

PrintMatrix(matrix);

int numberrow = DataEntyNumber("Введите номер строки: ");
int numbercolumn = DataEntyNumber("Введите номер столбца: ");

CheckElementArray(matrix, numberrow, numbercolumn);