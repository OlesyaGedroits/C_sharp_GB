// Напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице.
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением.
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями:
// значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице.
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition.
// Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть,
// вывести на экран "The number in [{x}, {y}] is {значение}".

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
    }
  
int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int [,] matrix = new int [n, m];
        int startNumber = new Random().Next(0,10);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix [i, j]=startNumber+k;
                startNumber=matrix[i,j];
            }        
        }
        return matrix;
    }
  
int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже


    }

// void PrintCheckIfError (int[] results, int X, int Y)
//     {
//       // Введите свое решение ниже


//     }

int n = 3;
int m = 4;
int k = 2;
int x = 2;
int y = 3;
// int[,] matrix=CreateIncreasingMatrix(n, m, k);
PrintArray(CreateIncreasingMatrix(n, m, k));