// Задача №5. Напишите программу, которая на вход
// принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// System.Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberNegative = -number;
// if (number < 0)
// {
//     System.Console.WriteLine("Введите положительное число");
// }
// else
// {
//     while (numberNegative <= number)
//     {
//         System.Console.Write($"{numberNegative} ");
//         numberNegative++;
//     }
// }

System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
int numberNegative = -number;
while (numberNegative <= number)
{
    System.Console.Write($"{numberNegative} ");
    numberNegative++;
}