// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int n = vvod("Введите количество строк: ");
int m = vvod("Введите количество столбцов: ");
int[,] array = fillarray(n, m);
printarray(array);
System.Console.WriteLine();
int[,] arraytrans = fillarray(m, n);

for(int i=0;i<m;i++)
{
    for(int j=0; j<n; j++)
    {
       arraytrans[i,j] =array[j,i];
    }
}

printarray(arraytrans);
