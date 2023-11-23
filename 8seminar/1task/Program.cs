// SЗадача 53: Задайте двумерный массив.
// Напишите программу, которая меняет местами первую и последнюю строку массива.


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

void printarray(int[,] array)
{   System.Console.WriteLine();
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

int n = vvod("Введите количество строк: ");
int m = vvod("Введите количество столбцов: ");
int[,] array = fillarray(n, m);

printarray(array);
int temp = 0;
for (int i = 0; i < m; i++)
{
    temp = array[0,i];
    array[0,i]=array[n-1,i];
    array[n-1,i]=temp;
}
printarray(array);

//второй вариант замены строки без переменной
for (int i = 0; i < m; i++)
{
    array[0,i]=array[0,i]+array[n-1,i];
    array[n-1,i]= array[0,i]-array[n-1,i];
    array[0,i]=array[0,i]-array[n-1,i];    
}
printarray(array);