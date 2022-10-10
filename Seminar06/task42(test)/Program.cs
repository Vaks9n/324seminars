// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int number1 = number % 2;
    sum = sum * 10 + number1;
    number = number / 2;
}

Console.WriteLine(sum);