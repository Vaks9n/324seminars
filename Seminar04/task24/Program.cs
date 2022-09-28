// 24 Напишите программу которая на вход число (А) и выдает сумму чисел от 1 до А
// 7 - 28
// 4 - 10
// 8 - 36

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
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i; // копим сумму
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
Console.WriteLine($"Сумма  элементов от 1 до А = {summa}");