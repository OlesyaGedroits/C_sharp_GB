// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию
// о том, сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

void Element (int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {   int a=array[0,0];
        int count=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[i,j]=a) count++;
        }
        
    }
}

int n = vvod("Введите количество строк: ");
int m = vvod("Введите количество столбцов: ");
int[,] array = fillarray(n, m);
printarray(array);
System.Console.WriteLine();

