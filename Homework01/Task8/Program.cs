// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа 
// от 1 до N

Console.WriteLine("Введите число: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= numberA )
{
    int numberB = count % 2;
    if (numberB == 1)
    {
        Console.Write("");
    }
    else
    {
        Console.WriteLine("Четное число " + count);
    }
    count = count +1;
}
