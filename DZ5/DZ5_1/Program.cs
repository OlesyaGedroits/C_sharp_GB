// Напишите программу, подсчитывающую количество четных элементов в массиве целых положительных трехзначных чисел
// и выводит результат на экран.
// метод CountEvenElements - принимает массив и возвращает количество четных элементов в массиве.
// метод PrintArray, - выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
// массив по умолчанию - {100, 102, 105, 166, 283, 764, 300, 499, 133}.

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) 
        {
          count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i!=(array.Length-1))
        {
            System.Console.Write("\t");
        }
    }
    System.Console.WriteLine();
}

int[] array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133};
PrintArray(array);

System.Console.WriteLine($"Количество четных элементов: {CountEvenElements(array)}");