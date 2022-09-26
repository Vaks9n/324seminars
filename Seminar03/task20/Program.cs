// 20 Напишите программу которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2 д пространстве
//

Console.WriteLine("Введите первую координату точки А: ");
double numA1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки А: ");
double numA2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату точки B: ");
double numB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки B: ");
double numB2 = Convert.ToInt32(Console.ReadLine());

// double X1 = numB1 - numA1;
// double X = X1 * X1;
// double Y1 = numB2 - numA2;
// double Y = Y1 * Y1;
// double number1 = X + Y;
// Console.WriteLine(Y);
// double number = Math.Sqrt(number1);

double res = Math.Sqrt(Math.Pow(numB1 - numA1, 2) + Math.Pow(numB2 - numA2, 2));

Console.WriteLine("Расстояние между точками в 2д пространстве: ");
Console.WriteLine($"{res:f2}");