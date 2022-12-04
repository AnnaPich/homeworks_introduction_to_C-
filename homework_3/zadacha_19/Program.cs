//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();


//метод проверки числа:
void CheckNumer (int quantity)
{
    int originQuantity = quantity;
    int digitEnd = quantity % 10;
    int digitOne = quantity / 10000;
    if(digitEnd != digitOne) Console.WriteLine ($"Число {originQuantity} -> не полиндром");
    else 
    {
        quantity = ((quantity - digitOne * 10000)/10);
        int digitFourth = quantity % 10;
        int digitSecond = quantity / 100;      
    if(digitFourth != digitSecond) Console.WriteLine ($"Число {originQuantity} -> не полиндром");
    else
    {Console.WriteLine ($"Число {originQuantity} -> полиндром");}
    }
}
//if(digitEnd != digitOne) Console.WriteLine ($"Число {quantity} -> не полиндром");
//double digitThird = (quantity - digitOne * Math.Pow(10, count))/10
//double digitOne = quantity / Math.Pow (10, count);

//метод приема данных:
int DataEntry (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Программа

int quantity = DataEntry("Введите пятизначное число: ");
if(quantity < 10000 || quantity > 99999) Console.WriteLine($"Число {quantity} не является пятизначным");
else
{CheckNumer(quantity);}