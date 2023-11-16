// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int[] FillArray (int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        System.Console.Write($"Введите число {i+1}: ");
        arr[i]=Convert.ToInt32(Console.ReadLine());     
    }  
    return arr;
}
void Answer (int[] arr2)
{
    int positiv = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i]>0) positiv++;
    }
    System.Console.WriteLine($"Чисел больше ноля - {positiv}");
    return;
}
int[]array=FillArray(GetNumber("Какое количество чисел хотите ввести: "));
System.Console.WriteLine($"[{string.Join(",", array)}]");
Answer(array);