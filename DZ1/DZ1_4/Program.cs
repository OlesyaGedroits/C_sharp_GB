System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{number} -> ");
if (number>0)
{
    int second = 2;
    while (number>=second)
    {
        System.Console.Write($"{second}    ");
        second = second + 2;
    }
}
else
{
    int second = 0;
    while (number<=second)
    {
        System.Console.Write($"{second}    ");
        second = second - 2;
    }
}
