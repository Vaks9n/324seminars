// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Write("Введите размер массива: ");

// int size = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[size];
// Random rand = new Random();


// Console.Write("Введите число для проверки: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0,6);
// }

// Далее идет мое решение программы
// Console.WriteLine(string.Join(", ",  arr));
// int Chislo = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == number )
//     {
//         Chislo = 1;
//     }
// }
// if (Chislo == 1)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Тут решение преподавателя

int [] GetArray(int size, int leftRange, int rightRange)
{
    int [] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsNumberInArray(int[] arr, int findNumber)
{
    bool IsNumberInArray = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            IsNumberInArray = true;
        }
    }
    return IsNumberInArray;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
int find = ReadNumber("Задайте число, которое хотите найти: ");
bool res = IsNumberInArray(array, find);
if(res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
