// Напишите программу которая принимает на вход
// число N и выдает произведение чисел от 1 до N
// 4 - 24
// 5 - 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите число");


int SumNumbersFrom1toA(int a)
{
    if (a >= 1)
    {
        int sum = 1;
        for (int i = 1; i <= a; i++)
        {

            sum = sum  * i; // копим сумму
        }
        return sum; // вернем накопившуюся сумму
    }
    else 
    {
        Console.WriteLine("Число должно быть не меньше 1");
        return -1; //Некорректная сумма (код ошибки)
    }
}

int summa = SumNumbersFrom1toA(number);
Console.WriteLine($"Произведение  элементов от 1 до А = {summa}");