// 11. Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100,1000);
Console.WriteLine(number);

int numb1 = number % 10; // Правая часть числа
int numb2 = number / 100; // Левая часть числа

int numb3 = (numb2 * 10) + numb1;

Console.WriteLine(numb3);


