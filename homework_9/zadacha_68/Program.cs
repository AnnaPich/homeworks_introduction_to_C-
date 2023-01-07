//Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

//Accerman function:

int AccermanResalt(int numberM, int numberN)
{
    if (numberM > 0 && numberN > 0)
    {
        return (AccermanResalt(numberM - 1, AccermanResalt(numberM, numberN - 1)));
    }
    if (numberM == 0 && numberN >= 0)
    {
       return (numberN + 1);      
    }
    if (numberN == 0 && numberM > 0)
    {
        return(AccermanResalt(numberM - 1, 1));
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
int numberM = DataEntyNumber("Введите положительное натуральное число m: ");
int numberN = DataEntyNumber("Введите положительное натуральное число n: ");

int resalt = AccermanResalt(numberM, numberN);
Console.Write(resalt);