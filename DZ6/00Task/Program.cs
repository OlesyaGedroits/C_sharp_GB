double vvod(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToDouble(System.Console.ReadLine());
}

double k1 = vvod("Введите коэффициент k1 для уравнения вида y=kx+b");
double b1 = vvod("Введите коэффициент b1 для уравнения вида y=kx+b");
double k2 = vvod("Введите коэффициент k2 для другого уравнения вида y=kx+b");
double b2 = vvod("Введите коэффициент b2 для другого уравнения вида y=kx+b");

if (k1==k2)
{
    if (b1==b2) System.Console.WriteLine("Линии вида y=kx+b при введенных коэффициентах лежат друг на друге");
    else System.Console.WriteLine("Линии вида y=kx+b при введенных коэффициентах параллельны друг другу");
}
else
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    System.Console.WriteLine($"Линии для уравнения вида y=kx+b пересекаются в точке с координатами ({x},{y})");
}
