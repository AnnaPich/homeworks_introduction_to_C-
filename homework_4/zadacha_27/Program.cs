//Задача 27: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Метод поиска суммы цифр введенного числа:
int SumDigit(int number)
{
    int sum = 0;
    for (int i = 0; number > 0; i++)
    {
       sum = sum + number%10;
       number = number/10; 
    }
    return sum;
}

//Прием числа:
int DataEntryNumber (string str)
{
    Console.Write(str);
    int number = int.Parse (Console.ReadLine());
    return number;
}

//Программа:

int number = DataEntryNumber("Введите число: ");
int result = SumDigit(number);
Console.Write($"Cумма цифр числа {number} равна: {result}.");
