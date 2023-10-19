// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// int a = 2;
// System.Console.WriteLine(Math.Pow(a, 2)); // Возведение в степень

double Distance2D(int Ax, int Ay, int Bx, int By)
{
    // double sumPow = Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2);
    // double result = Math.Sqrt(sumPow); // извлечение квадратного корня
    // return Math.Round(result, 3); // Округление числа
    return Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2)), 2);
}

int ReadData(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Ax = ReadData("Введите координату X у точки А: ");
int Ay = ReadData("Введите координату Y у точки А: ");
int Bx = ReadData("Введите координату X у точки B: ");
int By = ReadData("Введите координату Y у точки B: ");
System.Console.WriteLine(Distance2D(Ax, Ay, Bx, By));

// int a = 2;
// System.Console.WriteLine(Math.Pow(a, 2)); // Возведение в степень