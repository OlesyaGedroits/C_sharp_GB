// Вычислить а  в степени n

// int PowerFor(int a, int n)
// { int result = 1;
//  for (int i = 1; i <= n; i++) result *= a;
//  return result;
// }
// int PowerRec(int a, int n)
// { return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//  if (n == 0) return 1;
//  else return PowerRec(a, n - 1) * a;
// }
int PowerRecMath(int a, int n) //здесь вычисление строится на математическом приеме,
// когда степень возведения разделяем на 2 и потом ее же в свою очередь возводим (получается меньше операций для программы)
{
 if (n == 0) return 1;
 else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
 else return PowerRecMath(a, n - 1) * a;
}
// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024
