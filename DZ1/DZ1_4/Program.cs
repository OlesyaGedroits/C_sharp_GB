// System.Console.Write("Введите целое положительно число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int second = 0;
// if (number>second)
// {
//         System.Console.Write($"number = {number} -> ");
// }
// while (number>second)
// {
//     System.Console.Write($"{second+2}    ");
//     second = second + 2;
// }

System.Console.Write("Введите целое положительно число ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{number} -> ");
for (int second = 2; second <= number; second += 2)
        {
            Console.Write($"{second}\t");
        }
