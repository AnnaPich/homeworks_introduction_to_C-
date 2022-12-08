//Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


//Метод возведения числа А в степень B:
int ExpAinB(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

//Прием числа:
int DataEntryDigit (string str)
{
    Console.Write(str);
    int number = int.Parse (Console.ReadLine());
    return number;
}

//Программа:

int digitA = DataEntryDigit("Введите число А: ");
int digitB = DataEntryDigit("Введите число B: ");
int result = ExpAinB(digitA, digitB);
Console.Write($"Число {digitA} (А) в степни {digitB} (B) равно: {result}.");