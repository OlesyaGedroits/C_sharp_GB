// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Messege (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return Akkerman(m-1, 1);
    if (m>0 && n>0) return Akkerman(m-1, Akkerman(m, n-1));
    else return 0;
}

int m = Messege("Введите неотрицательное число m: ");
int n = Messege("Введите неотрицательное число n: ");
if (m<0 || n<0) System.Console.WriteLine("Число(а) отрицательное");
if (m>3) System.Console.WriteLine("Число получится слишком большое");
else System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");