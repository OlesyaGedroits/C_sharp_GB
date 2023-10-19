// Напишите программу, которая по заданному
// номеру четверти, показывает диапазон
// возможных координат точек в этой четверти
// (x и y).

Console.WriteLine("Введите номер четвнрти координатной плоскости");
int chetvert = Convert.ToInt32(System.Console.ReadLine());
string[] a={"x > 0 и y > 0", "x < 0 и y > 0", "x < 0 и y < 0", "x > 0 и y < 0"};
if (chetvert<1||chetvert>4)
{
    System.Console.WriteLine("Введенное число не является номером четверти");
}
else 
{
    System.Console.WriteLine(a[chetvert-1]);
}