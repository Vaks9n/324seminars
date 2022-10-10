// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int element1 = ReadNumber("Введите первую позицию элемента ");
int element2 = ReadNumber("Введите вторую позицию элемента");
int [,] GetMatrix(int rowcCount, int columsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowcCount, columsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1); 
        }
    }
    return matrix;
}

void  PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i,j]} ");
             
             
        }
        Console.WriteLine();
    }
   
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n); 
if (element1 < matr.GetLength(0) && element2 < matr.GetLength(1))
{
    Console.WriteLine(matr[element1, element2]);
}
else
{
    Console.WriteLine("Такого числа нет");
}


// int element1 = ReadNumber("Введите первую позицию элемента ");
// int element2 = ReadNumber("Введите вторую позицию элемента");
PrintMatrix(matr);