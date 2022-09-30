// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// // Не использовать Math.Pow() и аналоги!

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberAB = numberA;

Console.WriteLine("Введите число Б: ");
int numberB = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numberB; i++)
{
    numberA = numberAB * numberA;
}
Console.WriteLine(numberA);

