﻿// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет,
// является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False
// в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное + False (со следующей строки)



System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
int length = num.Length;

if (length==5)
{
    int i=0;
    int i2=length-1;
    if (num[i]==num[i2])
    {
        while (length>1)
        {
            length=length-2;
            i=i+1;
            i2=i2-1;
        }
    System.Console.WriteLine("True");
    }
    else
    {
        System.Console.WriteLine("False");
    }
}
else
{
    System.Console.WriteLine("Число не пятизначное");
    System.Console.WriteLine("False");
}