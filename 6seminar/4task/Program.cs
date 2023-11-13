// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int chislo (string msg)
{
System.Console.WriteLine(msg);
return Convert.ToInt32(System.Console.ReadLine());
}

int n=chislo("Введите число: ");

int[] arr = new int[n];

if (n==0)
{
    System.Console.WriteLine("Последовательность не может быть выведена");
}
else if  (n==1)
{
    System.Console.WriteLine("0");
}
else if (n==2)
{
    System.Console.WriteLine("0 1");
} 
else
{
    arr[0]=0;
    arr[1]=1;

    for(int i=2; i<n; i++)
    {
        arr[i]=arr[i-2]+arr[i-1];
    }

    System.Console.WriteLine(string.Join(",", arr));
}
