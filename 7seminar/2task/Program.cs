// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1    4   49  2
// 5    9    2    3
// 64  4   4    4


int[,] fillarray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int vvod(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

void printarray (int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    return;
}

int[,] changearray(int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i=i+2)
    {
        for (int j = 0; j < array.GetLength(1); j=j+2)
        {
            array[i, j] = array[i, j]*array[i, j];
        }
    }
    return array;
}

int n = vvod("Введите количество строк в матрице: ");
int m = vvod("Введите количество столбцов в матрице: ");

int[,] arr = fillarray(n, m);
printarray (arr);
arr=changearray(arr);
System.Console.WriteLine();
printarray (arr);