// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int x1 = number%100;
int x3 = x1%10;
int x2 = (x1 - x3)/10;
System.Console.WriteLine($"-> {x2}");

// System.Console.WriteLine("Введите трехзначное число");
// string num = Console.ReadLine();
// System.Console.WriteLine(num[1]);
