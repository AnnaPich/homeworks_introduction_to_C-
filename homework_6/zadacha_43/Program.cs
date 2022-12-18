//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//Прием числа:
int DataEntryNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//программа:

int k1 = DataEntryNumber($"введите угловой коэффициент k1: ");
int b1 = DataEntryNumber($"введите коэффициент b1: ");
int k2 = DataEntryNumber($"введите угловой коэффициент k2: ");
int b2 = DataEntryNumber($"введите коэффициент b2: ");

double x = Math.Round((double)(b2 - b1) / (k1 - k2), 2);
double y = Math.Round((k1 * x + b1), 2);
Console.WriteLine("координаты точки пересечения линий: -> (" + x + ";" + y + ')');
