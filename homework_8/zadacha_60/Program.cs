//Задача 60. 
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)



//метод печати маcсива:
void PrintMatrix(int[, ,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }      
    }
}

//метод заполнения массива:
int[, ,]  FillArrayWithRandomNumbers(int x, int y, int z, int leftRange, int rightRange)
{
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(leftRange, rightRange);
            }            
        }
    }
    return array;
}

//программа:

int leftRange = 10;
int rightRange = 100;
int ordinate = 2;
int abscissa = 2;
int applicate = 2;

int[,,] array = FillArrayWithRandomNumbers(ordinate, abscissa, applicate, leftRange, rightRange);
PrintMatrix(array);
Console.WriteLine();
