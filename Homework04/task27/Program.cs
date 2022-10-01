// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
int sum = 0;
for (int i = -10; i < number; i++)
{
    reverse = number % 10;
    number = number / 10;
    sum = sum + reverse;
}

Console.WriteLine(sum);