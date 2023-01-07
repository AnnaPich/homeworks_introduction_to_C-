//Задача 66: 
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNumbers(int numberM, int numberN)
{
    if (numberM <= numberN)
    {
    return (PrintNumbers(numberM + 1, numberN) + numberM);
    }
    return 0;
}

//Receiving a namber from the user:
int DataEntyNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Program:
int numberM = DataEntyNumber("Введите число M: ");
int numberN = DataEntyNumber("Введите число N: ");

if (numberN > numberM)
{
   int result = SumNumbers(numberM, numberN);
   Console.Write(result);
}
else Console.WriteLine("Ошибка! Число N должно быть больше числа M");
