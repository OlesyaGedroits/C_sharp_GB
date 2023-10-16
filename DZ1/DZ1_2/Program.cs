// int a = a;
// int b = b;
// int c = c;

// int FindMax = a;

// if(a>FindMax) FindMax = a;
// if(b>FindMax) FindMax = b;
// if(c>FindMax) FindMax = c;

// Console.Write("FindMax = ");
// Console.WriteLine(FindMax);

System.Console.WriteLine("Введите три числа:");
System.Console.Write("1. ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2. ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("3. ");
int c = Convert.ToInt32(Console.ReadLine());

int FindMax = a;
if(a>FindMax) FindMax = a;
if(b>FindMax) FindMax = b;
if(c>FindMax) FindMax = c;

Console.Write("Наибольшее из трех введеных -> ");
Console.WriteLine(FindMax);