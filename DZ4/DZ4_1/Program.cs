// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Stepen (int a, int b)
{
    double result=1;
    if (b==0)
    {
        return result;
    }
    else if (b>0)
    {
        for (int i = 1; i <= b; i++)
        {
            result=result*a;
        }
        return result;
    }
    else
    {
        for (int i = 1; i <= (b*-1); i++)
        {
            result=result*a;
        }
        return (1/result);
    }
}
Console.WriteLine("Введите два число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите два число В: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ($"{a} в степени {b} = {Stepen(a, b)}");