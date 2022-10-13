
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int [,] matrix1  = new int [3,3]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
int [,] matrix2  = new int [3,3]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
int [,] resultmatrix = new int [3, 3];

void CreateNewMatrix(int[,] matrix1, int[,] matrix2, int [,] resultmatrix )
{
    for (int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            resultmatrix[i,j] = matrix1[i,j] * matrix2[i,j];
        }
    }
}
CreateNewMatrix(matrix1, matrix2, resultmatrix);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
PrintArray(resultmatrix);