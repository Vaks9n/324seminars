// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = rand.Next(0, 151);
}
Console.WriteLine(string.Join(", ", arr));
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        sum = sum + 1;
    }
}

Console.WriteLine($"Количество элементов массива в отрезке от [10,99] = " + sum);