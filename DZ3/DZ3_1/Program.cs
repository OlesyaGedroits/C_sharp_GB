﻿// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет,
// является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False
// в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное

int number = 645456;
string num = Convert.ToString(number);

int IsPalindrome (string num)

{
    int index = num.Length;
    if (index<5 || index>5)
    {
        System.Console.WriteLine("Число не пятизначное");
    }
}
IsPalindrome;
System.Console.WriteLine(IsPalindrome);