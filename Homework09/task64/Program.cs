// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int a = 1;
void Print1toN(int n, int a)
{
    
    if(a > n)
    {
        return;
    }
    else
    {
        Print1toN(n, a + 1 );
        
        Console.Write(a + " ");
    }
}
 


int number = ReadNumber("Введите N");
Print1toN(number);