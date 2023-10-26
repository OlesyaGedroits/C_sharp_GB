//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }

    return arr;
}

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[GetNumber("Введите количество элементов массива: ")];

array = FillArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

if (array.Length%2 == 0)
{
    int newLength = array.Length/2;
    int[] newArr = new int[newLength];
    int index1 = 0;
    int index2 = array.Length - 1;
    for (int i = 0; i < newLength; i++)
    {
        newArr[i] = array[index1]*array[index2];
        index1++;
        index2--;
    }
    System.Console.WriteLine($"[{string.Join(", ", newArr)}]");
}
else
{
    int newLength = array.Length/2 + 1;
    int[] newArr = new int[newLength];
    int index1 = 0;
    int index2 = array.Length - 1;
    for (int i = 0; i < newLength; i++)
    {
        newArr[i] = array[index1]*array[index2];
        index1++;
        index2--;
    }
    newArr[newLength - 1] = array[newLength - 1];
    System.Console.WriteLine($"[{string.Join(", ", newArr)}]");
}
