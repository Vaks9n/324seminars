﻿// 17 Напишите программу которая принимает на вход 
// коородинаты точки (Х и Y), причем Х =/ 0 и Y =/ 0
// выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координату точки по Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x> 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");

}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else 
{
    Console.WriteLine("Введена нулевая координата по x и y ");
}