// Задача 10: Напишите программу, которая принимает на вход трёхз
// начное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100)
{
    Console.WriteLine("Ввели неверное число");
}
else
{
    int number1 = number / 10 % 10;
    Console.WriteLine(number1);

}

