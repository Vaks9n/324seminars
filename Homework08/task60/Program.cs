// 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.WriteLine("Введите размер массива ");
Console.WriteLine("Введите X ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y ");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z ");
int Z = Convert.ToInt32(Console.ReadLine());

if (X*Y*Z > 90)
{
    Console.WriteLine("Невозможно задать такой массив");
    
}
int [,,] MyArr = new int[X, Y, Z];
int [] numbers = new int[X*Y*Z];  
bool foundNum = true;
int countNum =0; 
for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
            {
                for (int k = 0; k < Z; k++)
                {
                    while (foundNum)
                    {
                        MyArr[i,j,k] =  new Random().Next(10, 100);
                        foundNum = false;
                        for (int s =0 ; s <X*Y*Z; s++)  
                        {
                            if (numbers[s] == MyArr[i,j,k])
                            {
                                foundNum = true;
                                break;
                            }
                        }
                    }
                    
                    numbers[countNum] = MyArr[i,j,k];
                    countNum++;
                    foundNum = true;

                }
                
            }
        }

        
for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                Console.Write($"{MyArr[i,j,k]} ({i}, {j}, {k})    ");
            }
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    