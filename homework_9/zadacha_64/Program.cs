//Задача 64: 
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//Print numbers:
void PrintNumbers(int number)
{
    if (number == 0) return;
    Console.Write(number + ", ");
    PrintNumbers(number - 1);
}

//Receiving a namber from the user:
int DataEntyNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Program:
int number = DataEntyNumber("Введите число N:");
PrintNumbers(number);



