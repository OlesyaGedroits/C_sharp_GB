// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Напишите метод CreateRandomMatrix на прием m и n, а также minLimitRandom и maxLimitRandom,
// которые указывают на минимальную и максимальную границы случайных чисел.
// Также, задайте метод PrintArray, который выводил бы массив на экран.
// Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j]
// с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. 
// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[, ] matrix = new double[m, n];
   
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble()*(maxLimitRandom-minLimitRandom)+minLimitRandom;
            
        }
    }
    return matrix;
}

void PrintArray(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:F2}\t");
        }
        System.Console.WriteLine();
    }
}

int m = 3;
int n = 4;
int minLimitRandom = -10;
int maxLimitRandom = 10;
PrintArray(CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom));