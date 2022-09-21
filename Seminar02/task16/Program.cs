// 16. Напишите программу, которая принимает на вход два числа и проверяет,
// явлеется ли число квадратом другого
// Пример
// 5, 25  - да
// -4, 16 - да 
// 25, 5   - да
// 8, 9 - нет 


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());



if (number1 == number2 * number2 || number2 == number1 * number1) {
    Console.WriteLine("Число является квадратом");
}
else
{ 
    Console.WriteLine("Число не является квадратом");
  
}
