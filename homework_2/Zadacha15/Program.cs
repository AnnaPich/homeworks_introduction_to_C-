//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Напишите цифру, обозначающую день недели: ");
int numberDay = int.Parse(Console.ReadLine());

if(numberDay == 6 || numberDay == 7)
{
    Console.Write($"День {numberDay} -> выходной");
}
else
{
    Console.Write($"День {numberDay} -> рабочий день");
}