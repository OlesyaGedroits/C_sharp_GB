// Напишите программу для работы с матрицей целых чисел.
// Реализуйте следующие методы:
// SumOfRow(int[,] matrix, int row): для вычисления суммы элементов в заданной строке row матрицы matrix.
// Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.
// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
// номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.
// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

int SumOfRow (int[,] matrix, int row)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum=sum+matrix[row, i];
    }
    return sum;
}

int[] MinimumSumRow (int[,] matrix)
{
    int[] array=new int [2];
    array[0]=0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (SumOfRow(matrix, i)<SumOfRow(matrix, array[0])) array[0]=i;
          
    }
    array[1]=SumOfRow(matrix, array[0]);
    return array;
}

int [,] matrix = new int[,]
            {
                {5, 2, 9},
                {8, 1, 4},
                {1, 7, 3}
            };
Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

int[] minSumRow = MinimumSumRow(matrix);
Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
int rowToSum = 1;
int sum = SumOfRow(matrix, rowToSum);
Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
