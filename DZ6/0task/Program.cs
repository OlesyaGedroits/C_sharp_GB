// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

string [] VvodMassiva (string msg)
{
    System.Console.WriteLine(msg);
    string danye = Console.ReadLine();
    
    for (int i = 0; i < danye.Length; i++)
    {
        string[] newArray = new string[danye.Length];
        newArray[i]= danye[i];
    }
    return newArray;
}
System.Console.WriteLine(VvodMassiva("Введите данные: "));

