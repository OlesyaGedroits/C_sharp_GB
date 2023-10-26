// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 // 82 -> 10 // 9012 -> 12

int SummaCifr (int number)
{
    int sum = 0;
    if (number<0)
    {
        number=number*-1;
    }
        while (number>0)
        {
            int x=number%10;
            number=number/10;
            sum = sum+x; 
        }
    return sum;
}
Console.WriteLine("Введите чиало: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaCifr(number));

