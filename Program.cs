Console.WriteLine("введите значение n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("введите значение m:");
int m = int.Parse(Console.ReadLine());

int result = AckermannFunction(m, n);

Console.WriteLine($"результат функции для {m} и {n}");

static int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return 0;
}