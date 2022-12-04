//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Напишите трехзначное число: ");
int count = int.Parse(Console.ReadLine());

int number = (count / 10) % 10;

Console.Write($"{count} -> {number}");