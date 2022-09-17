Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB )
{
    Console.WriteLine("Первое число " + numberA + " больше второго");

}
else
{
    Console.WriteLine("Второе число " + numberB + " большое первого");
}