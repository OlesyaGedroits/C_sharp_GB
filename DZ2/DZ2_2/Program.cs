// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int chislo = Convert.ToInt32(num);
if (chislo<100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    System.Console.WriteLine(num[2]);
}