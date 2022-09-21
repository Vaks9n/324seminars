// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine(number);
int digit1 = number % 10; // Пример 85 % 10 = 5 Выводит правую часть
int digit2 = number / 10; // Пример 85 % 10 = 8 Выводит левую часть
Console.WriteLine(digit1);
Console.WriteLine(digit2);
if (digit1 > digit2) 
{
    Console.WriteLine("Первая цифра " + digit1 + " больше второй ");
}
else  if (digit2 > digit1)
{
    Console.WriteLine("Вторая цифра " + digit2 +  " больше первой ");
}
else
{
    Console.WriteLine("Цифры равны");
}