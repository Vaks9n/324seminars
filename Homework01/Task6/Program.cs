// Напишите программу которая на вход принимает число и выдает является ли оно четным

Console.WriteLine("Введите число: ");

double numberA = Convert.ToInt32(Console.ReadLine());

double numberB = numberA % 2;

if (numberB == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}

