//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


//метод вычисления суммы определенных элементов массива:
void FindSumDigitArray(int[] arr, out int sum)
{
    sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum += arr[i];
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
const int LEFT_RANGE = -99;
const int RIGHT_RANGE = 99;

int[] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
FindSumDigitArray(array, out int sum);
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна: " + sum);