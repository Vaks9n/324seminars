// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
//   Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Для выхода из программы введите stop. Вводите числа: ");
bool per = true;
int sum = 0;
while ( per == true)
{
    
    string number = Console.ReadLine();
    if (number == "stop")
    {
        break;
    }
    int number1 = Convert.ToInt32(number);
    if (number1 > 0)
    {
         sum = sum + 1;
    }
    
}
Console.WriteLine($"Количество чисел больше 1: " + (sum));

