// Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumToN(int num)
{
    int sum = 1;
    for (int i = 2; i <= num; i++)
    {
        sum += i; // == sum = sum + i
    }
    return sum;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumToN(number);
System.Console.WriteLine(result);
