// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 2; 



if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (number1 == 1) {
        while (number > 1000 )
    {
       number = number / 100;   
    }
    number = number % 10;
    Console.WriteLine(number);
    }
    else 
     {
        number = number * 10;
        while (number > 1000)
        {
            number = number / 100;
        }
        number = number % 10;
        Console.WriteLine(number);
    }
}



