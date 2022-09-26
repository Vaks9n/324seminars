// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату xb: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату yb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату xc: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату yc: ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) +  Math.Pow(zb - za, 2 ));

Console.WriteLine("Расстояние между точками в 3д пространстве: ");
Console.WriteLine($"{distance:f2}");