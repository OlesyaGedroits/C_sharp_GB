// Реализуйте методы:
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): для проверки, возможно ли умножения двух матриц matrixA и matrixB.
// Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply
// В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.
// MatrixMultiplication(int[,] matrixA, int[,] matrixB):для умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу,
// которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.
// PrintMatrix(int[,] matrix): для вывода матрицы на консоль.

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        PrintMatrix(MatrixMultiplication(matrixA, matrixB)); 
    }
    else
    {
        System.Console.WriteLine("It is impossible to multiply.");
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int [,] result = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
              
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result[i, j] = result[i, j] + matrixA[i, k] * matrixB[k, j];
            }    
        }    
    }
    return result;
}

void PrintMatrix (int[,] matrix)
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

int [,] matrix = new int[,]
            {
                {2, 4},
                {1, 3},
                {5, 6}
            };

Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

int[,] matrixB = {
            {5, 6},
            {7, 8}
                };

Console.WriteLine("\nMatrix B:");
PrintMatrix(matrixB);

Console.WriteLine("\nMultiplication result:");
MultiplyIfPossible(matrix, matrixB);

// Ожидаемый ответ:

// Исходная матрица:
// 2	4	
// 1	3	
// 5	6	

// Matrix B:
// 5	6	
// 7	8	

// Multiplication result:
// 38	44	
// 26	30	
// 67	78
