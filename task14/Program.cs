// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.Write("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находиться в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находиться во второй четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находиться в третьей четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находиться в четвертой четверти");
}
else
{
    System.Console.WriteLine("Точка находиться на оси");
}
