int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int number1 = number/100;
int number3 = number%10;
int number4 = number1*10+number3;
Console.Write(number4);
