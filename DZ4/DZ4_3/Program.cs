// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] PrintArray (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i]=new Random().Next(-100, 101);
    }
    return mas;
}

int PrintMSG (string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[PrintMSG("Введите количество элеметов массива: ")];
System.Console.WriteLine($"[{string.Join(", ", PrintArray(array))}]");


