// Напишите программу: находит сумму элементов с нечетными индексами в одномерном массиве
// целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements - принимает массив целых чисел
// и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (i%2==1) sum=sum+array[i];             
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            System.Console.Write("\t");
        }
    }
    System.Console.WriteLine();
}

int [] array = new int[] { 12, 10, 28, 90, 35};
PrintArray(array);
System.Console.WriteLine(SumOddElements(array));