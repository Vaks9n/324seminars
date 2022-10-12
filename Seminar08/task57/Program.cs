﻿// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


void GetMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        matrix[i, j] = rand.Next(0, 10);
        Console.Write($"{matrix[i,j]}\t");
       }
       Console.WriteLine(); 
    }
}

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


void seachMatrix(int[,] matrix)
{
    int count = 0;
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] == k) count++;
            }

        }
        Console.WriteLine($"Элемент {k} встречается {count} раз");
        count = 0;
    }
}

// int m = ReadNumber("Введите количество строк");
// int n = ReadNumber("Введите количество столбцов");
// int[,] matr = GetMatrix(m, n);
// PrintMatrix(matr)
Console.Write("Введите кол-во строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[i, j];
Console.WriteLine("Полученная слуайная матрица: ");
GetMatrix(matrix);
Console.WriteLine("");
seachMatrix(matrix);

