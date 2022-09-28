// 26 Напишите программу которая принимает на вход число и выдает количство цифр в числе
// 456 -3
// 78 - 2
// 89126 - 5

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (number > 0)
{
    number = number / 10;
    i++;
}
Console.WriteLine($"Количество цифр в числе: {i}");
// for (int i = 1;  number > 0; i++)
// {
//     number = number / 10;
// }


