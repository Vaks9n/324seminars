// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

//Console.WriteLine("Введите первое число: ");
//int numberA = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите второе число: ");
//int numberB = Convert.ToInt32(Console.ReadLine());

//if (numberA => numberB)
//{
//    int square1 = numberA / numberB;
//    if (square1 = numberB)
//    {
//        Console.WriteLine("Первое число является квадратом второго");
//    }
//    else
//    {
//        Console.WriteLine("Первое число не явдяется квадратом второго");
//    }
//}
//else
//{
//    Console.WriteLine("Первое число не является квадратом второго");
//}

// Первая проба неудачного кода

// Вторая проба

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("Да, первое число квадрат второго");
}
else
{
    Console.WriteLine("Нет, первое число не квадрат второго");
}