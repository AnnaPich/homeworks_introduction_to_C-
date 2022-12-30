//Задача 62. 
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


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
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int count = rows + columns;
    int positionRows = 0;
    int positionColumns = 0;
    int temp = 10;
    bool leftRight = true;
    bool upDown = true;

    for (int n = 0; n <= count; n++)
    {
        if (leftRight == true)
        {
            for (int j = positionColumns; j < columns; j++)
            {
                if (array[positionRows, j] == 0)
                {
                    array[positionRows, j] = temp + 1;
                    temp = array[positionRows, j];
                    positionColumns = j;
                }
            }
            leftRight = false;
            n++;
            if (upDown == true)
            {
                for (int i = positionRows; i < rows; i++)
                {
                    if (array[i, positionColumns] == 0)
                    {
                        array[i, positionColumns] = temp + 1;
                        temp = array[i, positionColumns];
                        positionRows = i;
                    }
                }
                upDown = false;
                n++;
            }
            if (leftRight == false)
            {
                for (int j = positionColumns; j >= 0; j--)
                {
                    if (array[positionRows, j] == 0)
                    {
                        array[positionRows, j] = temp + 1;
                        temp = array[positionRows, j];
                        positionColumns = j;
                    }
                }
                leftRight = true;
                n++;
            }
            if (upDown == false)
            {
                for (int i = positionRows; i >= 0; i--)
                {
                    if (array[i, positionColumns] == 0)
                    {
                        array[i, positionColumns] = temp + 1;
                        temp = array[i, positionColumns];
                        positionRows = i;
                    }
                }
                upDown = true;
                n++;
            }
        }
    }
    return array;
}

//программа:

int rows = 8;
int columns = 8;

int[,] matrix = FillArray(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();