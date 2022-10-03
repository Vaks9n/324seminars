// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = rand.Next(0, 150);
}
Console.WriteLine(string.Join(", ", arr));
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine(max);

int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine(min);

int difference = max - min;
Console.WriteLine($"Разница между макс и мин: " + difference);