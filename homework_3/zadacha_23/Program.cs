//Задача 23:
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125

//Метод поиска кубов:

void FindСubes(double N)
{
	double count = 1;
	while(count <= N)
	{
		double cube = Math.Pow(count, 3);
		Console.Write(cube + ", ");
		count++;
	}
}

//Метод приема данных от пользователя:
int DataEntryN (string str)
{
	Console.Write(str);
	int number = int.Parse (Console.ReadLine());
	return number;
}

//Программа:

int N = DataEntryN ("Введите число N: ");
Console.Write($"Кубы чисел от 1 до {N}: ");
FindСubes(N);
