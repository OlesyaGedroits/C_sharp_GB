// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите порядковый день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 7 || day < 1)
{
    System.Console.WriteLine("Введено число не из диапозона дней недели");
}
else if (day==6 || day==7)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}