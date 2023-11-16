// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

char [] VvodMassiva (string msg)
{
    System.Console.WriteLine(msg);
    string dannye = Console.ReadLine();
    char[] arr1 = dannye.ToCharArray();
    char[] newArray = new char[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        newArray[i]= arr1[i];
    }
    return newArray;
}
System.Console.WriteLine(VvodMassiva("Введите данные: "));

