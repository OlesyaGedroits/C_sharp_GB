// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] Fillarray (int num)
{
    int[] arr = new int [num];

    for (int i = 0; i < num; i++)
    {
       arr[i] = new Random().Next(0, 2);
    }

    return arr;
}


System.Console.Write("Введите колическво элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] a= Fillarray (number);

for (int i = 0; i < number-1; i++)
{   
   System.Console.Write($"{a[i]},");
}

System.Console.Write($"{a[number-1]}");


// int[] FillArray(int num)
// {
//     int[] arr = new int[num];

//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }

//     return arr;
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length - 1; i++)
//     {
//         System.Console.Write($"{a[i]},");
//     }
//     System.Console.Write($"{a[a.Length - 1]}");
// }

// System.Console.Write("Введите колическво элементов массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintArray(FillArray(number));



// System.Console.WriteLine($"[{string.Join(", ", FillArray(number))}]");
// string.Join - выводит массив через запятую из метода филэрэй