// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Messege (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void SeriesOfNumbers (int N)
{
    if (N==1) return;
    System.Console.Write(N);
    System.Console.Write(", ");
    SeriesOfNumbers(N-1); 
}

int N = Messege("Введите натуральное число: ");
if(N<1) System.Console.WriteLine("Введено не натуральное число");
else
{
System.Console.Write("N = ");
SeriesOfNumbers(N);
System.Console.WriteLine("1");
};

