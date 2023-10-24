// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N)
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

int ShowCube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        int cub = i*i*i;
        System.Console.WriteLine(cub);
    }

}


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
????????
