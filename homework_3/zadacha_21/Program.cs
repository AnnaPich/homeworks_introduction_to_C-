//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Метод поиска расстояния:

void FindDistanceAB(int x1, int y1, int z1, int x2, int y2, int z2)
{
	double distanceAB = Math.Sqrt(Math.Pow ((x2-x1), 2) + Math.Pow ((y2-y1), 2) + Math.Pow ((z2-z1), 2));
	Console.WriteLine($"Расстояние между точками А({x1};{y1};{z1}) и В({x2};{y2};{z2}) -> {distanceAB}");
}

//Метод приема данных от пользователя:
int DataEntryXYZ (string str)
{
	Console.Write(str);
	int coordinate = int.Parse (Console.ReadLine());
	return coordinate;
}

//Программа:

int x1 = DataEntryXYZ("Введите координату x1: ");
int y1 = DataEntryXYZ("Введите координату y1: ");
int z1 = DataEntryXYZ("Введите координату z1: ");

int x2 = DataEntryXYZ("Введите координату x2: ");
int y2 = DataEntryXYZ("Введите координату y2: ");
int z2 = DataEntryXYZ("Введите координату z2: ");

FindDistanceAB(x1, y1, z1, x2, y2, z2);

