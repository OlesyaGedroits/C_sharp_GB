Console.WriteLine("Введите число для проверки на четность: ");
int number = Convert.ToInt32(Console.ReadLine());
int second = number % 2;
if ( second == 0)
{
    System.Console.WriteLine($"Число `{number}` чётное");
}
else
{
    System.Console.WriteLine($"Число `{number}` нечётное");
}