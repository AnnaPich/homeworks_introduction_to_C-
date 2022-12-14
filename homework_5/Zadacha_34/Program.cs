//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//метод поиска четных чисел в массиве:
void FindNumber(int[] arr, out int count)
{
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count ++;
    }
}


//метод заполнения массива:
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRang)//размер, левая граница, правая граница
{
    Random rand = new Random();
    int[] arr = new int[size];//обозначаем пока пустой массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRang + 1);
    }
    return arr;
}


//Программа:

const int SIZE = 7;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

int[] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
FindNumber(array, out int count);

Console.WriteLine($"В данном массиве {count} четных чисел.");



