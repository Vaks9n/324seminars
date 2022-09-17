//Напишите программу которая на вход принимает три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberC && numberA > numberC )
{
    Console.WriteLine("Первое число " + numberA + " больше всех");

}

if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine("Второе число " + numberB + " больше всех");
}

if (numberC > numberA && numberC > numberB)
{
    Console.WriteLine("Третье число " + numberC + " больше всех");
}