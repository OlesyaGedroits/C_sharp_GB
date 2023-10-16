//Напишите программу, которая будет принимать на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит
// остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.WriteLine("Ведите два числа через Enter");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok=number1%number2;
if (ostatok==0)
{
Console.WriteLine("Кратно");
}
else
{
Console.WriteLine($"не кратно, остаток {ostatok}");
}
