﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
Console.Clear();


//метод печати масива:
void PrintMatrix(double[,] array)
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

//метод заполнения массива вещественными числами:
double[,] FillArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRang)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRang + 1) + new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}

//Прием чисел от пользователя:

int DataEntyNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//программа:

const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int rows = DataEntyNumber("Введите число строк m:");
int columns = DataEntyNumber("Введите число столбцов n: ");

double[,] matrix = FillArrayWithRandomNumbers(rows, columns, LEFT_RANGE, RIGHT_RANGE);

PrintMatrix(matrix);