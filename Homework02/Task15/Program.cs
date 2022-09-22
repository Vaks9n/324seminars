// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");
}
if (number >= 1 && number <= 5)
{
    Console.WriteLine("Это не выходной день");
}
if (number > 7 || number < 1)
{
    Console.WriteLine("Число введено неверно");
}