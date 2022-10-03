// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-99,99);
}

Console.WriteLine(string.Join(", ",  arr));
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * -1;
}
Console.WriteLine(string.Join(", ",  arr));