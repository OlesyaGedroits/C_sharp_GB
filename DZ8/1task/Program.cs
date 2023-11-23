// Напишите программу для работы с матрицей целых чисел.
// Реализуйте методы:
// PrintMatrix(int[,] matrix): для вывода матрицы на экран. Он принимает на вход двумерный массив
// целых чисел matrix и выводит его элементы в виде таблицы.
// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию.
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так,
// чтобы элементы в каждой строке шли по убыванию.
// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

void SortRowsDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int temp=0;
            int max = j;
            for (int next = j+1;  next< matrix.GetLength(1); next++)
            {
                if (matrix[i,max]<matrix[i,next]) max=next;
            }
            temp=matrix[i,j];
            matrix[i,j]=matrix[i,max];
            matrix[i,max]=temp;
        }
    }
}

int[,] matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

SortRowsDescending(matrix);
Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
PrintMatrix(matrix);