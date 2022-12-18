//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

//Метод подсчета положительных чисел:
int CountDigit(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

//Прием числа:
int DataEntryNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//программа:

System.Console.Write("Введите количество чисел: ");
int size = int.Parse(Console.ReadLine());
int [] arr =  new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = DataEntryNumber($"введите число {i}: ");
    }
Console.Write('[' + string.Join(", ", arr) + ']');
int result = CountDigit(arr);
Console.WriteLine($"-> {result} числа больше 0");