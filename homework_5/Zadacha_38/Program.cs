//Задача 38: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//метод вычисления разницы между максимальным и минимальным элементами массива:

void FindDiffMinMaxDigitArray(double[] arr, out double result)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    result = max - min;
}

//метод заполнения массива:
double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRang)//размер, левая граница, правая граница
{
    Random rand = new Random();
    double[] arr = new double[size];//обозначаем пока пустой массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRang + 1) + new Random().NextDouble();
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

//int n = array.Length;
//    for (int i = 0; i < n; i++)
//    {
//        array[i] = new Random().Next(2);
//    }
//    return array;
//

//Программа:

const int SIZE = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

double[] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
FindDiffMinMaxDigitArray(array, out double result);
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + result);