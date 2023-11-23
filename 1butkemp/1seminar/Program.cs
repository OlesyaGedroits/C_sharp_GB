//Вывести таблицу умножения 

// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         System.Console.Write($"{i*j}\t");
//     }
//     System.Console.WriteLine();
// }
// на такой алгоритм у нас уходит время O(n*n), т.е. n^2, т.к. мы n раз проходим по 1 for  и потом по 2ому.


System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix=new int[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
       matrix[i,j]=(i+1)*(j+1);
       matrix[j,i]=(i+1)*(j+1);
    }
    System.Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
       System.Console.Write($"{matrix[i,j]}\t");
    }
    System.Console.WriteLine();
}
//тогда скорость алгоритма будет O(n^2 / 2)