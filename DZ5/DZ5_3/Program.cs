// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между
// максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. 
// Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.

double FindMax (double[] array)
{   
    double Max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>Max) Max=array[i];
    }
    return Max;
}

double FindMin (double[] array)
{   
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<Min) Min=array[i];
    }
    return Min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double Difference = FindMax(array)-FindMin(array);
    return Difference;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i!=array.Length-1) System.Console.Write("\t");
    }
    System.Console.WriteLine();
}

double[] array = new double[] {3.17, 8.94, 2.36, 5.72, 0.85};
PrintArray(array);
System.Console.WriteLine(CalcDifferenceBetweenMaxMin(array));
