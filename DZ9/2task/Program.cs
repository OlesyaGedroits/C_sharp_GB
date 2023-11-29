// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Messege (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Summa (int x, int y)
{
    if (x==y) return y;
    return x+Summa(x+1, y);
}

int M = Messege("Введите натуральное число M: ");
int N = Messege("Введите натуральное число N: ");
if (M<1 || N<1) System.Console.WriteLine("Введенны не натуральные число(а)");
else if (M==N) System.Console.WriteLine($"M = {M}; N = {N} -> {M}");
else if (M<N) System.Console.WriteLine($"M = {M}; N = {N} -> {Summa(M, N)}");
else if (M>N) System.Console.WriteLine($"M = {N}; N = {M} -> {Summa(N, M)}");
