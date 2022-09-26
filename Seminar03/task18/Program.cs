// 18 Напишите программу, которая по заданному номеру четверти показывает диапазон
// возможных координат;

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Диапазон x > 0 или y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Диапазон x < 0 или y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Диапазон x < 0 или y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Диапазон x > 0 или y < 0");
}
else 
{
    Console.WriteLine("Ввелие неверное значение");
}