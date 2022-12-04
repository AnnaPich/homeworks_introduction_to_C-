//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Clear();

int number = new Random().Next(0, 1000000000);

if(number < 100)
{
    Console.Write($"{number} -> третий цифры нет");
}

int originalNumber = number;
if(number > 99)
{
    while(number > 999)
    {
        number = number/10;
    }
    int thirdDigit = number % 10;
    Console.Write($"{originalNumber} -> {thirdDigit}");
}
