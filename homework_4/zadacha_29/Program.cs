//Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


void PrintArray(int[] col)
{
    int count = col.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(col[i] + ", ");
    }
}

//Метод, задающий массив:
int [] NewArray(int [] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

//Программа:

int [] array = new int [8];
NewArray(array);
PrintArray(array);
//Console.Write($"-> [{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");
string s = String.Join(", ", array);
Console.WriteLine($"-> [{s}]");