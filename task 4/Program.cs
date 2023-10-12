System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{

    int digitLast = number % 10;
    System.Console.Write(digitLast);
}
else
{
    System.Console.WriteLine("Введите трехзначное число");
}
