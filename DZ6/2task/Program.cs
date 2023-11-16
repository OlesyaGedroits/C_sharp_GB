// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 double VvodDannych (string msg)
 {
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
 }

void TochkaPeresechen ()
{
 double k1 = VvodDannych("Введите k1: ");
 double b1 = VvodDannych("Введите b1: ");
 double k2 = VvodDannych("Введите k2: ");
 double b2 = VvodDannych("Введите b2: ");
 double x=(b2-b1)/(k1-k2);
 double y=k1*x+b1;
 if (k1==k2) System.Console.WriteLine("Прямые не пересекаются");
 else if (k1==k2 && b1==b2) System.Console.WriteLine("Прямые лежат друг на друге");
 else System.Console.WriteLine($"Точка пересечения имеет координаты ({x}; {y})");;
}

TochkaPeresechen();