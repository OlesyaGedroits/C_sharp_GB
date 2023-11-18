// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход n - кол-во строк матрицы,
// m - кол-во столбцов, k - число, на которое увеличивается каждый новый элемент.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double.
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.
// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате
// The averages in columns are:
// x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой
// (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    return;
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix=new int [n,m];
    int startNumber=1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i,j]=startNumber;
            startNumber+=k;
        }
    }
    return matrix;
}

void PrintListAvr (double [] list)
{
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.Write($"{list[i]:F2}\t");
    }
}

double [] FindAverageInColumns (int [,] matrix)
{ 
    double[] array=new double[matrix.GetLength(1)];    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum=0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum=sum+matrix[j,i];
        } 
        double srednee=sum/matrix.GetLength(0);
        array[i]=srednee;
    }
    return array;
}

int n = 3;
int m = 4;
int k = 2;
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
